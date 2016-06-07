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
    /// CompanyCertInfoListInner
    /// </summary>
    [DataContract]
    public partial class CompanyCertInfoListInner :  IEquatable<CompanyCertInfoListInner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCertInfoListInner" /> class.
        /// </summary>
        /// <param name="CompanyCertAttributes">CompanyCertAttributes.</param>
        /// <param name="CompanyCertInfo">CompanyCertInfo.</param>
        public CompanyCertInfoListInner(CompanyCertAttributes CompanyCertAttributes = null, CompanyCertInfo CompanyCertInfo = null)
        {
            
            
                        this.CompanyCertAttributes = CompanyCertAttributes;
            
                        this.CompanyCertInfo = CompanyCertInfo;
            
        }
        
        /// <summary>
        /// Gets or Sets CompanyCertAttributes
        /// </summary>
        [DataMember(Name="companyCertAttributes", EmitDefaultValue=false)]
        public CompanyCertAttributes CompanyCertAttributes { get; set; }
        /// <summary>
        /// Gets or Sets CompanyCertInfo
        /// </summary>
        [DataMember(Name="companyCertInfo", EmitDefaultValue=false)]
        public CompanyCertInfo CompanyCertInfo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyCertInfoListInner {\n");
            sb.Append("  CompanyCertAttributes: ").Append(CompanyCertAttributes).Append("\n");
sb.Append("  CompanyCertInfo: ").Append(CompanyCertInfo).Append("\n");
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
            return this.Equals(obj as CompanyCertInfoListInner);
        }

        /// <summary>
        /// Returns true if CompanyCertInfoListInner instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyCertInfoListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyCertInfoListInner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyCertAttributes == other.CompanyCertAttributes ||
                    this.CompanyCertAttributes != null &&
                    this.CompanyCertAttributes.Equals(other.CompanyCertAttributes)
                ) && 
                (
                    this.CompanyCertInfo == other.CompanyCertInfo ||
                    this.CompanyCertInfo != null &&
                    this.CompanyCertInfo.Equals(other.CompanyCertInfo)
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
                if (this.CompanyCertAttributes != null)
                    hash = hash * 59 + this.CompanyCertAttributes.GetHashCode();
                if (this.CompanyCertInfo != null)
                    hash = hash * 59 + this.CompanyCertInfo.GetHashCode();
                return hash;
            }
        }
    }

}
