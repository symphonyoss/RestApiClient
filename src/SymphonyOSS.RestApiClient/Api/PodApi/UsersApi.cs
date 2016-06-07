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
    /// Provides a method to get user information, by encapsulating
    /// <see cref="Generated.OpenApi.PodApi.Api.UsersApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class UsersApi
    {
        private readonly Generated.OpenApi.PodApi.Api.UsersApi _usersApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public UsersApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _usersApi = new Generated.OpenApi.PodApi.Api.UsersApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Get user information by email address.
        /// </summary>
        /// <param name="email">Email address of user.</param>
        /// <param name="local">If true then a local DB search will be performed and only local
        /// pod users will be returned. If absent or false then a directory search will be
        /// performed and users from other pods who are visible to the calling user will
        /// also be returned. Optional.</param>
        /// <returns>The user information.</returns>
        public User GetUser(string email, bool? local = null)
        {
            return _apiExecutor.Execute(_usersApi.V1UserGet, email, _authTokens.SessionToken, local);
        }
    }
}
