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
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// BaseMessage
    /// </summary>
    [DataContract]
    public partial class BaseMessage :  IEquatable<BaseMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BaseMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessage" /> class.
        /// </summary>
        /// <param name="Id">The messageId is assigned by the ingestor service when a message is sent..</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="MessageType">MessageType (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        public BaseMessage(string Id = null, string Timestamp = null, string MessageType = null, string StreamId = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for BaseMessage and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "MessageType" is required (not null)
            if (MessageType == null)
            {
                throw new InvalidDataException("MessageType is a required property for BaseMessage and cannot be null");
            }
            else
            {
                this.MessageType = MessageType;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for BaseMessage and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            
            
                        this.Id = Id;
            
        }
        
        /// <summary>
        /// The messageId is assigned by the ingestor service when a message is sent.
        /// </summary>
        /// <value>The messageId is assigned by the ingestor service when a message is sent.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public string MessageType { get; set; }
        /// <summary>
        /// Gets or Sets StreamId
        /// </summary>
        [DataMember(Name="streamId", EmitDefaultValue=false)]
        public string StreamId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
sb.Append("  MessageType: ").Append(MessageType).Append("\n");
sb.Append("  StreamId: ").Append(StreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BaseMessage);
        }

        /// <summary>
        /// Returns true if BaseMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) && 
                (
                    this.StreamId == other.StreamId ||
                    this.StreamId != null &&
                    this.StreamId.Equals(other.StreamId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();
                if (this.StreamId != null)
                    hash = hash * 59 + this.StreamId.GetHashCode();
                return hash;
            }
        }
    }

}
