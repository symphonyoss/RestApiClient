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
    /// RoomAttributes
    /// </summary>
    [DataContract]
    public partial class RoomAttributes :  IEquatable<RoomAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomAttributes" /> class.
        /// </summary>
        /// <param name="Name">Room name..</param>
        /// <param name="Description">Room description..</param>
        /// <param name="MembersCanInvite">If true, any chatroom participant can add new participants. If false, only owners can add new participants..</param>
        /// <param name="Discoverable">If true, this chatroom (name, description and messages) can be searched and listed by non-participants. If false, only participants can search this room..</param>
        public RoomAttributes(string Name = null, string Description = null, bool? MembersCanInvite = null, bool? Discoverable = null)
        {
            
            
                        this.Name = Name;
            
                        this.Description = Description;
            
                        this.MembersCanInvite = MembersCanInvite;
            
                        this.Discoverable = Discoverable;
            
        }
        
        /// <summary>
        /// Room name.
        /// </summary>
        /// <value>Room name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Room description.
        /// </summary>
        /// <value>Room description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// If true, any chatroom participant can add new participants. If false, only owners can add new participants.
        /// </summary>
        /// <value>If true, any chatroom participant can add new participants. If false, only owners can add new participants.</value>
        [DataMember(Name="membersCanInvite", EmitDefaultValue=false)]
        public bool? MembersCanInvite { get; set; }
        /// <summary>
        /// If true, this chatroom (name, description and messages) can be searched and listed by non-participants. If false, only participants can search this room.
        /// </summary>
        /// <value>If true, this chatroom (name, description and messages) can be searched and listed by non-participants. If false, only participants can search this room.</value>
        [DataMember(Name="discoverable", EmitDefaultValue=false)]
        public bool? Discoverable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  MembersCanInvite: ").Append(MembersCanInvite).Append("\n");
sb.Append("  Discoverable: ").Append(Discoverable).Append("\n");
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
            return this.Equals(obj as RoomAttributes);
        }

        /// <summary>
        /// Returns true if RoomAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.MembersCanInvite == other.MembersCanInvite ||
                    this.MembersCanInvite != null &&
                    this.MembersCanInvite.Equals(other.MembersCanInvite)
                ) && 
                (
                    this.Discoverable == other.Discoverable ||
                    this.Discoverable != null &&
                    this.Discoverable.Equals(other.Discoverable)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.MembersCanInvite != null)
                    hash = hash * 59 + this.MembersCanInvite.GetHashCode();
                if (this.Discoverable != null)
                    hash = hash * 59 + this.Discoverable.GetHashCode();
                return hash;
            }
        }
    }

}
