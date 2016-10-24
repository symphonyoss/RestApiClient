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
    using System.Collections.Generic;

    public class Room
    {
        public string Id { get; }

        public DateTime CreationDate { get; }

        public long CreatedByUserId { get; }

        public bool Active { get; }

        public string Name { get; }

        public List<Tuple<string, string>> Keywords { get; }

        public string Description { get; }

        public bool MembersCanInvite { get; }

        public bool Discoverable { get; }

        public bool Public { get; }

        public bool ReadOnly { get; }

        public bool CopyProtected { get; }

        public Room(
            string id, DateTime creationDate, long createdByUserId, bool active,
            string name, List<Tuple<string, string>> keywords, string description,
            bool membersCanInvite, bool discoverable, bool isPublic, bool isReadonly,
            bool copyProtected)
        {
            Id = id;
            CreationDate = creationDate;
            CreatedByUserId = createdByUserId;
            Active = active;
            Name = name;
            Keywords = new List<Tuple<string, string>>();
            if (keywords != null)
            {
                Keywords.AddRange(keywords);
            }
            Description = description;
            MembersCanInvite = membersCanInvite;
            Discoverable = discoverable;
            Public = isPublic;
            ReadOnly = isReadonly;
            CopyProtected = copyProtected;
        }
    }
}
