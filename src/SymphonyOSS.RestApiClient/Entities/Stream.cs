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

using SymphonyOSS.RestApiClient.Api;

namespace SymphonyOSS.RestApiClient.Entities
{
    using System;
    using System.Collections.Generic;

    public enum StreamType
    {
        IM,
        MIM,
        Room,
        Post
    }

    public class Stream
    {
        /// <summary>
        /// The stream ID.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// True if cross-pod, false if not.
        /// </summary>
        public bool CrossPod { get; }

        /// <summary>
        /// True if active, false if not.
        /// </summary>
        public bool Active { get; }

        /// <summary>
        /// The type of stream.
        /// </summary>
        public StreamType Type { get; }

        /// <summary>
        /// User IDs of the members of the stream. An empty list if the
        /// stream is a room.
        /// </summary>
        public List<long> Members { get; }

        /// <summary>
        /// The name of the room, or null if the stream is not a room.
        /// </summary>
        public string RoomName { get; }

        public Stream(string id, bool crossPod, bool active, StreamType type, List<long> members, string roomName)
        {
            if (id == null)
            {
                throw new ApiException("Missing required parameter 'id'.", null, 0);
            }
            Id = id;
            CrossPod = crossPod;
            Active = active;
            Type = type;
            Members = new List<long>();
            if (members != null)
            {
                Members.AddRange(members);
            }
            RoomName = roomName;
        }
    }
}
