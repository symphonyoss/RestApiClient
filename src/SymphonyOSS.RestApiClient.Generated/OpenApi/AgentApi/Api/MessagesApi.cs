using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client;
using SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Import messages from other systems into Symphony.
        /// </summary>
        /// <remarks>
        /// Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>ImportResponseList</returns>
        ImportResponseList V1MessageImportPost (string sessionToken, string keyManagerToken, MessageImportList messageList);

        /// <summary>
        /// Import messages from other systems into Symphony.
        /// </summary>
        /// <remarks>
        /// Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>ApiResponse of ImportResponseList</returns>
        ApiResponse<ImportResponseList> V1MessageImportPostWithHttpInfo (string sessionToken, string keyManagerToken, MessageImportList messageList);
        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Message</returns>
        Message V1StreamSidMessageCreatePost (string sid, string sessionToken, string keyManagerToken, MessageSubmission message);

        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>ApiResponse of Message</returns>
        ApiResponse<Message> V1StreamSidMessageCreatePostWithHttpInfo (string sid, string sessionToken, string keyManagerToken, MessageSubmission message);
        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>MessageList</returns>
        MessageList V1StreamSidMessageGet (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null);

        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of MessageList</returns>
        ApiResponse<MessageList> V1StreamSidMessageGetWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null);
        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>V2Message</returns>
        V2Message V2StreamSidMessageCreatePost (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message);

        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>ApiResponse of V2Message</returns>
        ApiResponse<V2Message> V2StreamSidMessageCreatePostWithHttpInfo (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message);
        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>V2MessageList</returns>
        V2MessageList V2StreamSidMessageGet (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of V2MessageList</returns>
        ApiResponse<V2MessageList> V2StreamSidMessageGetWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Import messages from other systems into Symphony.
        /// </summary>
        /// <remarks>
        /// Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>Task of ImportResponseList</returns>
        System.Threading.Tasks.Task<ImportResponseList> V1MessageImportPostAsync (string sessionToken, string keyManagerToken, MessageImportList messageList);

        /// <summary>
        /// Import messages from other systems into Symphony.
        /// </summary>
        /// <remarks>
        /// Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>Task of ApiResponse (ImportResponseList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportResponseList>> V1MessageImportPostAsyncWithHttpInfo (string sessionToken, string keyManagerToken, MessageImportList messageList);
        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of Message</returns>
        System.Threading.Tasks.Task<Message> V1StreamSidMessageCreatePostAsync (string sid, string sessionToken, string keyManagerToken, MessageSubmission message);

        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of ApiResponse (Message)</returns>
        System.Threading.Tasks.Task<ApiResponse<Message>> V1StreamSidMessageCreatePostAsyncWithHttpInfo (string sid, string sessionToken, string keyManagerToken, MessageSubmission message);
        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of MessageList</returns>
        System.Threading.Tasks.Task<MessageList> V1StreamSidMessageGetAsync (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null);

        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (MessageList)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageList>> V1StreamSidMessageGetAsyncWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null);
        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of V2Message</returns>
        System.Threading.Tasks.Task<V2Message> V2StreamSidMessageCreatePostAsync (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message);

        /// <summary>
        /// Post a message to one existing stream.
        /// </summary>
        /// <remarks>
        /// Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of ApiResponse (V2Message)</returns>
        System.Threading.Tasks.Task<ApiResponse<V2Message>> V2StreamSidMessageCreatePostAsyncWithHttpInfo (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message);
        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of V2MessageList</returns>
        System.Threading.Tasks.Task<V2MessageList> V2StreamSidMessageGetAsync (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Get messages from an existing stream.
        /// </summary>
        /// <remarks>
        /// A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (V2MessageList)</returns>
        System.Threading.Tasks.Task<ApiResponse<V2MessageList>> V2StreamSidMessageGetAsyncWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MessagesApi : IMessagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Import messages from other systems into Symphony. Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>ImportResponseList</returns>
        public ImportResponseList V1MessageImportPost (string sessionToken, string keyManagerToken, MessageImportList messageList)
        {
             ApiResponse<ImportResponseList> localVarResponse = V1MessageImportPostWithHttpInfo(sessionToken, keyManagerToken, messageList);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Import messages from other systems into Symphony. Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>ApiResponse of ImportResponseList</returns>
        public ApiResponse< ImportResponseList > V1MessageImportPostWithHttpInfo (string sessionToken, string keyManagerToken, MessageImportList messageList)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V1MessageImportPost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V1MessageImportPost");
            // verify the required parameter 'messageList' is set
            if (messageList == null)
                throw new ApiException(400, "Missing required parameter 'messageList' when calling MessagesApi->V1MessageImportPost");

            var localVarPath = "/v1/message/import";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (messageList.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(messageList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = messageList; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1MessageImportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1MessageImportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportResponseList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportResponseList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportResponseList)));
            
        }

        /// <summary>
        /// Import messages from other systems into Symphony. Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>Task of ImportResponseList</returns>
        public async System.Threading.Tasks.Task<ImportResponseList> V1MessageImportPostAsync (string sessionToken, string keyManagerToken, MessageImportList messageList)
        {
             ApiResponse<ImportResponseList> localVarResponse = await V1MessageImportPostAsyncWithHttpInfo(sessionToken, keyManagerToken, messageList);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Import messages from other systems into Symphony. Sends a message to be imported into the system.\nAllows you to override the timestamp and author of the message with your desired values.\nThe requesting user must have the Content Management role.\nAlso, the requesting user must be a member of the conversation it is importing into.\nThe user that the message is intended to have come from must also be present in the conversation.\nThe intended message timestamp must be a valid time from the past. It cannot be a future timestamp.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="messageList"></param>
        /// <returns>Task of ApiResponse (ImportResponseList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportResponseList>> V1MessageImportPostAsyncWithHttpInfo (string sessionToken, string keyManagerToken, MessageImportList messageList)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V1MessageImportPost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V1MessageImportPost");
            // verify the required parameter 'messageList' is set
            if (messageList == null)
                throw new ApiException(400, "Missing required parameter 'messageList' when calling MessagesApi->V1MessageImportPost");

            var localVarPath = "/v1/message/import";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (messageList.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(messageList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = messageList; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1MessageImportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1MessageImportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportResponseList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportResponseList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportResponseList)));
            
        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Message</returns>
        public Message V1StreamSidMessageCreatePost (string sid, string sessionToken, string keyManagerToken, MessageSubmission message)
        {
             ApiResponse<Message> localVarResponse = V1StreamSidMessageCreatePostWithHttpInfo(sid, sessionToken, keyManagerToken, message);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>ApiResponse of Message</returns>
        public ApiResponse< Message > V1StreamSidMessageCreatePostWithHttpInfo (string sid, string sessionToken, string keyManagerToken, MessageSubmission message)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V1StreamSidMessageCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V1StreamSidMessageCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V1StreamSidMessageCreatePost");
            // verify the required parameter 'message' is set
            if (message == null)
                throw new ApiException(400, "Missing required parameter 'message' when calling MessagesApi->V1StreamSidMessageCreatePost");

            var localVarPath = "/v1/stream/{sid}/message/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (message.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(message); // http body (model) parameter
            }
            else
            {
                localVarPostBody = message; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Message)));
            
        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of Message</returns>
        public async System.Threading.Tasks.Task<Message> V1StreamSidMessageCreatePostAsync (string sid, string sessionToken, string keyManagerToken, MessageSubmission message)
        {
             ApiResponse<Message> localVarResponse = await V1StreamSidMessageCreatePostAsyncWithHttpInfo(sid, sessionToken, keyManagerToken, message);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of ApiResponse (Message)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Message>> V1StreamSidMessageCreatePostAsyncWithHttpInfo (string sid, string sessionToken, string keyManagerToken, MessageSubmission message)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V1StreamSidMessageCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V1StreamSidMessageCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V1StreamSidMessageCreatePost");
            // verify the required parameter 'message' is set
            if (message == null)
                throw new ApiException(400, "Missing required parameter 'message' when calling MessagesApi->V1StreamSidMessageCreatePost");

            var localVarPath = "/v1/stream/{sid}/message/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (message.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(message); // http body (model) parameter
            }
            else
            {
                localVarPostBody = message; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Message)));
            
        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>MessageList</returns>
        public MessageList V1StreamSidMessageGet (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null)
        {
             ApiResponse<MessageList> localVarResponse = V1StreamSidMessageGetWithHttpInfo(sid, since, sessionToken, keyManagerToken, offset, maxMessages);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of MessageList</returns>
        public ApiResponse< MessageList > V1StreamSidMessageGetWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V1StreamSidMessageGet");
            // verify the required parameter 'since' is set
            if (since == null)
                throw new ApiException(400, "Missing required parameter 'since' when calling MessagesApi->V1StreamSidMessageGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V1StreamSidMessageGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V1StreamSidMessageGet");

            var localVarPath = "/v1/stream/{sid}/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (since != null) localVarQueryParams.Add("since", Configuration.ApiClient.ParameterToString(since)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (maxMessages != null) localVarQueryParams.Add("maxMessages", Configuration.ApiClient.ParameterToString(maxMessages)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageList)));
            
        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of MessageList</returns>
        public async System.Threading.Tasks.Task<MessageList> V1StreamSidMessageGetAsync (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null)
        {
             ApiResponse<MessageList> localVarResponse = await V1StreamSidMessageGetAsyncWithHttpInfo(sid, since, sessionToken, keyManagerToken, offset, maxMessages);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="maxMessages">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (MessageList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageList>> V1StreamSidMessageGetAsyncWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? maxMessages = null)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V1StreamSidMessageGet");
            // verify the required parameter 'since' is set
            if (since == null)
                throw new ApiException(400, "Missing required parameter 'since' when calling MessagesApi->V1StreamSidMessageGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V1StreamSidMessageGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V1StreamSidMessageGet");

            var localVarPath = "/v1/stream/{sid}/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (since != null) localVarQueryParams.Add("since", Configuration.ApiClient.ParameterToString(since)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (maxMessages != null) localVarQueryParams.Add("maxMessages", Configuration.ApiClient.ParameterToString(maxMessages)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidMessageGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageList)));
            
        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>V2Message</returns>
        public V2Message V2StreamSidMessageCreatePost (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message)
        {
             ApiResponse<V2Message> localVarResponse = V2StreamSidMessageCreatePostWithHttpInfo(sid, sessionToken, keyManagerToken, message);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>ApiResponse of V2Message</returns>
        public ApiResponse< V2Message > V2StreamSidMessageCreatePostWithHttpInfo (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V2StreamSidMessageCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V2StreamSidMessageCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V2StreamSidMessageCreatePost");
            // verify the required parameter 'message' is set
            if (message == null)
                throw new ApiException(400, "Missing required parameter 'message' when calling MessagesApi->V2StreamSidMessageCreatePost");

            var localVarPath = "/v2/stream/{sid}/message/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (message.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(message); // http body (model) parameter
            }
            else
            {
                localVarPostBody = message; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2Message) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2Message)));
            
        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of V2Message</returns>
        public async System.Threading.Tasks.Task<V2Message> V2StreamSidMessageCreatePostAsync (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message)
        {
             ApiResponse<V2Message> localVarResponse = await V2StreamSidMessageCreatePostAsyncWithHttpInfo(sid, sessionToken, keyManagerToken, message);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Post a message to one existing stream. Post a new message to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nYou may include an attachment on the message (see the V2MessageSubmission parameter).\n\nIf the message parameter type is TEXT then the message contains plain\ntext and cannot include formating, hash tags, mentions etc.\n\nIf the message parameter type is MessageML then the message contains\nMessageML which allows for these entities.\n\nIf the message is in MessageML and fails schema validation\na client error results\n\nIf the message is sent then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="message"></param>
        /// <returns>Task of ApiResponse (V2Message)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V2Message>> V2StreamSidMessageCreatePostAsyncWithHttpInfo (string sid, string sessionToken, string keyManagerToken, V2MessageSubmission message)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V2StreamSidMessageCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V2StreamSidMessageCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V2StreamSidMessageCreatePost");
            // verify the required parameter 'message' is set
            if (message == null)
                throw new ApiException(400, "Missing required parameter 'message' when calling MessagesApi->V2StreamSidMessageCreatePost");

            var localVarPath = "/v2/stream/{sid}/message/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (message.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(message); // http body (model) parameter
            }
            else
            {
                localVarPostBody = message; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2Message) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2Message)));
            
        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>V2MessageList</returns>
        public V2MessageList V2StreamSidMessageGet (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null)
        {
             ApiResponse<V2MessageList> localVarResponse = V2StreamSidMessageGetWithHttpInfo(sid, since, sessionToken, keyManagerToken, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of V2MessageList</returns>
        public ApiResponse< V2MessageList > V2StreamSidMessageGetWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V2StreamSidMessageGet");
            // verify the required parameter 'since' is set
            if (since == null)
                throw new ApiException(400, "Missing required parameter 'since' when calling MessagesApi->V2StreamSidMessageGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V2StreamSidMessageGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V2StreamSidMessageGet");

            var localVarPath = "/v2/stream/{sid}/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (since != null) localVarQueryParams.Add("since", Configuration.ApiClient.ParameterToString(since)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2MessageList)));
            
        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of V2MessageList</returns>
        public async System.Threading.Tasks.Task<V2MessageList> V2StreamSidMessageGetAsync (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null)
        {
             ApiResponse<V2MessageList> localVarResponse = await V2StreamSidMessageGetAsyncWithHttpInfo(sid, since, sessionToken, keyManagerToken, offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get messages from an existing stream. A caller can fetch all unseen messages by passing the timestamp of\nthe last message seen as the since parameter and the number of messages\nwith the same timestamp value already seen as the skip parameter. This\nmeans that every message will be seen exactly once even in the case that\nan additional message is processed with the same timestamp as the last\nmessage returned by the previous call, and the case where there are\nmore than maxMessages with the same timestamp value.\n\nThis method is intended for historic queries and is generally reliable\nbut if guaranteed delivery of every message in real time is required\nthen the equivilent firehose method should be called.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID\n</param>
        /// <param name="since">Timestamp of first required message.\n\nThis is a long integer value representing milliseconds since\nJan 1 1970\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="offset">No. of messages to skip.\n (optional)</param>
        /// <param name="limit">Max No. of messages to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (V2MessageList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V2MessageList>> V2StreamSidMessageGetAsyncWithHttpInfo (string sid, long? since, string sessionToken, string keyManagerToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling MessagesApi->V2StreamSidMessageGet");
            // verify the required parameter 'since' is set
            if (since == null)
                throw new ApiException(400, "Missing required parameter 'since' when calling MessagesApi->V2StreamSidMessageGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling MessagesApi->V2StreamSidMessageGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling MessagesApi->V2StreamSidMessageGet");

            var localVarPath = "/v2/stream/{sid}/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (since != null) localVarQueryParams.Add("since", Configuration.ApiClient.ParameterToString(since)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2StreamSidMessageGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2MessageList)));
            
        }

    }
}
