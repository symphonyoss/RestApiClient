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
    /// UserPresence
    /// </summary>
    [DataContract]
    public partial class UserPresence :  IEquatable<UserPresence>
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum Undefined for "UNDEFINED"
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            Undefined,
            
            /// <summary>
            /// Enum Available for "AVAILABLE"
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            Available,
            
            /// <summary>
            /// Enum Busy for "BUSY"
            /// </summary>
            [EnumMember(Value = "BUSY")]
            Busy,
            
            /// <summary>
            /// Enum DoNotDisturb for "DO_NOT_DISTURB"
            /// </summary>
            [EnumMember(Value = "DO_NOT_DISTURB")]
            DoNotDisturb,
            
            /// <summary>
            /// Enum OnThePhone for "ON_THE_PHONE"
            /// </summary>
            [EnumMember(Value = "ON_THE_PHONE")]
            OnThePhone,
            
            /// <summary>
            /// Enum BeRightBack for "BE_RIGHT_BACK"
            /// </summary>
            [EnumMember(Value = "BE_RIGHT_BACK")]
            BeRightBack,
            
            /// <summary>
            /// Enum Away for "AWAY"
            /// </summary>
            [EnumMember(Value = "AWAY")]
            Away,
            
            /// <summary>
            /// Enum Offline for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            Offline
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPresence" /> class.
        /// </summary>
        /// <param name="Uid">Uid.</param>
        /// <param name="Category">Category.</param>
        public UserPresence(long? Uid = null, CategoryEnum? Category = null)
        {
            
            
                        this.Uid = Uid;
            
                        this.Category = Category;
            
        }
        
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public long? Uid { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPresence {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as UserPresence);
        }

        /// <summary>
        /// Returns true if UserPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of UserPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPresence other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                return hash;
            }
        }
    }

}
