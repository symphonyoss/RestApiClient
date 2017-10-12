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
using System.Collections.Generic;

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using System.Diagnostics;
    using Authentication;
    using Generated.OpenApi.AgentApi;
    using System.Net.Http;
    using Microsoft.Extensions.Logging;
    using SymphonyOSS.RestApiClient.Logging;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides an event-based data feed of a user's incoming messages.
    /// Encapsulates <see cref="Generated.OpenApi.AgentApi.Api.DatafeedApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class DatafeedApi : AbstractDatafeedApi
    {
        private readonly Generated.OpenApi.AgentApi.DatafeedClient  _datafeedApi;

        private ILogger _log;
        /// <summary>
        /// Initializes a new instance of the <see cref="DatafeedApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public DatafeedApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor) : base(authTokens, apiExecutor)
        {
            _datafeedApi = new Generated.OpenApi.AgentApi.DatafeedClient(baseUrl, httpClient);
            _log = ApiLogging.LoggerFactory?.CreateLogger<DatafeedApi>();
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
            try
            {
                while (!ShouldStop)
                {
                    var messageList = ReadDatafeed(ref datafeedId, retriesAllowed: retriesAllowed);
                    if (ShouldStop)
                    {
                        // Don't process messages if the user has stopped listening.
                        _log?.LogDebug("Stopped listening on datafeed {datafeedId}", datafeedId);
                        break;
                    }

                    ProcessMessageList(messageList);
                }
            }
            catch (Exception e)
            {
                _log?.LogDebug(0, e, "Datafeed Listening stopped due to exception in datafeed {datafeedId}", datafeedId);
                throw;
            }
        }

        /// <summary>
        /// Creates a datafeed.
        /// </summary>
        /// <returns>The ID of the datafeed.</returns>
        public string CreateDatafeed()
        {
            var datafeed = ApiExecutor.Execute(_datafeedApi.V4CreateAsync, AuthTokens.SessionToken, AuthTokens.KeyManagerToken);
            return datafeed.Id;
        }

        private IEnumerable<V4Event> ReadDatafeed(string id, int? maxMessages = null)
        {
            _log?.LogDebug("Waiting for messages on datafeed id = {id}", id);

            var task = ApiExecutor.ExecuteAsync(() =>
                _datafeedApi.V4ReadAsync(id, AuthTokens.SessionToken, AuthTokens.KeyManagerToken, maxMessages));

            try
            {
                return task.Result;
            }
            catch (AggregateException ae)
            {
                ae.Handle((ex) =>
                {
                    if (ex is ApiException)
                    {
                        var se = ex as ApiException;
                        if (se.HttpStatusCode == 204)
                        {
                            return true;
                        }
                    }
                    return false;
                });
            }

            // if we're still here, that means we caught a 204 error from the swagger exception
            // this means there were no new messages so simply return an empty list
            return new List<V4Event>();
        }

        private IEnumerable<V4Event> ReadDatafeed(ref string id, int? maxMessages = null, int? retriesAllowed = 1)
        {
            var countDatafeedErrors = 0;
            while (true)
            {
                try
                {
                    var messageList = ReadDatafeed(id, maxMessages);
                    if (countDatafeedErrors > 0)
                    {
                        _log?.LogInformation("Datafeed re-established, id = {0}", id);
                    }
                    return messageList;
                }
                catch (ApiException e)
                {
                    if (countDatafeedErrors >= retriesAllowed)
                    {
                        _log?.LogWarning(0, e, "API Exception detected when reading datafeed id {id}", id);
                        throw;
                    }
                    ++countDatafeedErrors;
    
                    _log?.LogWarning(0, e, "Unhandled API Exception caught when reading datafeed id {id}", id);
                    id = CreateDatafeed();
                }
            }
        }
    }
}
