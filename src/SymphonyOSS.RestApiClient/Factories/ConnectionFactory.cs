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

namespace SymphonyOSS.RestApiClient.Factories
{
    using System;
    using Entities;
    using Generated.OpenApi.PodApi;

    public abstract class ConnectionFactory
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static Connection Create(UserConnection userConnection)
        {
            return new Connection(
                userConnection.UserId.Value,
                GetStatus(userConnection.Status.Value),
                userConnection.FirstRequestedAt != null ? Epoch.AddMilliseconds(userConnection.FirstRequestedAt.Value) : DateTime.MinValue,
                userConnection.UpdatedAt != null ? Epoch.AddMilliseconds(userConnection.UpdatedAt.Value) : DateTime.MinValue,
                userConnection.RequestCounter?? 0);
        }

        private static ConnectionStatus GetStatus(UserConnectionStatus status)
        {
            switch (status)
            {
                case UserConnectionStatus.ACCEPTED:
                    return ConnectionStatus.Accepted;
                case UserConnectionStatus.PENDING_INCOMING:
                    return ConnectionStatus.PendingIncoming;
                case UserConnectionStatus.PENDING_OUTGOING:
                    return ConnectionStatus.PendingOutgoing;
                case UserConnectionStatus.REJECTED:
                    return ConnectionStatus.Rejected;
                default:
                    throw new Exception($"Invalid status {status}.");
            }
        }
    }
}
