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
    /// UserSearchQuery
    /// </summary>
    [DataContract]
    public partial class UserSearchQuery :  IEquatable<UserSearchQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchQuery" /> class.
        /// </summary>
        /// <param name="Query">search / query term.  This can be firstname, lastname, displayname or email.</param>
        /// <param name="Filters">query filters.</param>
        public UserSearchQuery(string Query = null, UserSearchFilter Filters = null)
        {
            
            
                        this.Query = Query;
            
                        this.Filters = Filters;
            
        }
        
        /// <summary>
        /// search / query term.  This can be firstname, lastname, displayname or email
        /// </summary>
        /// <value>search / query term.  This can be firstname, lastname, displayname or email</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
        /// <summary>
        /// query filters
        /// </summary>
        /// <value>query filters</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public UserSearchFilter Filters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearchQuery {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(obj as UserSearchQuery);
        }

        /// <summary>
        /// Returns true if UserSearchQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSearchQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.Equals(other.Filters)
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
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                return hash;
            }
        }
    }

}
