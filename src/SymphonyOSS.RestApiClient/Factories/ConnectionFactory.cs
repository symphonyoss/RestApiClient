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
    using Generated.OpenApi.PodApi.Model;

    public abstract class ConnectionFactory
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static Connection Create(UserConnection userConnection)
        {
            return new Connection(
                userConnection.UserId.Value,
                GetStatus(userConnection.Status.Value),
                Epoch.AddMilliseconds(userConnection.FirstRequestedAt.Value),
                Epoch.AddMilliseconds(userConnection.UpdatedAt.Value),
                userConnection.RequestCounter.Value);
        }

        private static ConnectionStatus GetStatus(UserConnection.StatusEnum status)
        {
            switch (status)
            {
                case UserConnection.StatusEnum.Accepted:
                    return ConnectionStatus.Accepted;
                case UserConnection.StatusEnum.Pendingincoming:
                    return ConnectionStatus.PendingIncoming;
                case UserConnection.StatusEnum.Pendingoutgoing:
                    return ConnectionStatus.PendingOutgoing;
                case UserConnection.StatusEnum.Rejected:
                    return ConnectionStatus.Rejected;
                default:
                    throw new Exception($"Invalid status {status}.");
            }
        }
    }
}
