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
    using Authentication;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;

    /// <summary>
    /// Provides methods for testing endpoint, or use an example of an obsolete endpoint.
    /// Encapsulates <see cref="Generated.OpenApi.AgentApi.Api.UtilApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class UtilApi
    {
        private readonly Generated.OpenApi.AgentApi.Api.IUtilApi _datafeedApi;

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
        public UtilApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _datafeedApi = new Generated.OpenApi.AgentApi.Api.UtilApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Will return a message with the same content as the one sent.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public SimpleMessage Echo(string msg)
        {
            return _apiExecutor.Execute(_datafeedApi.V1UtilEchoPost, _authTokens.SessionToken, _authTokens.KeyManagerToken, new SimpleMessage(msg));
        }

        /// <summary>
        /// Example of what an obsolete endpoint is like (returns the input).
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public SimpleMessage Obsolete(string msg)
        {
            return _apiExecutor.Execute(_datafeedApi.V1UtilObsoletePost, _authTokens.SessionToken, _authTokens.KeyManagerToken, new SimpleMessage(msg));
        }
    }
}
