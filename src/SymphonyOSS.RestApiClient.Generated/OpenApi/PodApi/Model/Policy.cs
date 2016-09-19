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
    /// Information Barrier Policy record.
    /// </summary>
    [DataContract]
    public partial class Policy :  IEquatable<Policy>
    {
        /// <summary>
        /// Gets or Sets PolicyType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PolicyTypeEnum
        {
            
            /// <summary>
            /// Enum BLOCK for "BLOCK"
            /// </summary>
            [EnumMember(Value = "BLOCK")]
            BLOCK,
            
            /// <summary>
            /// Enum ALLOW for "ALLOW"
            /// </summary>
            [EnumMember(Value = "ALLOW")]
            ALLOW
        }

        /// <summary>
        /// Gets or Sets PolicyType
        /// </summary>
        [DataMember(Name="policyType", EmitDefaultValue=false)]
        public PolicyTypeEnum? PolicyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Policy" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="PolicyType">PolicyType.</param>
        /// <param name="Active">Active.</param>
        /// <param name="MemberCount">MemberCount.</param>
        /// <param name="Groups">Groups.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        public Policy(string Id = null, PolicyTypeEnum? PolicyType = null, bool? Active = null, int? MemberCount = null, List<string> Groups = null, long? CreatedDate = null, long? ModifiedDate = null)
        {
            this.Id = Id;
            this.PolicyType = PolicyType;
            this.Active = Active;
            this.MemberCount = MemberCount;
            this.Groups = Groups;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }
        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public long? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public long? ModifiedDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Policy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PolicyType: ").Append(PolicyType).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as Policy);
        }

        /// <summary>
        /// Returns true if Policy instances are equal
        /// </summary>
        /// <param name="other">Instance of Policy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Policy other)
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
                    this.PolicyType == other.PolicyType ||
                    this.PolicyType != null &&
                    this.PolicyType.Equals(other.PolicyType)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                if (this.PolicyType != null)
                    hash = hash * 59 + this.PolicyType.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                return hash;
            }
        }
    }

}
