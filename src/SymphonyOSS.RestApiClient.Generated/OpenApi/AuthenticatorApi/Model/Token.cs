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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Model
{
    /// <summary>
    /// Token
    /// </summary>
    [DataContract]
    public partial class Token :  IEquatable<Token>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="Name">The name of the header in which the token should be presented on subsequent API calls. .</param>
        /// <param name="_Token">The token which should be passed. This should be considered opaque data by the client. It is not intended to conatain any data interpretable by the client. The format is secret and subject to change without notice. .</param>
        public Token(string Name = null, string _Token = null)
        {
            this.Name = Name;
            this._Token = _Token;
        }
        
        /// <summary>
        /// The name of the header in which the token should be presented on subsequent API calls. 
        /// </summary>
        /// <value>The name of the header in which the token should be presented on subsequent API calls. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The token which should be passed. This should be considered opaque data by the client. It is not intended to conatain any data interpretable by the client. The format is secret and subject to change without notice. 
        /// </summary>
        /// <value>The token which should be passed. This should be considered opaque data by the client. It is not intended to conatain any data interpretable by the client. The format is secret and subject to change without notice. </value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string _Token { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Token {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Token: ").Append(_Token).Append("\n");
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
            return this.Equals(obj as Token);
        }

        /// <summary>
        /// Returns true if Token instances are equal
        /// </summary>
        /// <param name="other">Instance of Token to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Token other)
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
                    this._Token == other._Token ||
                    this._Token != null &&
                    this._Token.Equals(other._Token)
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
                if (this._Token != null)
                    hash = hash * 59 + this._Token.GetHashCode();
                return hash;
            }
        }
    }

}
