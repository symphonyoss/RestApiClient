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
using Microsoft.Extensions.Logging;
using SymphonyOSS.RestApiClient.Logging;

namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using Authentication;
    using Factories;
    using Generated.OpenApi.PodApi;
    using System.Net.Http;
    using User = Entities.User;

    /// <summary>
    /// Provides a method to get user information, by encapsulating
    /// <see cref="UsersApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class UsersApi
    {
        private readonly Generated.OpenApi.PodApi.AdminClient _usersApi;
        private readonly Generated.OpenApi.PodApi.UserClient _userApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        private readonly ILogger _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public UsersApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _usersApi = new AdminClient(baseUrl, httpClient);
            _userApi = new UserClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
            _log = ApiLogging.LoggerFactory?.CreateLogger<UsersApi>();

        }

        /// <summary>
        /// Get user ID by email address (requires user provisioning permission).
        /// </summary>
        /// <param name="email">Email address of user.</param>
        /// <param name="local">If true then a local DB search will be performed and only local
        /// pod users will be returned. If absent or false then a directory search will be
        /// performed and users from other pods who are visible to the calling user will
        /// also be returned. Optional.</param>
        /// <returns>The user ID, or -1 if the user is not found.</returns>
        public long GetUserId(string email, bool? local = null)
        {
            try
            {
                var user = _apiExecutor.Execute(_userApi.V1Async, email, _authTokens.SessionToken, local);
                return user?.Id ?? -1;
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to get a user ID by the email address {email}.", email);
                throw;
            }
        }

        /// <summary>
        /// Get user information by user ID.
        /// </summary>
        /// <param name="userId">ID of user.</param>
        /// <param name="local">If true then a local DB search will be performed and only local
        /// pod users will be returned. If absent or false then a directory search will be
        /// performed and users from other pods who are visible to the calling user will
        /// also be returned. Optional.</param>
        /// <returns>The user information.</returns>
        public User GetUser(long userId, bool? local = null)
        {
            try
            {
                var userV2 = _apiExecutor.Execute(_userApi.V2Async, _authTokens.SessionToken, (long?)userId, (string)null, (string)null, local);
                return userV2 != null ? UserFactory.Create(userV2) : null;
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to get a user ID by the user ID {userId}.", userId);
                throw;
            }
        }
    }
}
