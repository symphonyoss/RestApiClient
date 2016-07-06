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
    using Generated.OpenApi.AgentApi.Model;

    /// <summary>
    /// Abstract superclass for datafeed-type Apis, eg <see cref="Generated.OpenApi.AgentApi.Api.DatafeedApi"/>
    /// and <see cref="Generated.OpenApi.AgentApi.Api.FirehoseApi"/>.
    /// </summary>
    public abstract class AbstractDatafeedApi
    {
        private static readonly TraceSource TraceSource = new TraceSource("SymphonyOSS.RestApiClient");

        protected readonly IAuthTokens AuthTokens;

        protected readonly IApiExecutor ApiExecutor;

        protected volatile bool ShouldStop;

        private readonly Dictionary<EventHandler<MessageEventArgs>, Task> _tasks = new Dictionary<EventHandler<MessageEventArgs>, Task>();

        static AbstractDatafeedApi()
        {
            JsonSubtypeConverter.Register(typeof(V2Message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatafeedApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        protected AbstractDatafeedApi(IAuthTokens authTokens, IApiExecutor apiExecutor)
        {
            AuthTokens = authTokens;
            ApiExecutor = apiExecutor;
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
        /// Requests that <see cref="Listen"/> should stop blocking and return control
        /// to the calling thread. Calling <see cref="Stop"/> will not immediately return
        /// control, but wait for the current outstanding request to complete.
        /// </summary>
        public void Stop()
        {
            ShouldStop = true;
        }

        protected void ProcessMessageList(V2MessageList messageList)
        {
            if (messageList == null || _onMessage == null)
            {
                return;
            }

            foreach (var eventHandler in _onMessage.GetInvocationList())
            {
                NotifyAsync((EventHandler<MessageEventArgs>)eventHandler, messageList);
            }
        }

        protected async void NotifyAsync(EventHandler<MessageEventArgs> messageEventHandler, V2MessageList messageList)
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
    }
}
