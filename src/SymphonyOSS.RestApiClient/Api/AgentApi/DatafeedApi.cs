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

using System;

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using System.Diagnostics;
    using Authentication;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;

    /// <summary>
    /// Provides an event-based data feed of a user's incoming messages.
    /// Encapsulates <see cref="Generated.OpenApi.AgentApi.Api.DatafeedApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class DatafeedApi : AbstractDatafeedApi
    {
        private static readonly TraceSource TraceSource = new TraceSource("SymphonyOSS.RestApiClient");

        private readonly Generated.OpenApi.AgentApi.Api.IDatafeedApi _datafeedApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatafeedApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public DatafeedApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor) : base(authTokens, apiExecutor)
        {
            _datafeedApi = new Generated.OpenApi.AgentApi.Api.DatafeedApi(configuration);
        }

        /// <summary>
        /// Starts listening, notifying event handlers about incoming messages. Blocks
        /// until <see cref="AbstractDatafeedApi.Stop"/> is invoked.
        /// </summary>
        public void Listen()
        {
            try
            {
                if (Listening)
                {
                    return;
                }
                Listening = true;
                ShouldStop = false;
                var datafeed = CreateDatafeed();
                while (!ShouldStop)
                {
                    var messageList = ReadDatafeed(ref datafeed);
                    if (ShouldStop)
                    {
                        // Don't process messages if the user has stopped listening.
                        break;
                    }

                    ProcessMessageList(messageList);
                }
            }
            finally
            {
                Listening = false;
            }
        }

        private Datafeed CreateDatafeed()
        {
            return ApiExecutor.Execute(_datafeedApi.V1DatafeedCreatePost, AuthTokens.SessionToken, AuthTokens.KeyManagerToken);
        }

        private V2MessageList ReadDatafeed(string id, int? maxMessages = null)
        {
            return ApiExecutor.Execute(_datafeedApi.V2DatafeedIdReadGet, id, AuthTokens.SessionToken, AuthTokens.KeyManagerToken, maxMessages);
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
