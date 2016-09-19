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
    /// Detailed User record.
    /// </summary>
    [DataContract]
    public partial class UserDetail :  IEquatable<UserDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetail" /> class.
        /// </summary>
        /// <param name="UserAttributes">UserAttributes.</param>
        /// <param name="UserSystemInfo">UserSystemInfo.</param>
        /// <param name="Features">Features.</param>
        /// <param name="Apps">Apps.</param>
        /// <param name="Groups">Groups.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="Disclaimers">Disclaimers.</param>
        /// <param name="Avatar">Avatar.</param>
        public UserDetail(UserAttributes UserAttributes = null, UserSystemInfo UserSystemInfo = null, IntegerList Features = null, IntegerList Apps = null, IntegerList Groups = null, StringList Roles = null, IntegerList Disclaimers = null, Avatar Avatar = null)
        {
            this.UserAttributes = UserAttributes;
            this.UserSystemInfo = UserSystemInfo;
            this.Features = Features;
            this.Apps = Apps;
            this.Groups = Groups;
            this.Roles = Roles;
            this.Disclaimers = Disclaimers;
            this.Avatar = Avatar;
        }
        
        /// <summary>
        /// Gets or Sets UserAttributes
        /// </summary>
        [DataMember(Name="userAttributes", EmitDefaultValue=false)]
        public UserAttributes UserAttributes { get; set; }
        /// <summary>
        /// Gets or Sets UserSystemInfo
        /// </summary>
        [DataMember(Name="userSystemInfo", EmitDefaultValue=false)]
        public UserSystemInfo UserSystemInfo { get; set; }
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public IntegerList Features { get; set; }
        /// <summary>
        /// Gets or Sets Apps
        /// </summary>
        [DataMember(Name="apps", EmitDefaultValue=false)]
        public IntegerList Apps { get; set; }
        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public IntegerList Groups { get; set; }
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public StringList Roles { get; set; }
        /// <summary>
        /// Gets or Sets Disclaimers
        /// </summary>
        [DataMember(Name="disclaimers", EmitDefaultValue=false)]
        public IntegerList Disclaimers { get; set; }
        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public Avatar Avatar { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDetail {\n");
            sb.Append("  UserAttributes: ").Append(UserAttributes).Append("\n");
            sb.Append("  UserSystemInfo: ").Append(UserSystemInfo).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Apps: ").Append(Apps).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Disclaimers: ").Append(Disclaimers).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
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
            return this.Equals(obj as UserDetail);
        }

        /// <summary>
        /// Returns true if UserDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of UserDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserAttributes == other.UserAttributes ||
                    this.UserAttributes != null &&
                    this.UserAttributes.Equals(other.UserAttributes)
                ) && 
                (
                    this.UserSystemInfo == other.UserSystemInfo ||
                    this.UserSystemInfo != null &&
                    this.UserSystemInfo.Equals(other.UserSystemInfo)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.Equals(other.Features)
                ) && 
                (
                    this.Apps == other.Apps ||
                    this.Apps != null &&
                    this.Apps.Equals(other.Apps)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.Equals(other.Groups)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.Equals(other.Roles)
                ) && 
                (
                    this.Disclaimers == other.Disclaimers ||
                    this.Disclaimers != null &&
                    this.Disclaimers.Equals(other.Disclaimers)
                ) && 
                (
                    this.Avatar == other.Avatar ||
                    this.Avatar != null &&
                    this.Avatar.Equals(other.Avatar)
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
                if (this.UserAttributes != null)
                    hash = hash * 59 + this.UserAttributes.GetHashCode();
                if (this.UserSystemInfo != null)
                    hash = hash * 59 + this.UserSystemInfo.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                if (this.Apps != null)
                    hash = hash * 59 + this.Apps.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.Disclaimers != null)
                    hash = hash * 59 + this.Disclaimers.GetHashCode();
                if (this.Avatar != null)
                    hash = hash * 59 + this.Avatar.GetHashCode();
                return hash;
            }
        }
    }

}
