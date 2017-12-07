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
    using System;
    using System.Collections.Generic;
    using Authentication;
    using Entities;
    using Factories;
    using Generated.OpenApi.PodApi;
    using Logging;
    using Microsoft.Extensions.Logging;
    using System.Net.Http;

    /// <summary>
    /// Provides a method to get user information, by encapsulating
    /// <see cref="Generated.OpenApi.PodApi.Api.UsersApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class ConnectionApi
    {
        private readonly ILogger _log;

        private readonly Generated.OpenApi.PodApi.ConnectionClient _connectionApi;

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
        public ConnectionApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _log = ApiLogging.LoggerFactory?.CreateLogger<ConnectionApi>();

            _connectionApi = new Generated.OpenApi.PodApi.ConnectionClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Get the status of a connection invitation to another user.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <returns>The status of the connection.</returns>
        public Connection Get(long userId)
        {
            var userConnection = _apiExecutor.Execute(_connectionApi.V1UserInfoAsync, _authTokens.SessionToken, userId.ToString());
            return ConnectionFactory.Create(userConnection);
        }

        /// <summary>
        /// Retrieves all connections of the requesting user, optionally filtered by status and/or user IDs.
        /// User IDs must be provided to retrieve implicit connections (users on the same pod).
        /// </summary>
        /// <param name="status">Optional. Filter the connection list based on the connection status.</param>
        /// <param name="userIds">Optional. Filter connection list by user IDs. Implicit connections (users on the same pod) will not be included unless user IDs are provided.</param>
        /// <returns>The list of connections.</returns>
        public List<Connection> List(Status? status = null, List<long> userIds = null)
        {
            var userIdsString = userIds != null && userIds.Count > 0 ? string.Join(",", userIds) : null;
            var result = new List<Connection>();
            try
            {
                var userConnectionList = _apiExecutor.Execute(_connectionApi.V1ListAsync, _authTokens.SessionToken, status, userIdsString);
                if (userConnectionList != null)
                {
                    foreach (var userConnection in userConnectionList)
                    {
                        result.Add(ConnectionFactory.Create(userConnection));
                    }
                }
                return result;
            }
            catch (Exception)
            {
                _log?.LogError("An error has occured while trying to retrieve all connections from the requesting user");
                return result;
            }
        }

        /// <summary>
        /// Sends an invitation to connect with another user.
        /// </summary>
        /// <param name="userId">ID of user to connect to.</param>
        /// <returns>The connection request.</returns>
        public Connection Create(long userId)
        {
            var connectionRequest = new UserConnectionRequest() {UserId = userId};
            var userConnection = _apiExecutor.Execute(_connectionApi.V1CreateAsync, _authTokens.SessionToken, connectionRequest);
            return ConnectionFactory.Create(userConnection);
        }

        /// <summary>
        /// Accept the connection request for the requesting user.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>The accepted connection request.</returns>
        public Connection Accept(long userId)
        {
            var connectionRequest = new UserConnectionRequest() { UserId = userId };
            var userConnection = _apiExecutor.Execute(_connectionApi.V1AcceptAsync, _authTokens.SessionToken, connectionRequest);
            return ConnectionFactory.Create(userConnection);
        }

        /// <summary>
        /// Reject the connection request for the requesting user.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>The rejected connection request.</returns>
        public Connection Reject(long userId)
        {
            var connectionRequest = new UserConnectionRequest() { UserId = userId };
            var userConnection = _apiExecutor.Execute(_connectionApi.V1RejectAsync, _authTokens.SessionToken, connectionRequest, default(System.Threading.CancellationToken));
            return ConnectionFactory.Create(userConnection);
        }
    }
}
