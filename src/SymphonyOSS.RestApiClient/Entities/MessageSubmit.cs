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

using System.Collections.Generic;

namespace SymphonyOSS.RestApiClient.Entities
{
    public class MessageSubmit
    {
        public string StreamId { get; }

        public string Body { get; }

        public string Data { get; set; }

        public IDictionary<string, byte[]> Attachments { get; private set; }

        /// <summary>
        /// Constructs a message to be sent (outgoing).
        /// </summary>
        /// <param name="streamId">Stream ID.</param>
        /// <param name="body">Contents of the message.</param>
        public MessageSubmit(string streamId, string body)
        {
            StreamId = streamId;
            Body = body;
        }

        /// <summary>
        /// Add an attachment to the message. Currently only ONE attachment is supported
        /// due to limitations in Swagger where an array of file attachments cannot
        /// be specified
        /// </summary>
        /// <param name="filename">Name of the attachment</param>
        /// <param name="body">Contents of the file</param>

        public void AddAttachment(string filename, byte[] body)
        {
            if (Attachments == null)
            {
                Attachments = new Dictionary<string, byte[]>();
            }

            if (Attachments.Count != 0)
            {
                throw new System.InvalidOperationException("Cannot add more than one attachment");
            }
            Attachments.Add(filename, body);
        }

    }
}
