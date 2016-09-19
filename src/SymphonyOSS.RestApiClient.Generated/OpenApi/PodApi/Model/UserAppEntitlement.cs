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
    /// Application Entitlements for the user
    /// </summary>
    [DataContract]
    public partial class UserAppEntitlement :  IEquatable<UserAppEntitlement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAppEntitlement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserAppEntitlement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAppEntitlement" /> class.
        /// </summary>
        /// <param name="AppId">Unique ID for the Application (required).</param>
        /// <param name="AppName">Name for this Application (required).</param>
        /// <param name="Listed">if true, this application will be listed in the appstore for this user.  Otherwise, this application will be hidden in the appstore. (required).</param>
        /// <param name="Install">if true, it indicate this application is installed for this user.  Otherwise, this user does not have this application installed. (required).</param>
        /// <param name="Products">Products.</param>
        public UserAppEntitlement(string AppId = null, string AppName = null, bool? Listed = null, bool? Install = null, ProductList Products = null)
        {
            // to ensure "AppId" is required (not null)
            if (AppId == null)
            {
                throw new InvalidDataException("AppId is a required property for UserAppEntitlement and cannot be null");
            }
            else
            {
                this.AppId = AppId;
            }
            // to ensure "AppName" is required (not null)
            if (AppName == null)
            {
                throw new InvalidDataException("AppName is a required property for UserAppEntitlement and cannot be null");
            }
            else
            {
                this.AppName = AppName;
            }
            // to ensure "Listed" is required (not null)
            if (Listed == null)
            {
                throw new InvalidDataException("Listed is a required property for UserAppEntitlement and cannot be null");
            }
            else
            {
                this.Listed = Listed;
            }
            // to ensure "Install" is required (not null)
            if (Install == null)
            {
                throw new InvalidDataException("Install is a required property for UserAppEntitlement and cannot be null");
            }
            else
            {
                this.Install = Install;
            }
            this.Products = Products;
        }
        
        /// <summary>
        /// Unique ID for the Application
        /// </summary>
        /// <value>Unique ID for the Application</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }
        /// <summary>
        /// Name for this Application
        /// </summary>
        /// <value>Name for this Application</value>
        [DataMember(Name="appName", EmitDefaultValue=false)]
        public string AppName { get; set; }
        /// <summary>
        /// if true, this application will be listed in the appstore for this user.  Otherwise, this application will be hidden in the appstore.
        /// </summary>
        /// <value>if true, this application will be listed in the appstore for this user.  Otherwise, this application will be hidden in the appstore.</value>
        [DataMember(Name="listed", EmitDefaultValue=false)]
        public bool? Listed { get; set; }
        /// <summary>
        /// if true, it indicate this application is installed for this user.  Otherwise, this user does not have this application installed.
        /// </summary>
        /// <value>if true, it indicate this application is installed for this user.  Otherwise, this user does not have this application installed.</value>
        [DataMember(Name="install", EmitDefaultValue=false)]
        public bool? Install { get; set; }
        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public ProductList Products { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAppEntitlement {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  Listed: ").Append(Listed).Append("\n");
            sb.Append("  Install: ").Append(Install).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
            return this.Equals(obj as UserAppEntitlement);
        }

        /// <summary>
        /// Returns true if UserAppEntitlement instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAppEntitlement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAppEntitlement other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AppId == other.AppId ||
                    this.AppId != null &&
                    this.AppId.Equals(other.AppId)
                ) && 
                (
                    this.AppName == other.AppName ||
                    this.AppName != null &&
                    this.AppName.Equals(other.AppName)
                ) && 
                (
                    this.Listed == other.Listed ||
                    this.Listed != null &&
                    this.Listed.Equals(other.Listed)
                ) && 
                (
                    this.Install == other.Install ||
                    this.Install != null &&
                    this.Install.Equals(other.Install)
                ) && 
                (
                    this.Products == other.Products ||
                    this.Products != null &&
                    this.Products.Equals(other.Products)
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
                if (this.AppId != null)
                    hash = hash * 59 + this.AppId.GetHashCode();
                if (this.AppName != null)
                    hash = hash * 59 + this.AppName.GetHashCode();
                if (this.Listed != null)
                    hash = hash * 59 + this.Listed.GetHashCode();
                if (this.Install != null)
                    hash = hash * 59 + this.Install.GetHashCode();
                if (this.Products != null)
                    hash = hash * 59 + this.Products.GetHashCode();
                return hash;
            }
        }
    }

}
