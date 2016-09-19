// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
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
    public interface IDatafeedApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new real time message event stream.
        /// </summary>
        /// <remarks>
        /// A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Datafeed</returns>
        Datafeed V1DatafeedCreatePost (string sessionToken, string keyManagerToken);

        /// <summary>
        /// Create a new real time message event stream.
        /// </summary>
        /// <remarks>
        /// A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>ApiResponse of Datafeed</returns>
        ApiResponse<Datafeed> V1DatafeedCreatePostWithHttpInfo (string sessionToken, string keyManagerToken);
        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>MessageList</returns>
        MessageList V1DatafeedIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of MessageList</returns>
        ApiResponse<MessageList> V1DatafeedIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>V2MessageList</returns>
        V2MessageList V2DatafeedIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of V2MessageList</returns>
        ApiResponse<V2MessageList> V2DatafeedIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a new real time message event stream.
        /// </summary>
        /// <remarks>
        /// A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of Datafeed</returns>
        System.Threading.Tasks.Task<Datafeed> V1DatafeedCreatePostAsync (string sessionToken, string keyManagerToken);

        /// <summary>
        /// Create a new real time message event stream.
        /// </summary>
        /// <remarks>
        /// A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of ApiResponse (Datafeed)</returns>
        System.Threading.Tasks.Task<ApiResponse<Datafeed>> V1DatafeedCreatePostAsyncWithHttpInfo (string sessionToken, string keyManagerToken);
        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of MessageList</returns>
        System.Threading.Tasks.Task<MessageList> V1DatafeedIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (MessageList)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageList>> V1DatafeedIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of V2MessageList</returns>
        System.Threading.Tasks.Task<V2MessageList> V2DatafeedIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);

        /// <summary>
        /// Read a given datafeed.
        /// </summary>
        /// <remarks>
        /// Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (V2MessageList)</returns>
        System.Threading.Tasks.Task<ApiResponse<V2MessageList>> V2DatafeedIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DatafeedApi : IDatafeedApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatafeedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DatafeedApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatafeedApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DatafeedApi(Configuration configuration = null)
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
        /// Create a new real time message event stream. A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Datafeed</returns>
        public Datafeed V1DatafeedCreatePost (string sessionToken, string keyManagerToken)
        {
             ApiResponse<Datafeed> localVarResponse = V1DatafeedCreatePostWithHttpInfo(sessionToken, keyManagerToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new real time message event stream. A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>ApiResponse of Datafeed</returns>
        public ApiResponse< Datafeed > V1DatafeedCreatePostWithHttpInfo (string sessionToken, string keyManagerToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DatafeedApi->V1DatafeedCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling DatafeedApi->V1DatafeedCreatePost");

            var localVarPath = "/v1/datafeed/create";
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
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Datafeed>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Datafeed) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Datafeed)));
            
        }

        /// <summary>
        /// Create a new real time message event stream. A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of Datafeed</returns>
        public async System.Threading.Tasks.Task<Datafeed> V1DatafeedCreatePostAsync (string sessionToken, string keyManagerToken)
        {
             ApiResponse<Datafeed> localVarResponse = await V1DatafeedCreatePostAsyncWithHttpInfo(sessionToken, keyManagerToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new real time message event stream. A datafeed provides the messages in all conversations that a user is in.\nSystem messages like new users joining a chatroom are not part of the datafeed.\n\nA datafeed will expire after if it isn&#39;t read before its capacity is reached.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of ApiResponse (Datafeed)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Datafeed>> V1DatafeedCreatePostAsyncWithHttpInfo (string sessionToken, string keyManagerToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DatafeedApi->V1DatafeedCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling DatafeedApi->V1DatafeedCreatePost");

            var localVarPath = "/v1/datafeed/create";
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
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Datafeed>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Datafeed) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Datafeed)));
            
        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>MessageList</returns>
        public MessageList V1DatafeedIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<MessageList> localVarResponse = V1DatafeedIdReadGetWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of MessageList</returns>
        public ApiResponse< MessageList > V1DatafeedIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DatafeedApi->V1DatafeedIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DatafeedApi->V1DatafeedIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling DatafeedApi->V1DatafeedIdReadGet");

            var localVarPath = "/v1/datafeed/{id}/read";
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
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageList)));
            
        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of MessageList</returns>
        public async System.Threading.Tasks.Task<MessageList> V1DatafeedIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<MessageList> localVarResponse = await V1DatafeedIdReadGetAsyncWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (MessageList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageList>> V1DatafeedIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DatafeedApi->V1DatafeedIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DatafeedApi->V1DatafeedIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling DatafeedApi->V1DatafeedIdReadGet");

            var localVarPath = "/v1/datafeed/{id}/read";
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
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1DatafeedIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageList)));
            
        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>V2MessageList</returns>
        public V2MessageList V2DatafeedIdReadGet (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<V2MessageList> localVarResponse = V2DatafeedIdReadGetWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>ApiResponse of V2MessageList</returns>
        public ApiResponse< V2MessageList > V2DatafeedIdReadGetWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DatafeedApi->V2DatafeedIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DatafeedApi->V2DatafeedIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling DatafeedApi->V2DatafeedIdReadGet");

            var localVarPath = "/v2/datafeed/{id}/read";
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
                throw new ApiException (localVarStatusCode, "Error calling V2DatafeedIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2DatafeedIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2MessageList)));
            
        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of V2MessageList</returns>
        public async System.Threading.Tasks.Task<V2MessageList> V2DatafeedIdReadGetAsync (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
             ApiResponse<V2MessageList> localVarResponse = await V2DatafeedIdReadGetAsyncWithHttpInfo(id, sessionToken, keyManagerToken, maxMessages);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read a given datafeed. Read messages from the given datafeed. If no more messages are available then this method will block.\nIt is intended that the client should re-call this method as soon as it has processed the messages\nreceived in the previous call. If the client is able to consume messages more quickly than they become\navailable then each call will initially block, there is no need to delay before re-calling this method.\n\nA datafeed will expire if its unread capacity is reached.\nA datafeed can only be consumed by one client thread at a time. E.g. polling the datafeed by two threads may lead to messages being delivered out of order.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Datafeed ID\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="maxMessages">Max No. of messages to return.\n (optional)</param>
        /// <returns>Task of ApiResponse (V2MessageList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V2MessageList>> V2DatafeedIdReadGetAsyncWithHttpInfo (string id, string sessionToken, string keyManagerToken, int? maxMessages = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DatafeedApi->V2DatafeedIdReadGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DatafeedApi->V2DatafeedIdReadGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling DatafeedApi->V2DatafeedIdReadGet");

            var localVarPath = "/v2/datafeed/{id}/read";
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
                throw new ApiException (localVarStatusCode, "Error calling V2DatafeedIdReadGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2DatafeedIdReadGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2MessageList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2MessageList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2MessageList)));
            
        }

    }
}
