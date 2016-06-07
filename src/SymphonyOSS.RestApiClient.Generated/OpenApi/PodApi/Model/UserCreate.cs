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
    /// User Creation Object. After creation, modify roles, features etc via the specific API calls.
    /// </summary>
    [DataContract]
    public partial class UserCreate :  IEquatable<UserCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreate" /> class.
        /// </summary>
        /// <param name="UserAttributes">UserAttributes.</param>
        /// <param name="Password">Password.</param>
        /// <param name="Roles">Roles.</param>
        public UserCreate(UserAttributes UserAttributes = null, Password Password = null, List<string> Roles = null)
        {
            
            
                        this.UserAttributes = UserAttributes;
            
                        this.Password = Password;
            
                        this.Roles = Roles;
            
        }
        
        /// <summary>
        /// Gets or Sets UserAttributes
        /// </summary>
        [DataMember(Name="userAttributes", EmitDefaultValue=false)]
        public UserAttributes UserAttributes { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public Password Password { get; set; }
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreate {\n");
            sb.Append("  UserAttributes: ").Append(UserAttributes).Append("\n");
sb.Append("  Password: ").Append(Password).Append("\n");
sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(obj as UserCreate);
        }

        /// <summary>
        /// Returns true if UserCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of UserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserAttributes == other.UserAttributes ||
                    this.UserAttributes != null &&
                    this.UserAttributes.Equals(other.UserAttributes)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
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
                if (this.UserAttributes != null)
                    hash = hash * 59 + this.UserAttributes.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                return hash;
            }
        }
    }

}
