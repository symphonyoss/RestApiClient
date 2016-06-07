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
    /// V2RoomAttributes
    /// </summary>
    [DataContract]
    public partial class V2RoomAttributes :  IEquatable<V2RoomAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2RoomAttributes" /> class.
        /// </summary>
        /// <param name="Name">Room name..</param>
        /// <param name="Keywords">Keywords for search to use to find this room.</param>
        /// <param name="Description">Room description..</param>
        /// <param name="MembersCanInvite">If true, any chatroom participant can add new participants. If false, only owners can add new participants..</param>
        /// <param name="Discoverable">If true, this chatroom (name, description and messages) can be searched and listed by non-participants. If false, only participants can search this room..</param>
        /// <param name="_Public">If true, this is a public chatroom. IF false, a private chatroom..</param>
        /// <param name="_ReadOnly">If true, only stream owners can send messages..</param>
        /// <param name="CopyProtected">If true, clients disable the clipboard copy for content in this stream..</param>
        public V2RoomAttributes(string Name = null, List<RoomTag> Keywords = null, string Description = null, bool? MembersCanInvite = null, bool? Discoverable = null, bool? _Public = null, bool? _ReadOnly = null, bool? CopyProtected = null)
        {
            
            
                        this.Name = Name;
            
                        this.Keywords = Keywords;
            
                        this.Description = Description;
            
                        this.MembersCanInvite = MembersCanInvite;
            
                        this.Discoverable = Discoverable;
            
                        this._Public = _Public;
            
                        this._ReadOnly = _ReadOnly;
            
                        this.CopyProtected = CopyProtected;
            
        }
        
        /// <summary>
        /// Room name.
        /// </summary>
        /// <value>Room name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Keywords for search to use to find this room
        /// </summary>
        /// <value>Keywords for search to use to find this room</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<RoomTag> Keywords { get; set; }
        /// <summary>
        /// Room description.
        /// </summary>
        /// <value>Room description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// If true, any chatroom participant can add new participants. If false, only owners can add new participants.
        /// </summary>
        /// <value>If true, any chatroom participant can add new participants. If false, only owners can add new participants.</value>
        [DataMember(Name="membersCanInvite", EmitDefaultValue=false)]
        public bool? MembersCanInvite { get; set; }
        /// <summary>
        /// If true, this chatroom (name, description and messages) can be searched and listed by non-participants. If false, only participants can search this room.
        /// </summary>
        /// <value>If true, this chatroom (name, description and messages) can be searched and listed by non-participants. If false, only participants can search this room.</value>
        [DataMember(Name="discoverable", EmitDefaultValue=false)]
        public bool? Discoverable { get; set; }
        /// <summary>
        /// If true, this is a public chatroom. IF false, a private chatroom.
        /// </summary>
        /// <value>If true, this is a public chatroom. IF false, a private chatroom.</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool? _Public { get; set; }
        /// <summary>
        /// If true, only stream owners can send messages.
        /// </summary>
        /// <value>If true, only stream owners can send messages.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }
        /// <summary>
        /// If true, clients disable the clipboard copy for content in this stream.
        /// </summary>
        /// <value>If true, clients disable the clipboard copy for content in this stream.</value>
        [DataMember(Name="copyProtected", EmitDefaultValue=false)]
        public bool? CopyProtected { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2RoomAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Keywords: ").Append(Keywords).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  MembersCanInvite: ").Append(MembersCanInvite).Append("\n");
sb.Append("  Discoverable: ").Append(Discoverable).Append("\n");
sb.Append("  _Public: ").Append(_Public).Append("\n");
sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
sb.Append("  CopyProtected: ").Append(CopyProtected).Append("\n");
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
            return this.Equals(obj as V2RoomAttributes);
        }

        /// <summary>
        /// Returns true if V2RoomAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of V2RoomAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2RoomAttributes other)
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
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.MembersCanInvite == other.MembersCanInvite ||
                    this.MembersCanInvite != null &&
                    this.MembersCanInvite.Equals(other.MembersCanInvite)
                ) && 
                (
                    this.Discoverable == other.Discoverable ||
                    this.Discoverable != null &&
                    this.Discoverable.Equals(other.Discoverable)
                ) && 
                (
                    this._Public == other._Public ||
                    this._Public != null &&
                    this._Public.Equals(other._Public)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.CopyProtected == other.CopyProtected ||
                    this.CopyProtected != null &&
                    this.CopyProtected.Equals(other.CopyProtected)
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
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.MembersCanInvite != null)
                    hash = hash * 59 + this.MembersCanInvite.GetHashCode();
                if (this.Discoverable != null)
                    hash = hash * 59 + this.Discoverable.GetHashCode();
                if (this._Public != null)
                    hash = hash * 59 + this._Public.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.CopyProtected != null)
                    hash = hash * 59 + this.CopyProtected.GetHashCode();
                return hash;
            }
        }
    }

}
