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
    using System.Collections.Concurrent;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Authentication;
    using Factories;
    using Generated.Json;
    using Generated.OpenApi.AgentApi.Model;
    using Entities;
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

        private readonly ConcurrentDictionary<Delegate, Task> _inflightEvents = new ConcurrentDictionary<Delegate, Task>();

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

        /// <summary>
        /// True if currently listening for incoming messages, false if not.
        /// </summary>
        public bool Listening { get; protected set; }

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
                Task t;
                _inflightEvents.TryRemove(value, out t);
            }
        }

        private event EventHandler<ConnectionRequestedEventArgs> _onConnectionRequested;
        public event EventHandler<ConnectionRequestedEventArgs> OnConnectionRequested
        {
            add
            {
                _onConnectionRequested += value;
            }
            remove
            {
                _onConnectionRequested -= value;
                Task t;
                _inflightEvents.TryRemove(value, out t);
            }
        }

        private event EventHandler<ConnectionAcceptedEventArgs> _onConnectionAccepted;
        public event EventHandler<ConnectionAcceptedEventArgs> OnConnectionAccepted
        {
            add
            {
                _onConnectionAccepted += value;
            }
            remove
            {
                _onConnectionAccepted -= value;
                Task t;
                _inflightEvents.TryRemove(value, out t);
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

        protected Task CreateInvocationTask<EventHandlerArgs>(EventHandler<EventHandlerArgs> evtHandler, EventHandlerArgs args)
        {
            Task pendingTask;
            if (_inflightEvents.TryGetValue(evtHandler, out pendingTask))
            {
                return Task.Run(() =>
                {
                    // Todo MALAY catch exceptions
                    pendingTask.Wait();
                    evtHandler.Invoke(this, args);
                });
            } else
            {
                return Task.Run(() => evtHandler.Invoke(this, args));
            }
        }

        void InvokeEventHandlers<EventHandlerArgs>(EventHandler<EventHandlerArgs> evtHandler, EventHandlerArgs args)
        {
            if (evtHandler == null)
            {
                return;
            }

            foreach (var subhandler in evtHandler.GetInvocationList())
            {
                _inflightEvents[subhandler] = CreateInvocationTask(subhandler as EventHandler<EventHandlerArgs>, args);
            }
        }

        protected void FireMessage(V4Message message)
        {
            var eventArgs = new MessageEventArgs(MessageFactory.Create(message));
            InvokeEventHandlers(_onMessage, eventArgs);
        }

        protected void FireConnectionRequested(V4Event message) {
            User fromUser = UserFactory.Create(message.Initiator.User);
            User toUser = UserFactory.Create(message.Payload.ConnectionRequested.ToUser);

            var eventArgs = new ConnectionRequestedEventArgs(fromUser, toUser);
            InvokeEventHandlers(_onConnectionRequested, eventArgs);
        }

        protected void FireConnectionAccepted(V4Event message)
        {
            User toUser = UserFactory.Create(message.Initiator.User);
            User fromUser = UserFactory.Create(message.Payload.ConnectionAccepted.FromUser);

            var eventArgs = new ConnectionAcceptedEventArgs(fromUser, toUser);
            InvokeEventHandlers(_onConnectionAccepted, eventArgs);
        }

        protected void ProcessMessageList(V4EventList messageList)
        {
            if (messageList == null)
            {
                return;
            }

            foreach (var message in messageList)
            {
                switch(message.Type)
                {
                    case V4Event.TypeEnum.MESSAGESENT:
                        FireMessage(message.Payload.MessageSent.Message);
                        break;
                    case V4Event.TypeEnum.CONNECTIONREQUESTED:
                        FireConnectionRequested(message);
                        break;
                    case V4Event.TypeEnum.CONNECTIONACCEPTED:
                        FireConnectionAccepted(message);
                        break;
                }
            }
        }
    }
}
