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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// MessageSubmission
    /// </summary>
    [DataContract]
    public partial class MessageSubmission :  IEquatable<MessageSubmission>
    {
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum Text for "TEXT"
            /// </summary>
            [EnumMember(Value = "TEXT")]
            Text,
            
            /// <summary>
            /// Enum Messageml for "MESSAGEML"
            /// </summary>
            [EnumMember(Value = "MESSAGEML")]
            Messageml
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSubmission" /> class.
        /// </summary>
        /// <param name="Format">Format.</param>
        /// <param name="Message">Message.</param>
        public MessageSubmission(FormatEnum? Format = null, string Message = null)
        {
            
            
                        this.Format = Format;
            
                        this.Message = Message;
            
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageSubmission {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as MessageSubmission);
        }

        /// <summary>
        /// Returns true if MessageSubmission instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageSubmission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSubmission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }
    }

}
