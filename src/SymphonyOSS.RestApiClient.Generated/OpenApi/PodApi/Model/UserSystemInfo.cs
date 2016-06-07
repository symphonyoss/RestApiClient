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
    /// User Status Information.
    /// </summary>
    [DataContract]
    public partial class UserSystemInfo :  IEquatable<UserSystemInfo>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Enabled for "ENABLED"
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            Enabled,
            
            /// <summary>
            /// Enum Disabled for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            Disabled
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSystemInfo" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Status">Status.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="LastUpdatedDate">LastUpdatedDate.</param>
        /// <param name="LastLoginDate">LastLoginDate.</param>
        /// <param name="LastPasswordReset">LastPasswordReset.</param>
        public UserSystemInfo(long? Id = null, StatusEnum? Status = null, long? CreatedDate = null, string CreatedBy = null, long? LastUpdatedDate = null, long? LastLoginDate = null, long? LastPasswordReset = null)
        {
            
            
                        this.Id = Id;
            
                        this.Status = Status;
            
                        this.CreatedDate = CreatedDate;
            
                        this.CreatedBy = CreatedBy;
            
                        this.LastUpdatedDate = LastUpdatedDate;
            
                        this.LastLoginDate = LastLoginDate;
            
                        this.LastPasswordReset = LastPasswordReset;
            
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public long? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public long? LastUpdatedDate { get; set; }
        /// <summary>
        /// Gets or Sets LastLoginDate
        /// </summary>
        [DataMember(Name="lastLoginDate", EmitDefaultValue=false)]
        public long? LastLoginDate { get; set; }
        /// <summary>
        /// Gets or Sets LastPasswordReset
        /// </summary>
        [DataMember(Name="lastPasswordReset", EmitDefaultValue=false)]
        public long? LastPasswordReset { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSystemInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Status: ").Append(Status).Append("\n");
sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
sb.Append("  LastLoginDate: ").Append(LastLoginDate).Append("\n");
sb.Append("  LastPasswordReset: ").Append(LastPasswordReset).Append("\n");
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
            return this.Equals(obj as UserSystemInfo);
        }

        /// <summary>
        /// Returns true if UserSystemInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSystemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSystemInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.LastUpdatedDate == other.LastUpdatedDate ||
                    this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(other.LastUpdatedDate)
                ) && 
                (
                    this.LastLoginDate == other.LastLoginDate ||
                    this.LastLoginDate != null &&
                    this.LastLoginDate.Equals(other.LastLoginDate)
                ) && 
                (
                    this.LastPasswordReset == other.LastPasswordReset ||
                    this.LastPasswordReset != null &&
                    this.LastPasswordReset.Equals(other.LastPasswordReset)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hash = hash * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.LastLoginDate != null)
                    hash = hash * 59 + this.LastLoginDate.GetHashCode();
                if (this.LastPasswordReset != null)
                    hash = hash * 59 + this.LastPasswordReset.GetHashCode();
                return hash;
            }
        }
    }

}
