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
    /// Generated when a room member is promoted to owner.
    /// </summary>
    [DataContract]
    public partial class RoomMemberPromotedToOwnerMessage : V2BaseMessage,  IEquatable<RoomMemberPromotedToOwnerMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMemberPromotedToOwnerMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomMemberPromotedToOwnerMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMemberPromotedToOwnerMessage" /> class.
        /// </summary>
        /// <param name="Id">The messageId is assigned by the ingestor service when a message is sent..</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="V2messageType">V2messageType (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        /// <param name="PromotedByUserId">PromotedByUserId.</param>
        /// <param name="PromotedUserId">PromotedUserId.</param>
        public RoomMemberPromotedToOwnerMessage(string Id = null, string Timestamp = null, string V2messageType = null, string StreamId = null, long? PromotedByUserId = null, long? PromotedUserId = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for RoomMemberPromotedToOwnerMessage and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "V2messageType" is required (not null)
            if (V2messageType == null)
            {
                throw new InvalidDataException("V2messageType is a required property for RoomMemberPromotedToOwnerMessage and cannot be null");
            }
            else
            {
                this.V2messageType = V2messageType;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for RoomMemberPromotedToOwnerMessage and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            
            
                        this.Id = Id;
            
                        this.PromotedByUserId = PromotedByUserId;
            
                        this.PromotedUserId = PromotedUserId;
            
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
        /// Gets or Sets V2messageType
        /// </summary>
        [DataMember(Name="v2messageType", EmitDefaultValue=false)]
        public string V2messageType { get; set; }
        /// <summary>
        /// Gets or Sets StreamId
        /// </summary>
        [DataMember(Name="streamId", EmitDefaultValue=false)]
        public string StreamId { get; set; }
        /// <summary>
        /// Gets or Sets PromotedByUserId
        /// </summary>
        [DataMember(Name="promotedByUserId", EmitDefaultValue=false)]
        public long? PromotedByUserId { get; set; }
        /// <summary>
        /// Gets or Sets PromotedUserId
        /// </summary>
        [DataMember(Name="promotedUserId", EmitDefaultValue=false)]
        public long? PromotedUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomMemberPromotedToOwnerMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
sb.Append("  V2messageType: ").Append(V2messageType).Append("\n");
sb.Append("  StreamId: ").Append(StreamId).Append("\n");
sb.Append("  PromotedByUserId: ").Append(PromotedByUserId).Append("\n");
sb.Append("  PromotedUserId: ").Append(PromotedUserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as RoomMemberPromotedToOwnerMessage);
        }

        /// <summary>
        /// Returns true if RoomMemberPromotedToOwnerMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomMemberPromotedToOwnerMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomMemberPromotedToOwnerMessage other)
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
                    this.V2messageType == other.V2messageType ||
                    this.V2messageType != null &&
                    this.V2messageType.Equals(other.V2messageType)
                ) && 
                (
                    this.StreamId == other.StreamId ||
                    this.StreamId != null &&
                    this.StreamId.Equals(other.StreamId)
                ) && 
                (
                    this.PromotedByUserId == other.PromotedByUserId ||
                    this.PromotedByUserId != null &&
                    this.PromotedByUserId.Equals(other.PromotedByUserId)
                ) && 
                (
                    this.PromotedUserId == other.PromotedUserId ||
                    this.PromotedUserId != null &&
                    this.PromotedUserId.Equals(other.PromotedUserId)
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
                if (this.V2messageType != null)
                    hash = hash * 59 + this.V2messageType.GetHashCode();
                if (this.StreamId != null)
                    hash = hash * 59 + this.StreamId.GetHashCode();
                if (this.PromotedByUserId != null)
                    hash = hash * 59 + this.PromotedByUserId.GetHashCode();
                if (this.PromotedUserId != null)
                    hash = hash * 59 + this.PromotedUserId.GetHashCode();
                return hash;
            }
        }
    }

}
