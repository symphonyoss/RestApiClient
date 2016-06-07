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

namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using Authentication;
    using Generated.OpenApi.PodApi.Client;
    using Generated.OpenApi.PodApi.Model;

    /// <summary>
    /// Provides methods for getting the available Symphony features on the pod.
    /// Encapsulates <see cref="Generated.OpenApi.PodApi.Api.StreamsApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class SystemApi
    {
        private readonly Generated.OpenApi.PodApi.Api.SystemApi _systemApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi" /> class.
        /// Provides methods for discovering functions available through the API endpoints.
        /// Encapsulates <see cref="Generated.OpenApi.PodApi.Api.SystemApi"/>,
        /// adding authentication token management and a custom execution strategy.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public SystemApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _systemApi = new Generated.OpenApi.PodApi.Api.SystemApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Get the full set of Symphony features available for this pod.
        /// </summary>
        /// <returns>The list of features.</returns>
        public StringList GetFeatures()
        {
            return _apiExecutor.Execute(_systemApi.V1AdminSystemFeaturesListGet, _authTokens.SessionToken);
        }
    }
}
