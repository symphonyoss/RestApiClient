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
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AgentApi;
    using Authentication;
    using Entities;
    using Factories;
    using Generated.OpenApi.AgentApi.Model;
    using Generated.OpenApi.PodApi.Client;
    using Generated.OpenApi.PodApi.Model;

    /// <summary>
    /// Provides a method to get user information, by encapsulating
    /// <see cref="Generated.OpenApi.PodApi.Api.UsersApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class ConnectionApi
    {
        private static readonly TraceSource TraceSource = new TraceSource("SymphonyOSS.RestApiClient");

        private readonly Generated.OpenApi.PodApi.Api.IConnectionApi _connectionApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        private readonly Dictionary<EventHandler<ConnectionRequestEventArgs>, Task> _tasks =
            new Dictionary<EventHandler<ConnectionRequestEventArgs>, Task>();

        private Timer _connectionPollTimer;

        private event EventHandler<ConnectionRequestEventArgs> _onConnectionRequest;

        public event EventHandler<ConnectionRequestEventArgs> OnConnectionRequest
        {
            add
            {
                _onConnectionRequest += value;
            }
            remove
            {
                _onConnectionRequest -= value;
                lock (_tasks)
                {
                    _tasks.Remove(value);
                }
            }
        }

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
        /// Starts listening, notifying event handlers about incoming connection requests. Blocks
        /// until <see cref="ConnectionApi.Stop"/> is invoked.
        /// </summary>
        public void Listen(long timeout)
        {
            _connectionPollTimer = new Timer(
                cb =>
                {
                    try
                    {
                        var connectionList =
                            List().Where(connection => connection.Status != ConnectionStatus.Accepted);

                        ProcessConnectionList(connectionList);
                    }
                    catch (Exception ex)
                    {
                        TraceSource.TraceEvent(
                            TraceEventType.Error, 0,
                            "Unhandled exception caught when fecthing list of connection request {1}",
                            ex);
                    }
                }, null, 0, timeout);
        }

        /// <summary>
        /// Requests that <see cref="Listen"/> should stop.
        /// </summary>
        public void Stop()
        {
            _connectionPollTimer.Dispose();
            _connectionPollTimer = null;
        }

        protected void ProcessConnectionList(IEnumerable<Connection> connectionList)
        {
            if (connectionList == null || _onConnectionRequest == null)
            {
                return;
            }

            foreach (var eventHandler in _onConnectionRequest.GetInvocationList())
            {
                NotifyAsync((EventHandler<ConnectionRequestEventArgs>)eventHandler, connectionList);
            }
        }

        /// <summary>
        /// Get the status of a connection invitation to another user.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <returns>The status of the connection.</returns>
        public Connection Get(long userId)
        {
            var userConnection = _apiExecutor.Execute(_connectionApi.V1ConnectionUserUserIdInfoGet, _authTokens.SessionToken, userId.ToString());
            return ConnectionFactory.Create(userConnection);
        }

        /// <summary>
        /// Retrieves all connections of the requesting user, optionally filtered by status and/or user IDs.
        /// User IDs must be provided to retrieve implicit connections (users on the same pod).
        /// </summary>
        /// <param name="status">Optional. Filter the connection list based on the connection status.</param>
        /// <param name="userIds">Optional. Filter connection list by user IDs. Implicit connections (users on the same pod) will not be included unless user IDs are provided.</param>
        /// <returns>The list of connections.</returns>
        public List<Connection> List(UserConnection.StatusEnum? status = null, List<long> userIds = null)
        {
            var statusAsString = status != null ? GetStatusAsString((UserConnection.StatusEnum)status) : null;
            var userIdsString = userIds != null && userIds.Count > 0 ? string.Join(",", userIds) : null;
            var userConnectionList = _apiExecutor.Execute(_connectionApi.V1ConnectionListGet, _authTokens.SessionToken, statusAsString, userIdsString);
            var result = new List<Connection>();
            if (userConnectionList != null)
            {
                foreach (var userConnection in userConnectionList)
                {
                    result.Add(ConnectionFactory.Create(userConnection));
                }
            }
            return result;
        }

        /// <summary>
        /// Sends an invitation to connect with another user.
        /// </summary>
        /// <param name="userId">ID of user to connect to.</param>
        /// <returns>The connection request.</returns>
        public Connection Create(long userId)
        {
            var connectionRequest = new UserConnectionRequest(userId);
            var userConnection = _apiExecutor.Execute(_connectionApi.V1ConnectionCreatePost, _authTokens.SessionToken, connectionRequest);
            return ConnectionFactory.Create(userConnection);
        }

        /// <summary>
        /// Accept the connection request for the requesting user.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>The accepted connection request.</returns>
        public Connection Accept(long userId)
        {
            var connectionRequest = new UserConnectionRequest(userId);
            var userConnection = _apiExecutor.Execute(_connectionApi.V1ConnectionAcceptPost, _authTokens.SessionToken, connectionRequest);
            return ConnectionFactory.Create(userConnection);
        }

        /// <summary>
        /// Reject the connection request for the requesting user.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>The rejected connection request.</returns>
        public Connection Reject(long userId)
        {
            var connectionRequest = new UserConnectionRequest(userId);
            var userConnection = _apiExecutor.Execute(_connectionApi.V1ConnectionRejectPost, _authTokens.SessionToken, connectionRequest);
            return ConnectionFactory.Create(userConnection);
        }

        private string GetStatusAsString(UserConnection.StatusEnum status)
        {
            switch (status)
            {
                case UserConnection.StatusEnum.Pendingincoming:
                    return "pending_incoming";
                case UserConnection.StatusEnum.Pendingoutgoing:
                    return "pending_outgoing";
                default:
                    return status.ToString().ToLower();
            }
        }

        protected async void NotifyAsync(EventHandler<ConnectionRequestEventArgs> connectionEventHandler,
            IEnumerable<Connection> connectionList)
        {
            // Notify each handler in a separate task, maintaining the order of connections in the list, and
            // get back to reading the connectio list again without waiting for listeners to process connection requests.
            Task task;
            if (_tasks.TryGetValue(connectionEventHandler, out task))
            {
                await task;
            }
            _tasks[connectionEventHandler] = Task.Run(() => Notify(connectionEventHandler, connectionList));
        }

        private void Notify(EventHandler<ConnectionRequestEventArgs> connectionEventHandler,
            IEnumerable<Connection> connectionList)
        {
            foreach (var connection in connectionList)
            {
                TraceSource.TraceEvent(
                    TraceEventType.Verbose, 0,
                    "Notifying listener about connection request for user with ID \"{0}\" and status \"{1}\"",
                    connection?.UserId, connection?.Status);
                try
                {
                    connectionEventHandler.Invoke(this, new ConnectionRequestEventArgs(connection));
                }
                catch (Exception e)
                {
                    TraceSource.TraceEvent(
                        TraceEventType.Error, 0,
                        "Unhandled exception caught when notifying listener about connection request for user with ID \"{0}\": {1}",
                        connection?.UserId, e);
                }
            }
        }
    }
}
