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
    /// Avatar
    /// </summary>
    [DataContract]
    public partial class Avatar :  IEquatable<Avatar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Avatar" /> class.
        /// </summary>
        /// <param name="Size">The Avatar Size.</param>
        /// <param name="Url">Url of the image.</param>
        public Avatar(string Size = null, string Url = null)
        {
            
            
                        this.Size = Size;
            
                        this.Url = Url;
            
        }
        
        /// <summary>
        /// The Avatar Size
        /// </summary>
        /// <value>The Avatar Size</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }
        /// <summary>
        /// Url of the image
        /// </summary>
        /// <value>Url of the image</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Avatar {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as Avatar);
        }

        /// <summary>
        /// Returns true if Avatar instances are equal
        /// </summary>
        /// <param name="other">Instance of Avatar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Avatar other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                return hash;
            }
        }
    }

}
