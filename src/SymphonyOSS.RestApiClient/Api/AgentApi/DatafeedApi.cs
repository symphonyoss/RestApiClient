// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Authentication;
    using Generated.Json;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;

    /// <summary>
    /// Provides an event-based data feed of a user's incoming messages.
    /// Encapsulates <see cref="Generated.OpenApi.AgentApi.Api.DatafeedApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class DatafeedApi
    {
        private static readonly TraceSource TraceSource = new TraceSource("SymphonyOSS.RestApiClient");

        private readonly Generated.OpenApi.AgentApi.Api.IDatafeedApi _datafeedApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        private readonly Dictionary<EventHandler<MessageEventArgs>, Task> _tasks = new Dictionary<EventHandler<MessageEventArgs>, Task>();

        private volatile bool _shouldStop;

        static DatafeedApi()
        {
            JsonSubtypeConverter.Register(typeof(V2Message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatafeedApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public DatafeedApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _datafeedApi = new Generated.OpenApi.AgentApi.Api.DatafeedApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        private event EventHandler<MessageEventArgs> _onMessage;
        public event EventHandler<MessageEventArgs> OnMessage
        {
            add
            {
                _onMessage += value;
            }
            remove
            {
                _onMessage -= value;
                lock (_tasks)
                {
                    _tasks.Remove(value);
                }
            }
        }

        /// <summary>
        /// Starts listening, notifying event handlers about incoming messages. Blocks
        /// until <see cref="Stop"/> is invoked.
        /// </summary>
        public void Listen()
        {
            _shouldStop = false;
            var datafeed = CreateDatafeed();
            while (!_shouldStop)
            {
                var messageList = ReadDatafeed(ref datafeed);
                if (_shouldStop)
                {
                    // Don't process messages if the user has stopped listening.
                    break;
                }

                if (messageList == null || _onMessage == null)
                {
                    continue;
                }

                foreach (var eventHandler in _onMessage.GetInvocationList())
                {
                    NotifyAsync((EventHandler<MessageEventArgs>)eventHandler, messageList);
                }
            }
        }

        /// <summary>
        /// Requests that <see cref="Listen"/> should stop blocking and return control
        /// to the calling thread. Calling <see cref="Stop"/> will not immediately return
        /// control, but wait for the current outstanding request to complete.
        /// </summary>
        public void Stop()
        {
            _shouldStop = true;
        }

        private async void NotifyAsync(EventHandler<MessageEventArgs> messageEventHandler, V2MessageList messageList)
        {
            // Notify each handler in a separate task, maintaining the order of messages in the list, and
            // get back to reading the data feed again without waiting for listeners to process messages.
            Task task;
            if (_tasks.TryGetValue(messageEventHandler, out task))
            {
                await task;
            }
            _tasks[messageEventHandler] = Task.Run(() => Notify(messageEventHandler, messageList));
        }

        private void Notify(EventHandler<MessageEventArgs> messageEventHandler, V2MessageList messageList)
        {
            foreach (var message in messageList)
            {
                TraceSource.TraceEvent(
                    TraceEventType.Verbose, 0,
                    "Notifying listener about message with ID \"{0}\" in stream \"{1}\"",
                    (message as V2Message)?.Id, (message as V2Message)?.StreamId);
                try
                {
                    messageEventHandler.Invoke(this, new MessageEventArgs(message));
                }
                catch (Exception e)
                {
                    TraceSource.TraceEvent(
                        TraceEventType.Error, 0,
                        "Unhandled exception caught when notifying listener about message with ID \"{0}\": {1}",
                        message.Id, e);
                }
            }
        }

        private Datafeed CreateDatafeed()
        {
            return _apiExecutor.Execute(_datafeedApi.V1DatafeedCreatePost, _authTokens.SessionToken, _authTokens.KeyManagerToken);
        }

        private V2MessageList ReadDatafeed(string id, int? maxMessages = null)
        {
            return _apiExecutor.Execute(_datafeedApi.V2DatafeedIdReadGet, id, _authTokens.SessionToken, _authTokens.KeyManagerToken, maxMessages);
        }

        private V2MessageList ReadDatafeed(ref Datafeed datafeed, int? maxMessages = null)
        {
            var countDatafeedErrors = 0;
            while (true)
            {
                try
                {
                    var messageList = ReadDatafeed(datafeed.Id, maxMessages);
                    if (countDatafeedErrors > 0)
                    {
                        TraceSource.TraceEvent(
                            TraceEventType.Information, 0,
                            "Data feed re-established.");
                    }
                    return messageList;
                }
                catch (ApiException e)
                {
                    ++countDatafeedErrors;
                    if (countDatafeedErrors >= 2)
                    {
                        throw;
                    }
                    TraceSource.TraceEvent(
                        TraceEventType.Error, 0,
                        "Unhandled API exception caught when reading data feed, retrying: {0}", e);
                    datafeed = CreateDatafeed();
                }
            }
        }
    }
}
