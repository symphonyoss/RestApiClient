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

using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SymphonyOSS.RestApiClient.Entities;
using Stream = SymphonyOSS.RestApiClient.Entities.Stream;

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using System.Collections.Generic;
    using Authentication;
    using Factories;
    using Generated.OpenApi.AgentApi;
    using Message = Entities.Message;
    using System.Linq;
    using Logging;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Provides methods for posting to and retrieving messages from streams, by
    /// encapsulating <see cref="Generated.OpenApi.AgentApi.Api.MessagesApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class MessagesApi
    {
        private ILogger _log;

        private readonly Generated.OpenApi.AgentApi.StreamClient _streamClient;

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
        public MessagesApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _log = ApiLogging.LoggerFactory?.CreateLogger<MessagesApi>();

            _streamClient = new Generated.OpenApi.AgentApi.StreamClient(baseUrl, httpClient);
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
            var streamId = message.StreamId;
            _log?.LogDebug("Posting message to {streamId}", streamId);
            var attachments = new System.Collections.ObjectModel.ObservableCollection<AttachmentInfo>();
            foreach (var attachment in message.Attachments)
            {
                attachments.Add(new AttachmentInfo() { Id = attachment.Id, Name = attachment.Name, Size = attachment.Size});
            }
            var v2MessageSubmission = new V2MessageSubmission() { Format = V2MessageSubmissionFormat.MESSAGEML,  Message = message.Body, Attachments = attachments};
            V2Message v2Message;
            if (_authTokens.KeyManagerToken == null)
            {
                // Use the endpoint that works with OBO authentication.
                v2Message = _apiExecutor.Execute(_streamClient.V3MessageCreateAsync, message.StreamId, _authTokens.SessionToken, v2MessageSubmission, _authTokens.KeyManagerToken);
            }
            else
            {
                v2Message = _apiExecutor.Execute(_streamClient.V2MessageCreateAsync, message.StreamId, _authTokens.SessionToken, _authTokens.KeyManagerToken, v2MessageSubmission);
            }
            return MessageFactory.Create(v2Message);
        }

        public Message PostMessage(MessageSubmit msg)
        {
            FileParameter attachment = null;
            if (msg.Attachments != null)
            {
                attachment = msg.Attachments.Select(x => new FileParameter(new MemoryStream(x.Value), x.Key)).FirstOrDefault();
            }

            System.Func<string, string, string, string, string, string, FileParameter, CancellationToken, Task<V4Message>> func = (string a, string b, string c, string d, string e, string f, FileParameter g, CancellationToken token) =>  _streamClient.V4MessageCreateAsync(a, b, c, d, e, f, g, token);
            V4Message response = _apiExecutor.Execute(func, msg.StreamId, _authTokens.SessionToken, msg.Body, _authTokens.KeyManagerToken, msg.Data, null, attachment);
            return MessageFactory.Create(response);
        }

        /// <summary>
        /// Get messages from a stream.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="since">Timestamp of first required message. This is a long integer value representing milliseconds since 1 January 1970.</param>
        /// <param name="offset">Number of messages to skip.</param>
        /// <param name="maxMessages">Max number of messages to return. If no value is provided, 50 is the default.</param>
        /// <returns>The list of messages.</returns>
        public List<Message> GetMessages(string sid, long since, int? offset = null, int? maxMessages = null)
        {
            var v4MessageList = _apiExecutor.Execute<string, long, string, string, int?, int?, System.Collections.ObjectModel.ObservableCollection<V4Message>>(_streamClient.V4MessageAsync, sid, since, _authTokens.SessionToken, _authTokens.KeyManagerToken, offset, maxMessages);
            var result = new List<Message>();
            if (v4MessageList != null)
            {
                foreach (var v4Message in v4MessageList)
                {
                    result.Add(MessageFactory.Create(v4Message));
                }
            }
            return result;
        }
    }
}
