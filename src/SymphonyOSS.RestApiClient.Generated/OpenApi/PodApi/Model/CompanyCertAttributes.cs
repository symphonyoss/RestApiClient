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
    /// CompanyCertAttributes
    /// </summary>
    [DataContract]
    public partial class CompanyCertAttributes :  IEquatable<CompanyCertAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCertAttributes" /> class.
        /// </summary>
        /// <param name="Name">Friendly name assigned by administrator.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Status">Status.</param>
        public CompanyCertAttributes(string Name = null, CompanyCertType Type = null, CompanyCertStatus Status = null)
        {
            
            
                        this.Name = Name;
            
                        this.Type = Type;
            
                        this.Status = Status;
            
        }
        
        /// <summary>
        /// Friendly name assigned by administrator
        /// </summary>
        /// <value>Friendly name assigned by administrator</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public CompanyCertType Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public CompanyCertStatus Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyCertAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Type: ").Append(Type).Append("\n");
sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as CompanyCertAttributes);
        }

        /// <summary>
        /// Returns true if CompanyCertAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyCertAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyCertAttributes other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }
    }

}
