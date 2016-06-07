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
    /// Password. Stored as derived password in both the Pod and the Key Manager using PBKDF2 function. Number of iterations should be 10000 and desired length 256 bits.
    /// </summary>
    [DataContract]
    public partial class Password :  IEquatable<Password>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Password" /> class.
        /// </summary>
        /// <param name="HSalt">Pod password salt used for PBKDF2 derivation..</param>
        /// <param name="HPassword">Pod password derived with PBKDF2..</param>
        /// <param name="KhSalt">Key Manager password salt used for PBKDF2 derivation..</param>
        /// <param name="KhPassword">Key Manager password derived with PBKDF2..</param>
        public Password(string HSalt = null, string HPassword = null, string KhSalt = null, string KhPassword = null)
        {
            
            
                        this.HSalt = HSalt;
            
                        this.HPassword = HPassword;
            
                        this.KhSalt = KhSalt;
            
                        this.KhPassword = KhPassword;
            
        }
        
        /// <summary>
        /// Pod password salt used for PBKDF2 derivation.
        /// </summary>
        /// <value>Pod password salt used for PBKDF2 derivation.</value>
        [DataMember(Name="hSalt", EmitDefaultValue=false)]
        public string HSalt { get; set; }
        /// <summary>
        /// Pod password derived with PBKDF2.
        /// </summary>
        /// <value>Pod password derived with PBKDF2.</value>
        [DataMember(Name="hPassword", EmitDefaultValue=false)]
        public string HPassword { get; set; }
        /// <summary>
        /// Key Manager password salt used for PBKDF2 derivation.
        /// </summary>
        /// <value>Key Manager password salt used for PBKDF2 derivation.</value>
        [DataMember(Name="khSalt", EmitDefaultValue=false)]
        public string KhSalt { get; set; }
        /// <summary>
        /// Key Manager password derived with PBKDF2.
        /// </summary>
        /// <value>Key Manager password derived with PBKDF2.</value>
        [DataMember(Name="khPassword", EmitDefaultValue=false)]
        public string KhPassword { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Password {\n");
            sb.Append("  HSalt: ").Append(HSalt).Append("\n");
sb.Append("  HPassword: ").Append(HPassword).Append("\n");
sb.Append("  KhSalt: ").Append(KhSalt).Append("\n");
sb.Append("  KhPassword: ").Append(KhPassword).Append("\n");
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
            return this.Equals(obj as Password);
        }

        /// <summary>
        /// Returns true if Password instances are equal
        /// </summary>
        /// <param name="other">Instance of Password to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Password other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HSalt == other.HSalt ||
                    this.HSalt != null &&
                    this.HSalt.Equals(other.HSalt)
                ) && 
                (
                    this.HPassword == other.HPassword ||
                    this.HPassword != null &&
                    this.HPassword.Equals(other.HPassword)
                ) && 
                (
                    this.KhSalt == other.KhSalt ||
                    this.KhSalt != null &&
                    this.KhSalt.Equals(other.KhSalt)
                ) && 
                (
                    this.KhPassword == other.KhPassword ||
                    this.KhPassword != null &&
                    this.KhPassword.Equals(other.KhPassword)
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
                if (this.HSalt != null)
                    hash = hash * 59 + this.HSalt.GetHashCode();
                if (this.HPassword != null)
                    hash = hash * 59 + this.HPassword.GetHashCode();
                if (this.KhSalt != null)
                    hash = hash * 59 + this.KhSalt.GetHashCode();
                if (this.KhPassword != null)
                    hash = hash * 59 + this.KhPassword.GetHashCode();
                return hash;
            }
        }
    }

}
