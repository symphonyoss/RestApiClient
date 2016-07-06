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
    /// Provides an event-based firehose of a pod's incoming messages.
    /// Encapsulates <see cref="Generated.OpenApi.AgentApi.Api.FirehoseApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class FirehoseApi : AbstractDatafeedApi
    {
        private static readonly TraceSource TraceSource = new TraceSource("SymphonyOSS.RestApiClient");

        private readonly Generated.OpenApi.AgentApi.Api.IFirehoseApi _firehoseApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="FirehoseApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public FirehoseApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor) : base(authTokens, apiExecutor)
        {
            _firehoseApi = new Generated.OpenApi.AgentApi.Api.FirehoseApi(configuration);
        }

        /// <summary>
        /// Starts listening, notifying event handlers about incoming messages. Blocks
        /// until <see cref="AbstractDatafeedApi.Stop"/> is invoked.
        /// </summary>
        public void Listen()
        {
            ShouldStop = false;
            var firehose = CreateFirehose();
            while (!ShouldStop)
            {
                var messageList = ReadFirehose(ref firehose);
                if (ShouldStop)
                {
                    // Don't process messages if the user has stopped listening.
                    break;
                }

                ProcessMessageList(messageList);
            }
        }

        private Firehose CreateFirehose()
        {
            return ApiExecutor.Execute(_firehoseApi.V1FirehoseCreatePost, AuthTokens.SessionToken, AuthTokens.KeyManagerToken);
        }

        private V2MessageList ReadFirehose(string id, int? maxMessages = null)
        {
            return ApiExecutor.Execute(_firehoseApi.V2FirehoseIdReadGet, id, AuthTokens.SessionToken, AuthTokens.KeyManagerToken, maxMessages);
        }

        private V2MessageList ReadFirehose(ref Firehose firehose, int? maxMessages = null)
        {
            var countFirehoseErrors = 0;
            while (true)
            {
                try
                {
                    var messageList = ReadFirehose(firehose.Id, maxMessages);
                    if (countFirehoseErrors > 0)
                    {
                        TraceSource.TraceEvent(
                            TraceEventType.Information, 0,
                            "Firehose re-established.");
                    }
                    return messageList;
                }
                catch (ApiException e)
                {
                    ++countFirehoseErrors;
                    if (countFirehoseErrors >= 2)
                    {
                        throw;
                    }
                    TraceSource.TraceEvent(
                        TraceEventType.Error, 0,
                        "Unhandled API exception caught when reading firehose, retrying: {0}", e);
                    firehose = CreateFirehose();
                }
            }
        }
    }
}
