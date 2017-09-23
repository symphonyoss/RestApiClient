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
    using System.Collections.Generic;
    using Generated.OpenApi.PodApi;
    using Stream = Entities.Stream;
    using StreamType = Entities.StreamType;

    public abstract class StreamFactory
    {
        public static Stream Create(StreamAttributes streamAttributes)
        {
            var streamType = GetType(streamAttributes.StreamType.Type.Value);
            var members = new List<long>();
            if (streamAttributes.StreamAttributes1 != null && streamAttributes.StreamAttributes1.Members != null)
            {
                foreach (var userId in streamAttributes.StreamAttributes1.Members)
                {
                    members.Add((long)userId);
                }
            }
            var roomName = streamAttributes.RoomAttributes?.Name;
            return new Stream(
                streamAttributes.Id,
                streamAttributes.CrossPod.Value, streamAttributes.Active.Value,
                streamType, members, roomName);
        }

        private static StreamType GetType(Generated.OpenApi.PodApi.StreamTypeType streamType)
        {
            switch (streamType)
            {
                case Generated.OpenApi.PodApi.StreamTypeType.IM:
                    return StreamType.IM;
                case Generated.OpenApi.PodApi.StreamTypeType.MIM:
                    return StreamType.MIM;
                case Generated.OpenApi.PodApi.StreamTypeType.POST:
                    return StreamType.Post;
                case Generated.OpenApi.PodApi.StreamTypeType.ROOM:
                    return StreamType.Room;
                default:
                    throw new Exception($"Unknown stream type '{streamType}'.");
            }
        }
    }
}
