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
    /// ConfigurationInstanceSubmissionCreate
    /// </summary>
    [DataContract]
    public partial class ConfigurationInstanceSubmissionCreate :  IEquatable<ConfigurationInstanceSubmissionCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationInstanceSubmissionCreate" /> class.
        /// </summary>
        /// <param name="ConfigurationId">ConfigurationId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatorId">CreatorId.</param>
        /// <param name="OptionalProperties">This field should be used as a container for a serialized object, holding specialized field values..</param>
        public ConfigurationInstanceSubmissionCreate(string ConfigurationId = null, string Name = null, string Description = null, string CreatorId = null, string OptionalProperties = null)
        {
            
            
                        this.ConfigurationId = ConfigurationId;
            
                        this.Name = Name;
            
                        this.Description = Description;
            
                        this.CreatorId = CreatorId;
            
                        this.OptionalProperties = OptionalProperties;
            
        }
        
        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name="configurationId", EmitDefaultValue=false)]
        public string ConfigurationId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets CreatorId
        /// </summary>
        [DataMember(Name="creatorId", EmitDefaultValue=false)]
        public string CreatorId { get; set; }
        /// <summary>
        /// This field should be used as a container for a serialized object, holding specialized field values.
        /// </summary>
        /// <value>This field should be used as a container for a serialized object, holding specialized field values.</value>
        [DataMember(Name="optionalProperties", EmitDefaultValue=false)]
        public string OptionalProperties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationInstanceSubmissionCreate {\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
sb.Append("  OptionalProperties: ").Append(OptionalProperties).Append("\n");
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
            return this.Equals(obj as ConfigurationInstanceSubmissionCreate);
        }

        /// <summary>
        /// Returns true if ConfigurationInstanceSubmissionCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfigurationInstanceSubmissionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationInstanceSubmissionCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConfigurationId == other.ConfigurationId ||
                    this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(other.ConfigurationId)
                ) && 
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
                    this.CreatorId == other.CreatorId ||
                    this.CreatorId != null &&
                    this.CreatorId.Equals(other.CreatorId)
                ) && 
                (
                    this.OptionalProperties == other.OptionalProperties ||
                    this.OptionalProperties != null &&
                    this.OptionalProperties.Equals(other.OptionalProperties)
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
                if (this.ConfigurationId != null)
                    hash = hash * 59 + this.ConfigurationId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CreatorId != null)
                    hash = hash * 59 + this.CreatorId.GetHashCode();
                if (this.OptionalProperties != null)
                    hash = hash * 59 + this.OptionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
