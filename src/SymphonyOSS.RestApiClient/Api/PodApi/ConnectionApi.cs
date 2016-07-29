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
    using Generated.OpenApi.PodApi.Client;
    using Generated.OpenApi.PodApi.Model;

    /// <summary>
    /// Provides a method to get user information, by encapsulating
    /// <see cref="Generated.OpenApi.PodApi.Api.UsersApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class ConnectionApi
    {
        private readonly Generated.OpenApi.PodApi.Api.IConnectionApi _connectionApi;

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
        public ConnectionApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _connectionApi = new Generated.OpenApi.PodApi.Api.ConnectionApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Get the status of a connection invitation to another user.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <returns>The status of the connection.</returns>
        public UserConnection Get(long userId)
        {
            return _apiExecutor.Execute(_connectionApi.V1ConnectionUserUserIdInfoGet, _authTokens.SessionToken, userId.ToString());
        }

        /// <summary>
        /// Retrieves all connections of the requesting user, optionally filtered by status and/or user IDs.
        /// User IDs must be provided to retrieve implicit connections (users on the same pod).
        /// </summary>
        /// <param name="status">Optional. Filter the connection list based on the connection status.</param>
        /// <param name="userIds">Optional. Filter connection list by user IDs. Implicit connections (users on the same pod) will not be included unless user IDs are provided.</param>
        /// <returns>The list of connections.</returns>
        public UserConnectionList List(UserConnection.StatusEnum? status = null, List<long> userIds = null)
        {
            var statusAsString = status != null ? GetStatusAsString((UserConnection.StatusEnum)status) : null;
            var userIdsString = userIds != null && userIds.Count > 0 ? string.Join(",", userIds) : null;
            return _apiExecutor.Execute(_connectionApi.V1ConnectionListGet, _authTokens.SessionToken, statusAsString, userIdsString);
        }

        /// <summary>
        /// Sends an invitation to connect with another user.
        /// </summary>
        /// <param name="userId">ID of user to connect to.</param>
        /// <returns>The connection request.</returns>
        public UserConnection Create(long userId)
        {
            var connectionRequest = new UserConnectionRequest(userId);
            return _apiExecutor.Execute(_connectionApi.V1ConnectionCreatePost, _authTokens.SessionToken, connectionRequest);
        }

        /// <summary>
        /// Accept the connection request for the requesting user.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>The accepted connection request.</returns>
        public UserConnection Accept(long userId)
        {
            var connectionRequest = new UserConnectionRequest(userId);
            return _apiExecutor.Execute(_connectionApi.V1ConnectionAcceptPost, _authTokens.SessionToken, connectionRequest);
        }

        /// <summary>
        /// Reject the connection request for the requesting user.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>The rejected connection request.</returns>
        public UserConnection Reject(long userId)
        {
            var connectionRequest = new UserConnectionRequest(userId);
            return _apiExecutor.Execute(_connectionApi.V1ConnectionRejectPost, _authTokens.SessionToken, connectionRequest);
        }

        private string GetStatusAsString(UserConnection.StatusEnum status)
        {
            switch (status)
            {
                case UserConnection.StatusEnum.PendingIncoming:
                    return "pending_incoming";
                case UserConnection.StatusEnum.PendingOutgoing:
                    return "pending_outgoing";
                default:
                    return status.ToString().ToLower();
            }
        }
    }
}
