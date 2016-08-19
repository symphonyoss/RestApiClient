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
    using System.Diagnostics;
    using Authentication;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;

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
        /// <param name="sid">Stream ID.</param>
        /// <param name="message">The message.</param>
        /// <returns>The posted message.</returns>
        public V2Message PostMessage(string sid, V2MessageSubmission message)
        {
            TraceSource.TraceEvent(TraceEventType.Verbose, 0, "Posting message to stream \"{0}\"", sid);
            return _apiExecutor.Execute(_messagesApi.V2StreamSidMessageCreatePost, sid, _authTokens.SessionToken, _authTokens.KeyManagerToken, message);
        }

        /// <summary>
        /// Get messages from a stream.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="since">Timestamp of first required message. This is a long integer value representing milliseconds since 1 January 1970.</param>
        /// <param name="offset">Number of messages to skip.</param>
        /// <param name="maxMessages">Max number of messages to return. If no value is provided, 50 is the default.</param>
        /// <returns>The list of messages.</returns>
        public V2MessageList GetMessages(string sid, long? since, int? offset = null, int? maxMessages = null)
        {
            return _apiExecutor.Execute(_messagesApi.V2StreamSidMessageGet, sid, since, _authTokens.SessionToken, _authTokens.KeyManagerToken, offset, maxMessages);
        }
    }
}
