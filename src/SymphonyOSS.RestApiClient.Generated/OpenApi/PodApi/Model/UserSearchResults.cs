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
    /// UserSearchResults
    /// </summary>
    [DataContract]
    public partial class UserSearchResults :  IEquatable<UserSearchResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchResults" /> class.
        /// </summary>
        /// <param name="Count">The total number of users which matched the search criteria..</param>
        /// <param name="Skip">The number of skipped results..</param>
        /// <param name="Limit">The number of returned results..</param>
        /// <param name="SearchQuery">The search query that produced this result..</param>
        /// <param name="Users">A list of users which matched by the search criteria..</param>
        public UserSearchResults(long? Count = null, long? Skip = null, long? Limit = null, UserSearchQuery SearchQuery = null, List<UserV2> Users = null)
        {
            
            
                        this.Count = Count;
            
                        this.Skip = Skip;
            
                        this.Limit = Limit;
            
                        this.SearchQuery = SearchQuery;
            
                        this.Users = Users;
            
        }
        
        /// <summary>
        /// The total number of users which matched the search criteria.
        /// </summary>
        /// <value>The total number of users which matched the search criteria.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
        /// <summary>
        /// The number of skipped results.
        /// </summary>
        /// <value>The number of skipped results.</value>
        [DataMember(Name="skip", EmitDefaultValue=false)]
        public long? Skip { get; set; }
        /// <summary>
        /// The number of returned results.
        /// </summary>
        /// <value>The number of returned results.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }
        /// <summary>
        /// The search query that produced this result.
        /// </summary>
        /// <value>The search query that produced this result.</value>
        [DataMember(Name="searchQuery", EmitDefaultValue=false)]
        public UserSearchQuery SearchQuery { get; set; }
        /// <summary>
        /// A list of users which matched by the search criteria.
        /// </summary>
        /// <value>A list of users which matched by the search criteria.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserV2> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearchResults {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
sb.Append("  Skip: ").Append(Skip).Append("\n");
sb.Append("  Limit: ").Append(Limit).Append("\n");
sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as UserSearchResults);
        }

        /// <summary>
        /// Returns true if UserSearchResults instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSearchResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Skip == other.Skip ||
                    this.Skip != null &&
                    this.Skip.Equals(other.Skip)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.SearchQuery == other.SearchQuery ||
                    this.SearchQuery != null &&
                    this.SearchQuery.Equals(other.SearchQuery)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Skip != null)
                    hash = hash * 59 + this.Skip.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.SearchQuery != null)
                    hash = hash * 59 + this.SearchQuery.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }
    }

}
