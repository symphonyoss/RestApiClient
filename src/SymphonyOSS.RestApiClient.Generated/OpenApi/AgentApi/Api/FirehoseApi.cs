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
    public interface IFirehoseApi
    {
        #region Synchronous Operations
        /// <summary>
        /// LIMITED RELEASE Create a new real time firehose.
        /// </summary>
        /// <remarks>
        /// A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Firehose</returns>
        Firehose V1FirehoseCreatePost (string sessionToken, string keyManagerToken);

        /// <summary>
        /// LIMITED RELEASE Create a new real time firehose.
        /// </summary>
        /// <remarks>
        /// A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>ApiResponse of Firehose</returns>
        ApiResponse<Firehose> V1FirehoseCreatePostWithHttpInfo (string sessionToken, string keyManagerToken);
        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>MessageList</returns>
        MessageList V1FirehoseIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of MessageList</returns>
        ApiResponse<MessageList> V1FirehoseIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>V2MessageList</returns>
        V2MessageList V2FirehoseIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of V2MessageList</returns>
        ApiResponse<V2MessageList> V2FirehoseIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// LIMITED RELEASE Create a new real time firehose.
        /// </summary>
        /// <remarks>
        /// A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of Firehose</returns>
        System.Threading.Tasks.Task<Firehose> V1FirehoseCreatePostAsync (string sessionToken, string keyManagerToken);

        /// <summary>
        /// LIMITED RELEASE Create a new real time firehose.
        /// </summary>
        /// <remarks>
        /// A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of ApiResponse (Firehose)</returns>
        System.Threading.Tasks.Task<ApiResponse<Firehose>> V1FirehoseCreatePostAsyncWithHttpInfo (string sessionToken, string keyManagerToken);
        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of MessageList</returns>
        System.Threading.Tasks.Task<MessageList> V1FirehoseIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (MessageList)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageList>> V1FirehoseIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of V2MessageList</returns>
        System.Threading.Tasks.Task<V2MessageList> V2FirehoseIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// LIMITED RELEASE Read a given firehose.
        /// </summary>
        /// <remarks>
        /// Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (V2MessageList)</returns>
        System.Threading.Tasks.Task<ApiResponse<V2MessageList>> V2FirehoseIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FirehoseApi : IFirehoseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirehoseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FirehoseApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirehoseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FirehoseApi(Configuration configuration = null)
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
        /// LIMITED RELEASE Create a new real time firehose. A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Firehose</returns>
        public Firehose V1FirehoseCreatePost (string sessionToken, string keyManagerToken)
        {
             ApiResponse<Firehose> localVarResponse = V1FirehoseCreatePostWithHttpInfo(sessionToken, keyManagerToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// LIMITED RELEASE Create a new real time firehose. A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>ApiResponse of Firehose</returns>
        public ApiResponse< Firehose > V1FirehoseCreatePostWithHttpInfo (string sessionToken, string keyManagerToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling FirehoseApi->V1FirehoseCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling FirehoseApi->V1FirehoseCreatePost");

            var localVarPath = "/v1/firehose/create";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Firehose>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Firehose) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Firehose)));
            
        }

        /// <summary>
        /// LIMITED RELEASE Create a new real time firehose. A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of Firehose</returns>
        public async System.Threading.Tasks.Task<Firehose> V1FirehoseCreatePostAsync (string sessionToken, string keyManagerToken)
        {
             ApiResponse<Firehose> localVarResponse = await V1FirehoseCreatePostAsyncWithHttpInfo(sessionToken, keyManagerToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// LIMITED RELEASE Create a new real time firehose. A firehose provides all user entered messages that occur within a\nSymphony pod beginning at the point in time that it is created.\n\nNote that unlike a datafeed, the user calling a firehose does not need to be a member of the conversations\nfor which it will receive messages.\n\nSystem messages like new users joining a chatroom are not part of the firehose.\n\nA firehose can only be created and accessed by a user with the content export role.\n\nA firehose will expire if its capacity for unread messages is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of ApiResponse (Firehose)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Firehose>> V1FirehoseCreatePostAsyncWithHttpInfo (string sessionToken, string keyManagerToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling FirehoseApi->V1FirehoseCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling FirehoseApi->V1FirehoseCreatePost");

            var localVarPath = "/v1/firehose/create";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Firehose>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Firehose) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Firehose)));
            
        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>MessageList</returns>
        public MessageList V1FirehoseIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<MessageList> localVarResponse = V1FirehoseIdReadGetWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;
        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of MessageList</returns>
        public ApiResponse< MessageList > V1FirehoseIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FirehoseApi->V1FirehoseIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling FirehoseApi->V1FirehoseIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling FirehoseApi->V1FirehoseIdReadGet");

            var localVarPath = "/v1/firehose/{id}/read";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (maxMessages != null) localVarQueryParams.Add("maxMessages", Configuration.ApiClient.ParameterToString(maxMessages)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageList)));
            
        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of MessageList</returns>
        public async System.Threading.Tasks.Task<MessageList> V1FirehoseIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<MessageList> localVarResponse = await V1FirehoseIdReadGetAsyncWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;

        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (MessageList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageList>> V1FirehoseIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FirehoseApi->V1FirehoseIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling FirehoseApi->V1FirehoseIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling FirehoseApi->V1FirehoseIdReadGet");

            var localVarPath = "/v1/firehose/{id}/read";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (maxMessages != null) localVarQueryParams.Add("maxMessages", Configuration.ApiClient.ParameterToString(maxMessages)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1FirehoseIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageList)));
            
        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>V2MessageList</returns>
        public V2MessageList V2FirehoseIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<V2MessageList> localVarResponse = V2FirehoseIdReadGetWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;
        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of V2MessageList</returns>
        public ApiResponse< V2MessageList > V2FirehoseIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FirehoseApi->V2FirehoseIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling FirehoseApi->V2FirehoseIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling FirehoseApi->V2FirehoseIdReadGet");

            var localVarPath = "/v2/firehose/{id}/read";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (maxMessages != null) localVarQueryParams.Add("maxMessages", Configuration.ApiClient.ParameterToString(maxMessages)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2FirehoseIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2FirehoseIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2MessageList)));
            
        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of V2MessageList</returns>
        public async System.Threading.Tasks.Task<V2MessageList> V2FirehoseIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<V2MessageList> localVarResponse = await V2FirehoseIdReadGetAsyncWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;

        }

        /// <summary>
        /// LIMITED RELEASE Read a given firehose. Read messages from the given firehose. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA firehose can only be read by a user with the content export role.\n\nA firehose will expire if its unread capacity is reached.\n\nA firehose can only be consumed by one client thread at a time. E.g. polling the firehose by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Firehose ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (V2MessageList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V2MessageList>> V2FirehoseIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FirehoseApi->V2FirehoseIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling FirehoseApi->V2FirehoseIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling FirehoseApi->V2FirehoseIdReadGet");

            var localVarPath = "/v2/firehose/{id}/read";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (maxMessages != null) localVarQueryParams.Add("maxMessages", Configuration.ApiClient.ParameterToString(maxMessages)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2FirehoseIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2FirehoseIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2MessageList)));
            
        }

    }
}
