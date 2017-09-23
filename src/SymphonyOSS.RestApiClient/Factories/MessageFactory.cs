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
    using Message = Entities.Message;
    using Generated.OpenApi.AgentApi;
    using System.Linq;

    public abstract class MessageFactory
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static Message Create(V2BaseMessage v2BaseMessage)
        {
            var v2Message = v2BaseMessage as V2Message;
            List<Attachment> attachments = new List<Attachment>();
            if (v2Message.Attachments != null)
            {
                foreach (var attachmentInfo in v2Message.Attachments)
                {
                    attachments.Add(new Attachment(attachmentInfo.Id, attachmentInfo.Name, attachmentInfo.Size));
                }
            }
            return new Message(
                v2Message.Id, Epoch.AddMilliseconds(long.Parse(v2Message.Timestamp)), "V2Message",
                v2Message.StreamId,
                v2Message.Message, v2Message.FromUserId, attachments);
        }

        public static Message Create(V4Message v4Message)
        {
            var attachments = v4Message.Attachments?.Select(x => new Attachment(x.Id, x.Name, x.Size)).ToList();

            return new Message(v4Message.MessageId, Epoch.AddMilliseconds(v4Message.Timestamp.Value), "type", v4Message.Stream.StreamId, v4Message.Message, v4Message.User.UserId.Value, attachments);
        }
    }
}
