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
    /// Disclaimer
    /// </summary>
    [DataContract]
    public partial class Disclaimer :  IEquatable<Disclaimer>
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
            /// Enum Xml for "XML"
            /// </summary>
            [EnumMember(Value = "XML")]
            Xml
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Disclaimer" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Content">Content.</param>
        /// <param name="FrequencyInHours">FrequencyInHours.</param>
        /// <param name="IsDefault">IsDefault.</param>
        /// <param name="IsActive">IsActive.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        /// <param name="Format">Format.</param>
        public Disclaimer(string Id = null, string Name = null, string Content = null, int? FrequencyInHours = null, bool? IsDefault = null, bool? IsActive = null, long? CreatedDate = null, long? ModifiedDate = null, FormatEnum? Format = null)
        {
            
            
                        this.Id = Id;
            
                        this.Name = Name;
            
                        this.Content = Content;
            
                        this.FrequencyInHours = FrequencyInHours;
            
                        this.IsDefault = IsDefault;
            
                        this.IsActive = IsActive;
            
                        this.CreatedDate = CreatedDate;
            
                        this.ModifiedDate = ModifiedDate;
            
                        this.Format = Format;
            
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        /// <summary>
        /// Gets or Sets FrequencyInHours
        /// </summary>
        [DataMember(Name="frequencyInHours", EmitDefaultValue=false)]
        public int? FrequencyInHours { get; set; }
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public long? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public long? ModifiedDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Disclaimer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Content: ").Append(Content).Append("\n");
sb.Append("  FrequencyInHours: ").Append(FrequencyInHours).Append("\n");
sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
sb.Append("  IsActive: ").Append(IsActive).Append("\n");
sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(obj as Disclaimer);
        }

        /// <summary>
        /// Returns true if Disclaimer instances are equal
        /// </summary>
        /// <param name="other">Instance of Disclaimer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Disclaimer other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.FrequencyInHours == other.FrequencyInHours ||
                    this.FrequencyInHours != null &&
                    this.FrequencyInHours.Equals(other.FrequencyInHours)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.FrequencyInHours != null)
                    hash = hash * 59 + this.FrequencyInHours.GetHashCode();
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                return hash;
            }
        }
    }

}
