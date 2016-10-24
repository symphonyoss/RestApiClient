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

    public enum Format
    {
        Text,
        MessageML
    }

    public class Message
    {
        public string Id { get; }

        public DateTime Timestamp { get; }

        public string Type { get; }

        public string StreamId { get; }

        public Format Format { get; } 

        public string Body { get; }

        public long FromUserId { get; }

        public List<Attachment> Attachments { get; }

        public Message(string streamId, Format format, string body, List<Attachment> attachments = null)
        {
            StreamId = streamId;
            Format = format;
            Body = body;
            Attachments = new List<Attachment>();
            if (attachments != null)
            {
                foreach (var attachment in attachments)
                {
                    Attachments.Add(attachment);
                }
            }
        }

        public Message(
            string id, DateTime timestamp, string type,
            string streamId, Format format, string body, long fromUserId,
            List<Attachment> attachments = null)
        {
            Id = id;
            Timestamp = timestamp;
            Type = type;
            StreamId = streamId;
            Format = format;
            Body = body;
            FromUserId = fromUserId;
            Attachments = new List<Attachment>();
            if (attachments != null)
            {
                foreach (var attachment in attachments)
                {
                    Attachments.Add(attachment);
                }
            }
        }
    }
}
