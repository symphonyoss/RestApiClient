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
    /// A representation of a message sent by a user of Symphony.
    /// </summary>
    [DataContract]
    public partial class Message : BaseMessage,  IEquatable<Message>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Message() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="Id">The messageId is assigned by the ingestor service when a message is sent..</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="MessageType">MessageType (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        /// <param name="_Message">Message text in MessageML (required).</param>
        /// <param name="FromUserId">the Symphony userId of the user who sent the message. This will be populated by the server (and actually ignored if included when sending a message). (required).</param>
        public Message(string Id = null, string Timestamp = null, string MessageType = null, string StreamId = null, string _Message = null, long? FromUserId = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for Message and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "MessageType" is required (not null)
            if (MessageType == null)
            {
                throw new InvalidDataException("MessageType is a required property for Message and cannot be null");
            }
            else
            {
                this.MessageType = MessageType;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for Message and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            // to ensure "_Message" is required (not null)
            if (_Message == null)
            {
                throw new InvalidDataException("_Message is a required property for Message and cannot be null");
            }
            else
            {
                this._Message = _Message;
            }
            // to ensure "FromUserId" is required (not null)
            if (FromUserId == null)
            {
                throw new InvalidDataException("FromUserId is a required property for Message and cannot be null");
            }
            else
            {
                this.FromUserId = FromUserId;
            }
            
            
                        this.Id = Id;
            
        }
        
        /// <summary>
        /// The messageId is assigned by the ingestor service when a message is sent.
        /// </summary>
        /// <value>The messageId is assigned by the ingestor service when a message is sent.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public string MessageType { get; set; }
        /// <summary>
        /// Gets or Sets StreamId
        /// </summary>
        [DataMember(Name="streamId", EmitDefaultValue=false)]
        public string StreamId { get; set; }
        /// <summary>
        /// Message text in MessageML
        /// </summary>
        /// <value>Message text in MessageML</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string _Message { get; set; }
        /// <summary>
        /// the Symphony userId of the user who sent the message. This will be populated by the server (and actually ignored if included when sending a message).
        /// </summary>
        /// <value>the Symphony userId of the user who sent the message. This will be populated by the server (and actually ignored if included when sending a message).</value>
        [DataMember(Name="fromUserId", EmitDefaultValue=false)]
        public long? FromUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
sb.Append("  MessageType: ").Append(MessageType).Append("\n");
sb.Append("  StreamId: ").Append(StreamId).Append("\n");
sb.Append("  _Message: ").Append(_Message).Append("\n");
sb.Append("  FromUserId: ").Append(FromUserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="other">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message other)
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
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) && 
                (
                    this.StreamId == other.StreamId ||
                    this.StreamId != null &&
                    this.StreamId.Equals(other.StreamId)
                ) && 
                (
                    this._Message == other._Message ||
                    this._Message != null &&
                    this._Message.Equals(other._Message)
                ) && 
                (
                    this.FromUserId == other.FromUserId ||
                    this.FromUserId != null &&
                    this.FromUserId.Equals(other.FromUserId)
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
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();
                if (this.StreamId != null)
                    hash = hash * 59 + this.StreamId.GetHashCode();
                if (this._Message != null)
                    hash = hash * 59 + this._Message.GetHashCode();
                if (this.FromUserId != null)
                    hash = hash * 59 + this.FromUserId.GetHashCode();
                return hash;
            }
        }
    }

}
