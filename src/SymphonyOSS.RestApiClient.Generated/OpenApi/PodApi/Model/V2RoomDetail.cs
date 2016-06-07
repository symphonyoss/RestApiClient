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
    /// V2RoomDetail
    /// </summary>
    [DataContract]
    public partial class V2RoomDetail :  IEquatable<V2RoomDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2RoomDetail" /> class.
        /// </summary>
        /// <param name="RoomAttributes">RoomAttributes.</param>
        /// <param name="RoomSystemInfo">RoomSystemInfo.</param>
        public V2RoomDetail(V2RoomAttributes RoomAttributes = null, RoomSystemInfo RoomSystemInfo = null)
        {
            
            
                        this.RoomAttributes = RoomAttributes;
            
                        this.RoomSystemInfo = RoomSystemInfo;
            
        }
        
        /// <summary>
        /// Gets or Sets RoomAttributes
        /// </summary>
        [DataMember(Name="roomAttributes", EmitDefaultValue=false)]
        public V2RoomAttributes RoomAttributes { get; set; }
        /// <summary>
        /// Gets or Sets RoomSystemInfo
        /// </summary>
        [DataMember(Name="roomSystemInfo", EmitDefaultValue=false)]
        public RoomSystemInfo RoomSystemInfo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2RoomDetail {\n");
            sb.Append("  RoomAttributes: ").Append(RoomAttributes).Append("\n");
sb.Append("  RoomSystemInfo: ").Append(RoomSystemInfo).Append("\n");
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
            return this.Equals(obj as V2RoomDetail);
        }

        /// <summary>
        /// Returns true if V2RoomDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of V2RoomDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2RoomDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RoomAttributes == other.RoomAttributes ||
                    this.RoomAttributes != null &&
                    this.RoomAttributes.Equals(other.RoomAttributes)
                ) && 
                (
                    this.RoomSystemInfo == other.RoomSystemInfo ||
                    this.RoomSystemInfo != null &&
                    this.RoomSystemInfo.Equals(other.RoomSystemInfo)
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
                if (this.RoomAttributes != null)
                    hash = hash * 59 + this.RoomAttributes.GetHashCode();
                if (this.RoomSystemInfo != null)
                    hash = hash * 59 + this.RoomSystemInfo.GetHashCode();
                return hash;
            }
        }
    }

}
