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

using System.Net.Http;

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using Authentication;
    using Generated.OpenApi.AgentApi;

    /// <summary>
    /// Provides methods for testing endpoint, or use an example of an obsolete endpoint.
    /// Encapsulates <see cref="Generated.OpenApi.AgentApi.Api.UtilApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class UtilApi
    {
        private readonly Generated.OpenApi.AgentApi.UtilClient _utilClient;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public UtilApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _utilClient = new Generated.OpenApi.AgentApi.UtilClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Will return a message with the same content as the one sent.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public string Echo(string msg)
        {
            var message = _apiExecutor.Execute(_utilClient.V1EchoAsync, _authTokens.SessionToken, _authTokens.KeyManagerToken, new SimpleMessage() {Message = msg });
            return message.Message;
        }

        /// <summary>
        /// Example of what an obsolete endpoint is like (returns the input).
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public string Obsolete(string msg)
        {
            var message = _apiExecutor.Execute(_utilClient.V1ObsoleteAsync, _authTokens.SessionToken, _authTokens.KeyManagerToken, new SimpleMessage() { Message = msg });
            return message.Message;
        }
    }
}
