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
    /// An object respresenting the result count of faceted search.
    /// </summary>
    [DataContract]
    public partial class FacetedMatchCount :  IEquatable<FacetedMatchCount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetedMatchCount" /> class.
        /// </summary>
        /// <param name="Facet">The matched query..</param>
        /// <param name="Count">The result count..</param>
        public FacetedMatchCount(string Facet = null, int? Count = null)
        {
            
            
                        this.Facet = Facet;
            
                        this.Count = Count;
            
        }
        
        /// <summary>
        /// The matched query.
        /// </summary>
        /// <value>The matched query.</value>
        [DataMember(Name="facet", EmitDefaultValue=false)]
        public string Facet { get; set; }
        /// <summary>
        /// The result count.
        /// </summary>
        /// <value>The result count.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetedMatchCount {\n");
            sb.Append("  Facet: ").Append(Facet).Append("\n");
sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as FacetedMatchCount);
        }

        /// <summary>
        /// Returns true if FacetedMatchCount instances are equal
        /// </summary>
        /// <param name="other">Instance of FacetedMatchCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetedMatchCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Facet == other.Facet ||
                    this.Facet != null &&
                    this.Facet.Equals(other.Facet)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.Facet != null)
                    hash = hash * 59 + this.Facet.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                return hash;
            }
        }
    }

}
