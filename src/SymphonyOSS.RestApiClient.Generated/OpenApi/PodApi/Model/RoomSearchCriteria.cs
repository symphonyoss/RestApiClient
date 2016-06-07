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
    /// Room Query Object. Used to specify the parameters for room search.
    /// </summary>
    [DataContract]
    public partial class RoomSearchCriteria :  IEquatable<RoomSearchCriteria>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomSearchCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomSearchCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomSearchCriteria" /> class.
        /// </summary>
        /// <param name="Query">The search query. Matches the room name and description. (required).</param>
        /// <param name="Labels">A list of room tag labels whose values will be queried..</param>
        /// <param name="Active">Restrict the search to active/inactive rooms. If unspecified, search all rooms..</param>
        /// <param name="_Private">Restrict the search to private rooms. If unspecified, search all rooms..</param>
        /// <param name="Owner">Restrict the search to rooms owned by the specified user ID..</param>
        /// <param name="Creator">Restrict the search to rooms created by the specified user ID..</param>
        /// <param name="Member">Restrict the search to rooms having the specified user ID as member..</param>
        public RoomSearchCriteria(string Query = null, List<string> Labels = null, bool? Active = null, bool? _Private = null, UserId Owner = null, UserId Creator = null, UserId Member = null)
        {
            // to ensure "Query" is required (not null)
            if (Query == null)
            {
                throw new InvalidDataException("Query is a required property for RoomSearchCriteria and cannot be null");
            }
            else
            {
                this.Query = Query;
            }
            
            
                        this.Labels = Labels;
            
                        this.Active = Active;
            
                        this._Private = _Private;
            
                        this.Owner = Owner;
            
                        this.Creator = Creator;
            
                        this.Member = Member;
            
        }
        
        /// <summary>
        /// The search query. Matches the room name and description.
        /// </summary>
        /// <value>The search query. Matches the room name and description.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
        /// <summary>
        /// A list of room tag labels whose values will be queried.
        /// </summary>
        /// <value>A list of room tag labels whose values will be queried.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<string> Labels { get; set; }
        /// <summary>
        /// Restrict the search to active/inactive rooms. If unspecified, search all rooms.
        /// </summary>
        /// <value>Restrict the search to active/inactive rooms. If unspecified, search all rooms.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Restrict the search to private rooms. If unspecified, search all rooms.
        /// </summary>
        /// <value>Restrict the search to private rooms. If unspecified, search all rooms.</value>
        [DataMember(Name="private", EmitDefaultValue=false)]
        public bool? _Private { get; set; }
        /// <summary>
        /// Restrict the search to rooms owned by the specified user ID.
        /// </summary>
        /// <value>Restrict the search to rooms owned by the specified user ID.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserId Owner { get; set; }
        /// <summary>
        /// Restrict the search to rooms created by the specified user ID.
        /// </summary>
        /// <value>Restrict the search to rooms created by the specified user ID.</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public UserId Creator { get; set; }
        /// <summary>
        /// Restrict the search to rooms having the specified user ID as member.
        /// </summary>
        /// <value>Restrict the search to rooms having the specified user ID as member.</value>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public UserId Member { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomSearchCriteria {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
sb.Append("  Labels: ").Append(Labels).Append("\n");
sb.Append("  Active: ").Append(Active).Append("\n");
sb.Append("  _Private: ").Append(_Private).Append("\n");
sb.Append("  Owner: ").Append(Owner).Append("\n");
sb.Append("  Creator: ").Append(Creator).Append("\n");
sb.Append("  Member: ").Append(Member).Append("\n");
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
            return this.Equals(obj as RoomSearchCriteria);
        }

        /// <summary>
        /// Returns true if RoomSearchCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomSearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomSearchCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(other.Labels)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this._Private == other._Private ||
                    this._Private != null &&
                    this._Private.Equals(other._Private)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.Creator == other.Creator ||
                    this.Creator != null &&
                    this.Creator.Equals(other.Creator)
                ) && 
                (
                    this.Member == other.Member ||
                    this.Member != null &&
                    this.Member.Equals(other.Member)
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
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.Labels != null)
                    hash = hash * 59 + this.Labels.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this._Private != null)
                    hash = hash * 59 + this._Private.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Creator != null)
                    hash = hash * 59 + this.Creator.GetHashCode();
                if (this.Member != null)
                    hash = hash * 59 + this.Member.GetHashCode();
                return hash;
            }
        }
    }

}
