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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model
{
    /// <summary>
    /// RoomSystemInfo
    /// </summary>
    [DataContract]
    public partial class RoomSystemInfo :  IEquatable<RoomSystemInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomSystemInfo" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="CreationDate">The datetime when the stream was originally created. Milliseconds since Jan 1 1970..</param>
        /// <param name="CreatedByUserId">CreatedByUserId.</param>
        /// <param name="Active">If false, no messages can be sent in this stream, and membership is locked..</param>
        public RoomSystemInfo(string Id = null, long? CreationDate = null, long? CreatedByUserId = null, bool? Active = null)
        {
            
            
                        this.Id = Id;
            
                        this.CreationDate = CreationDate;
            
                        this.CreatedByUserId = CreatedByUserId;
            
                        this.Active = Active;
            
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The datetime when the stream was originally created. Milliseconds since Jan 1 1970.
        /// </summary>
        /// <value>The datetime when the stream was originally created. Milliseconds since Jan 1 1970.</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public long? CreationDate { get; set; }
        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public long? CreatedByUserId { get; set; }
        /// <summary>
        /// If false, no messages can be sent in this stream, and membership is locked.
        /// </summary>
        /// <value>If false, no messages can be sent in this stream, and membership is locked.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomSystemInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(obj as RoomSystemInfo);
        }

        /// <summary>
        /// Returns true if RoomSystemInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomSystemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomSystemInfo other)
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
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.CreatedByUserId == other.CreatedByUserId ||
                    this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
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
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.CreatedByUserId != null)
                    hash = hash * 59 + this.CreatedByUserId.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                return hash;
            }
        }
    }

}
