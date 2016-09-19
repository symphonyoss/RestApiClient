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
    /// UserFilter
    /// </summary>
    [DataContract]
    public partial class UserFilter :  IEquatable<UserFilter>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ENABLED for "ENABLED"
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            ENABLED,
            
            /// <summary>
            /// Enum DISABLED for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED
        }

        /// <summary>
        /// Gets or Sets Usertype
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UsertypeEnum
        {
            
            /// <summary>
            /// Enum NORMAL for "NORMAL"
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            NORMAL,
            
            /// <summary>
            /// Enum SYSTEM for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            SYSTEM,
            
            /// <summary>
            /// Enum TW for "TW"
            /// </summary>
            [EnumMember(Value = "TW")]
            TW
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Usertype
        /// </summary>
        [DataMember(Name="usertype", EmitDefaultValue=false)]
        public UsertypeEnum? Usertype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFilter" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Department">Department.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Role">Role.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Usertype">Usertype.</param>
        /// <param name="Location">Location.</param>
        public UserFilter(string Email = null, string Name = null, string Department = null, string Title = null, string Role = null, StatusEnum? Status = null, UsertypeEnum? Usertype = null, string Location = null)
        {
            this.Email = Email;
            this.Name = Name;
            this.Department = Department;
            this.Title = Title;
            this.Role = Role;
            this.Status = Status;
            this.Usertype = Usertype;
            this.Location = Location;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserFilter {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Usertype: ").Append(Usertype).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as UserFilter);
        }

        /// <summary>
        /// Returns true if UserFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of UserFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Usertype == other.Usertype ||
                    this.Usertype != null &&
                    this.Usertype.Equals(other.Usertype)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Usertype != null)
                    hash = hash * 59 + this.Usertype.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                return hash;
            }
        }
    }

}
