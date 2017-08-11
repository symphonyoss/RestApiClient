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
        /// Creates a datafeed and starts listening to it, notifying event handlers about
        /// incoming messages. Blocks until <see cref="AbstractDatafeedApi.Stop"/> is invoked.
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
                var datafeedId = CreateDatafeed();
                Listen(ref datafeedId, 1);
            }
            finally
            {
                Listening = false;
            }
        }

        /// <summary>
        /// Starts listening to a specified datafeed, notifying event handlers about incoming
        /// messages. Blocks until <see cref="AbstractDatafeedApi.Stop"/> is invoked.
        /// </summary>
        /// <param name="datafeedId">The ID of the datafeed.</param>
        public void Listen(string datafeedId)
        {
            try
            {
                if (Listening)
                {
                    return;
                }
                Listening = true;
                ShouldStop = false;
                Listen(ref datafeedId, 0);
            }
            finally
            {
                Listening = false;
            }
        }

        private void Listen(ref string datafeedId, int retriesAllowed)
        {
            while (!ShouldStop)
            {
                var messageList = ReadDatafeed(ref datafeedId, retriesAllowed: retriesAllowed);
                if (ShouldStop)
                {
                    // Don't process messages if the user has stopped listening.
                    break;
                }

                ProcessMessageList(messageList);
            }
        }

        /// <summary>
        /// Creates a datafeed.
        /// </summary>
        /// <returns>The ID of the datafeed.</returns>
        public string CreateDatafeed()
        {
            var datafeed = ApiExecutor.Execute(_datafeedApi.V4DatafeedCreatePost, AuthTokens.SessionToken, AuthTokens.KeyManagerToken);
            return datafeed.Id;
        }

        private V4EventList ReadDatafeed(string id, int? maxMessages = null)
        {
            return ReadV4Datafeed(id, maxMessages);
        }

        private V4EventList ReadV4Datafeed(string id, int? maxMessages)
        {
            return ApiExecutor.Execute(
                _datafeedApi.V4DatafeedIdReadGet,
                id, AuthTokens.SessionToken, AuthTokens.KeyManagerToken,
                maxMessages);

        }

        private V4EventList ReadDatafeed(ref string id, int? maxMessages = null, int? retriesAllowed = 1)
        {
            var countDatafeedErrors = 0;
            while (true)
            {
                try
                {
                    var messageList = ReadDatafeed(id, maxMessages);
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
                    if (countDatafeedErrors >= retriesAllowed)
                    {
                        throw;
                    }
                    ++countDatafeedErrors;
                    TraceSource.TraceEvent(
                        TraceEventType.Error, 0,
                        "Unhandled API exception caught when reading data feed, retrying: {0}", e);
                    id = CreateDatafeed();
                }
            }
        }
    }
}
