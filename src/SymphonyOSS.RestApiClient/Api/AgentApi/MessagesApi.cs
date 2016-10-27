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

using SymphonyOSS.RestApiClient.Entities;

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Authentication;
    using Factories;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;
    using Message = Entities.Message;

    /// <summary>
    /// Provides methods for posting to and retrieving messages from streams, by
    /// encapsulating <see cref="Generated.OpenApi.AgentApi.Api.MessagesApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class MessagesApi
    {
        private static readonly TraceSource TraceSource = new TraceSource("SymphonyOSS.RestApiClient");

        private readonly Generated.OpenApi.AgentApi.Api.IMessagesApi _messagesApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public MessagesApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _messagesApi = new Generated.OpenApi.AgentApi.Api.MessagesApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Post a message to an existing stream.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>The posted message.</returns>
        public Message PostMessage(Message message)
        {
            TraceSource.TraceEvent(TraceEventType.Verbose, 0, "Posting message to stream \"{0}\"", message.StreamId);
            var attachments = new List<AttachmentInfo>();
            foreach (var attachment in message.Attachments)
            {
                attachments.Add(new AttachmentInfo(attachment.Id, attachment.Name, attachment.Size));
            }
            var format = message.Format == MessageFormat.MessageML
                ? V2MessageSubmission.FormatEnum.MESSAGEML
                : V2MessageSubmission.FormatEnum.TEXT;
            var v2MessageSubmission = new V2MessageSubmission(format, message.Body, attachments);
            V2Message v2Message;
            if (_authTokens.KeyManagerToken == null)
            {
                // Use the endpoint that works with OBO authentication.
                v2Message = _apiExecutor.Execute(_messagesApi.V3StreamSidMessageCreatePost, message.StreamId, _authTokens.SessionToken, v2MessageSubmission, _authTokens.KeyManagerToken);
            }
            else
            {
                v2Message = _apiExecutor.Execute(_messagesApi.V2StreamSidMessageCreatePost, message.StreamId, _authTokens.SessionToken, _authTokens.KeyManagerToken, v2MessageSubmission);
            }
            return MessageFactory.Create(v2Message);
        }

        /// <summary>
        /// Get messages from a stream.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="since">Timestamp of first required message. This is a long integer value representing milliseconds since 1 January 1970.</param>
        /// <param name="offset">Number of messages to skip.</param>
        /// <param name="maxMessages">Max number of messages to return. If no value is provided, 50 is the default.</param>
        /// <returns>The list of messages.</returns>
        public List<Message> GetMessages(string sid, long? since, int? offset = null, int? maxMessages = null)
        {
            var v2MessageList = _apiExecutor.Execute(_messagesApi.V2StreamSidMessageGet, sid, since, _authTokens.SessionToken, _authTokens.KeyManagerToken, offset, maxMessages);
            var result = new List<Message>();
            if (v2MessageList != null)
            {
                foreach (var v2Message in v2MessageList)
                {
                    result.Add(MessageFactory.Create(v2Message));
                }
            }
            return result;
        }
    }
}
