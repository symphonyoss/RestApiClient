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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// A historic message to be imported into the system.\nThe importing user must have the Content Management role.\nAlso, the importing user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
    /// </summary>
    [DataContract]
    public partial class ImportedMessage :  IEquatable<ImportedMessage>
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
            /// Enum Messageml for "MESSAGEML"
            /// </summary>
            [EnumMember(Value = "MESSAGEML")]
            Messageml
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportedMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedMessage" /> class.
        /// </summary>
        /// <param name="Message">Message text in MessageML (required).</param>
        /// <param name="Format">Format.</param>
        /// <param name="IntendedMessageTimestamp">The timestamp representing the time when the message was sent in the original system\nin milliseconds since Jan 1st 1970.\n (required).</param>
        /// <param name="IntendedMessageFromUserId">The long integer userid of the Symphony user who you intend to show sent the message.\n (required).</param>
        /// <param name="OriginatingSystemId">The ID of the system through which the message was originally sent.\n (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        public ImportedMessage(string Message = null, FormatEnum? Format = null, long? IntendedMessageTimestamp = null, long? IntendedMessageFromUserId = null, string OriginatingSystemId = null, string StreamId = null)
        {
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for ImportedMessage and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "IntendedMessageTimestamp" is required (not null)
            if (IntendedMessageTimestamp == null)
            {
                throw new InvalidDataException("IntendedMessageTimestamp is a required property for ImportedMessage and cannot be null");
            }
            else
            {
                this.IntendedMessageTimestamp = IntendedMessageTimestamp;
            }
            // to ensure "IntendedMessageFromUserId" is required (not null)
            if (IntendedMessageFromUserId == null)
            {
                throw new InvalidDataException("IntendedMessageFromUserId is a required property for ImportedMessage and cannot be null");
            }
            else
            {
                this.IntendedMessageFromUserId = IntendedMessageFromUserId;
            }
            // to ensure "OriginatingSystemId" is required (not null)
            if (OriginatingSystemId == null)
            {
                throw new InvalidDataException("OriginatingSystemId is a required property for ImportedMessage and cannot be null");
            }
            else
            {
                this.OriginatingSystemId = OriginatingSystemId;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for ImportedMessage and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            
            
                        this.Format = Format;
            
        }
        
        /// <summary>
        /// Message text in MessageML
        /// </summary>
        /// <value>Message text in MessageML</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// The timestamp representing the time when the message was sent in the original system\nin milliseconds since Jan 1st 1970.\n
        /// </summary>
        /// <value>The timestamp representing the time when the message was sent in the original system\nin milliseconds since Jan 1st 1970.\n</value>
        [DataMember(Name="intendedMessageTimestamp", EmitDefaultValue=false)]
        public long? IntendedMessageTimestamp { get; set; }
        /// <summary>
        /// The long integer userid of the Symphony user who you intend to show sent the message.\n
        /// </summary>
        /// <value>The long integer userid of the Symphony user who you intend to show sent the message.\n</value>
        [DataMember(Name="intendedMessageFromUserId", EmitDefaultValue=false)]
        public long? IntendedMessageFromUserId { get; set; }
        /// <summary>
        /// The ID of the system through which the message was originally sent.\n
        /// </summary>
        /// <value>The ID of the system through which the message was originally sent.\n</value>
        [DataMember(Name="originatingSystemId", EmitDefaultValue=false)]
        public string OriginatingSystemId { get; set; }
        /// <summary>
        /// Gets or Sets StreamId
        /// </summary>
        [DataMember(Name="streamId", EmitDefaultValue=false)]
        public string StreamId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportedMessage {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
sb.Append("  Format: ").Append(Format).Append("\n");
sb.Append("  IntendedMessageTimestamp: ").Append(IntendedMessageTimestamp).Append("\n");
sb.Append("  IntendedMessageFromUserId: ").Append(IntendedMessageFromUserId).Append("\n");
sb.Append("  OriginatingSystemId: ").Append(OriginatingSystemId).Append("\n");
sb.Append("  StreamId: ").Append(StreamId).Append("\n");
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
            return this.Equals(obj as ImportedMessage);
        }

        /// <summary>
        /// Returns true if ImportedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportedMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.IntendedMessageTimestamp == other.IntendedMessageTimestamp ||
                    this.IntendedMessageTimestamp != null &&
                    this.IntendedMessageTimestamp.Equals(other.IntendedMessageTimestamp)
                ) && 
                (
                    this.IntendedMessageFromUserId == other.IntendedMessageFromUserId ||
                    this.IntendedMessageFromUserId != null &&
                    this.IntendedMessageFromUserId.Equals(other.IntendedMessageFromUserId)
                ) && 
                (
                    this.OriginatingSystemId == other.OriginatingSystemId ||
                    this.OriginatingSystemId != null &&
                    this.OriginatingSystemId.Equals(other.OriginatingSystemId)
                ) && 
                (
                    this.StreamId == other.StreamId ||
                    this.StreamId != null &&
                    this.StreamId.Equals(other.StreamId)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.IntendedMessageTimestamp != null)
                    hash = hash * 59 + this.IntendedMessageTimestamp.GetHashCode();
                if (this.IntendedMessageFromUserId != null)
                    hash = hash * 59 + this.IntendedMessageFromUserId.GetHashCode();
                if (this.OriginatingSystemId != null)
                    hash = hash * 59 + this.OriginatingSystemId.GetHashCode();
                if (this.StreamId != null)
                    hash = hash * 59 + this.StreamId.GetHashCode();
                return hash;
            }
        }
    }

}
