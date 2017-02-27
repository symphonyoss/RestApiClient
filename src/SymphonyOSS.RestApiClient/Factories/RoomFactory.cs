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
    using Entities;
    using Generated.OpenApi.PodApi.Model;

    public abstract class RoomFactory
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static Room Create(V2RoomDetail v2RoomDetail)
        {
            var roomSystemInfo = v2RoomDetail.RoomSystemInfo;
            var roomAttributes = v2RoomDetail.RoomAttributes;
            var keywords = new List<Tuple<string, string>>();
            if (roomAttributes.Keywords != null)
            {
                foreach (var keyword in roomAttributes.Keywords)
                {
                    keywords.Add(new Tuple<string, string>(keyword.Key, keyword.Value));
                }
            }
            return new Room(
                roomSystemInfo.Id,
                Epoch.AddMilliseconds(roomSystemInfo.CreationDate.Value),
                roomSystemInfo.CreatedByUserId.Value,
                roomSystemInfo.Active.Value,
                roomAttributes.Name,
                keywords,
                roomAttributes.Description,
                roomAttributes.MembersCanInvite.Value,
                roomAttributes.Discoverable.Value,
                roomAttributes._Public.Value,
                roomAttributes._ReadOnly.Value,
                roomAttributes.CopyProtected.Value);
        }
    }
}
