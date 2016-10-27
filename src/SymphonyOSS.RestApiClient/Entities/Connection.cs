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

namespace SymphonyOSS.RestApiClient.Entities
{
    using System;

    public enum ConnectionStatus
    {
        PendingIncoming,
        PendingOutgoing,
        Accepted,
        Rejected
    }

    public class Connection
    {
        public long UserId { get; }

        /// <summary>
        /// Connection status between the requesting user and the request sender.
        /// </summary>
        public ConnectionStatus Status { get; }

        /// <summary>
        /// Timestamp when the first request was made.
        /// </summary>
        public DateTime FirstRequestedAt { get; }

        /// <summary>
        /// Timestamp on the last updated date.
        /// </summary>
        public DateTime UpdatedAt { get; }

        /// <summary>
        /// Number of requests made.
        /// </summary>
        public int RequestCounter { get; }

        public Connection(long userId, ConnectionStatus status, DateTime firstRequestedAt, DateTime updatedAt, int requestCounter)
        {
            UserId = userId;
            Status = status;
            FirstRequestedAt = firstRequestedAt;
            UpdatedAt = updatedAt;
            RequestCounter = requestCounter;
        }
    }
}
