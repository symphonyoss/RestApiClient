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
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Accept the connection request for the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>UserConnection</returns>
        UserConnection V1ConnectionAcceptPost (string sessionToken, UserConnectionRequest connectionRequest);

        /// <summary>
        /// Accept the connection request for the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>ApiResponse of UserConnection</returns>
        ApiResponse<UserConnection> V1ConnectionAcceptPostWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest);
        /// <summary>
        /// Sends an invitation to connect with another user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>UserConnection</returns>
        UserConnection V1ConnectionCreatePost (string sessionToken, UserConnectionRequest connectionRequest);

        /// <summary>
        /// Sends an invitation to connect with another user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>ApiResponse of UserConnection</returns>
        ApiResponse<UserConnection> V1ConnectionCreatePostWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest);
        /// <summary>
        /// List of requesting user&#39;s connection
        /// </summary>
        /// <remarks>
        /// This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>UserConnectionList</returns>
        UserConnectionList V1ConnectionListGet (string sessionToken, string status = null, string userIds = null);

        /// <summary>
        /// List of requesting user&#39;s connection
        /// </summary>
        /// <remarks>
        /// This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>ApiResponse of UserConnectionList</returns>
        ApiResponse<UserConnectionList> V1ConnectionListGetWithHttpInfo (string sessionToken, string status = null, string userIds = null);
        /// <summary>
        /// Reject the connection request for the requesting user.
        /// </summary>
        /// <remarks>
        /// Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>UserConnection</returns>
        UserConnection V1ConnectionRejectPost (string sessionToken, UserConnectionRequest connectionRequest);

        /// <summary>
        /// Reject the connection request for the requesting user.
        /// </summary>
        /// <remarks>
        /// Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>ApiResponse of UserConnection</returns>
        ApiResponse<UserConnection> V1ConnectionRejectPostWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest);
        /// <summary>
        /// The status of the connection invitation to another user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>UserConnection</returns>
        UserConnection V1ConnectionUserUserIdInfoGet (string sessionToken, string userId);

        /// <summary>
        /// The status of the connection invitation to another user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>ApiResponse of UserConnection</returns>
        ApiResponse<UserConnection> V1ConnectionUserUserIdInfoGetWithHttpInfo (string sessionToken, string userId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Accept the connection request for the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of UserConnection</returns>
        System.Threading.Tasks.Task<UserConnection> V1ConnectionAcceptPostAsync (string sessionToken, UserConnectionRequest connectionRequest);

        /// <summary>
        /// Accept the connection request for the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionAcceptPostAsyncWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest);
        /// <summary>
        /// Sends an invitation to connect with another user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of UserConnection</returns>
        System.Threading.Tasks.Task<UserConnection> V1ConnectionCreatePostAsync (string sessionToken, UserConnectionRequest connectionRequest);

        /// <summary>
        /// Sends an invitation to connect with another user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionCreatePostAsyncWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest);
        /// <summary>
        /// List of requesting user&#39;s connection
        /// </summary>
        /// <remarks>
        /// This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>Task of UserConnectionList</returns>
        System.Threading.Tasks.Task<UserConnectionList> V1ConnectionListGetAsync (string sessionToken, string status = null, string userIds = null);

        /// <summary>
        /// List of requesting user&#39;s connection
        /// </summary>
        /// <remarks>
        /// This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>Task of ApiResponse (UserConnectionList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserConnectionList>> V1ConnectionListGetAsyncWithHttpInfo (string sessionToken, string status = null, string userIds = null);
        /// <summary>
        /// Reject the connection request for the requesting user.
        /// </summary>
        /// <remarks>
        /// Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of UserConnection</returns>
        System.Threading.Tasks.Task<UserConnection> V1ConnectionRejectPostAsync (string sessionToken, UserConnectionRequest connectionRequest);

        /// <summary>
        /// Reject the connection request for the requesting user.
        /// </summary>
        /// <remarks>
        /// Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionRejectPostAsyncWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest);
        /// <summary>
        /// The status of the connection invitation to another user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>Task of UserConnection</returns>
        System.Threading.Tasks.Task<UserConnection> V1ConnectionUserUserIdInfoGetAsync (string sessionToken, string userId);

        /// <summary>
        /// The status of the connection invitation to another user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionUserUserIdInfoGetAsyncWithHttpInfo (string sessionToken, string userId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectionApi : IConnectionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConnectionApi(Configuration configuration = null)
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
        /// Accept the connection request for the requesting user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>UserConnection</returns>
        public UserConnection V1ConnectionAcceptPost (string sessionToken, UserConnectionRequest connectionRequest)
        {
             ApiResponse<UserConnection> localVarResponse = V1ConnectionAcceptPostWithHttpInfo(sessionToken, connectionRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Accept the connection request for the requesting user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>ApiResponse of UserConnection</returns>
        public ApiResponse< UserConnection > V1ConnectionAcceptPostWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionAcceptPost");
            // verify the required parameter 'connectionRequest' is set
            if (connectionRequest == null)
                throw new ApiException(400, "Missing required parameter 'connectionRequest' when calling ConnectionApi->V1ConnectionAcceptPost");

            var localVarPath = "/v1/connection/accept";
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
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (connectionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(connectionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = connectionRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionAcceptPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionAcceptPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

        /// <summary>
        /// Accept the connection request for the requesting user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of UserConnection</returns>
        public async System.Threading.Tasks.Task<UserConnection> V1ConnectionAcceptPostAsync (string sessionToken, UserConnectionRequest connectionRequest)
        {
             ApiResponse<UserConnection> localVarResponse = await V1ConnectionAcceptPostAsyncWithHttpInfo(sessionToken, connectionRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Accept the connection request for the requesting user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionAcceptPostAsyncWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionAcceptPost");
            // verify the required parameter 'connectionRequest' is set
            if (connectionRequest == null)
                throw new ApiException(400, "Missing required parameter 'connectionRequest' when calling ConnectionApi->V1ConnectionAcceptPost");

            var localVarPath = "/v1/connection/accept";
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
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (connectionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(connectionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = connectionRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionAcceptPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionAcceptPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

        /// <summary>
        /// Sends an invitation to connect with another user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>UserConnection</returns>
        public UserConnection V1ConnectionCreatePost (string sessionToken, UserConnectionRequest connectionRequest)
        {
             ApiResponse<UserConnection> localVarResponse = V1ConnectionCreatePostWithHttpInfo(sessionToken, connectionRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sends an invitation to connect with another user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>ApiResponse of UserConnection</returns>
        public ApiResponse< UserConnection > V1ConnectionCreatePostWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionCreatePost");
            // verify the required parameter 'connectionRequest' is set
            if (connectionRequest == null)
                throw new ApiException(400, "Missing required parameter 'connectionRequest' when calling ConnectionApi->V1ConnectionCreatePost");

            var localVarPath = "/v1/connection/create";
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
            if (connectionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(connectionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = connectionRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

        /// <summary>
        /// Sends an invitation to connect with another user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of UserConnection</returns>
        public async System.Threading.Tasks.Task<UserConnection> V1ConnectionCreatePostAsync (string sessionToken, UserConnectionRequest connectionRequest)
        {
             ApiResponse<UserConnection> localVarResponse = await V1ConnectionCreatePostAsyncWithHttpInfo(sessionToken, connectionRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sends an invitation to connect with another user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionCreatePostAsyncWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionCreatePost");
            // verify the required parameter 'connectionRequest' is set
            if (connectionRequest == null)
                throw new ApiException(400, "Missing required parameter 'connectionRequest' when calling ConnectionApi->V1ConnectionCreatePost");

            var localVarPath = "/v1/connection/create";
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
            if (connectionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(connectionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = connectionRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

        /// <summary>
        /// List of requesting user&#39;s connection This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>UserConnectionList</returns>
        public UserConnectionList V1ConnectionListGet (string sessionToken, string status = null, string userIds = null)
        {
             ApiResponse<UserConnectionList> localVarResponse = V1ConnectionListGetWithHttpInfo(sessionToken, status, userIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of requesting user&#39;s connection This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>ApiResponse of UserConnectionList</returns>
        public ApiResponse< UserConnectionList > V1ConnectionListGetWithHttpInfo (string sessionToken, string status = null, string userIds = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionListGet");

            var localVarPath = "/v1/connection/list";
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (userIds != null) localVarQueryParams.Add("userIds", Configuration.ApiClient.ParameterToString(userIds)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnectionList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnectionList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnectionList)));
            
        }

        /// <summary>
        /// List of requesting user&#39;s connection This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>Task of UserConnectionList</returns>
        public async System.Threading.Tasks.Task<UserConnectionList> V1ConnectionListGetAsync (string sessionToken, string status = null, string userIds = null)
        {
             ApiResponse<UserConnectionList> localVarResponse = await V1ConnectionListGetAsyncWithHttpInfo(sessionToken, status, userIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of requesting user&#39;s connection This retrieves all connections of the requesting user. (i.e. both connections in which the requesting user is the sender and those\nin which the requesting user is the inivtee) By default, if you haven&#39;t specified the connection status to filter on, this call will only\nreturn results for both \&quot;pending_incoming\&quot; and \&quot;pending_outgoing\&quot;. You can optionally filter by userIds to further restrict the results of\na specific connection status. If the users are in the same private pod, the users have an implicit connection status of \&quot;accepted\&quot;. Those\nusers will not be returned in the response if you don&#39;t specify the connection status as \&quot;accepted\&quot; (default is \&quot;pending\&quot;)\nand the explicit userIds in the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="status">Filter the connection list based on the connection status.\nThe connection status can only be pending_incoming, pending_outgoing, accepted, rejected, or all (all of the above)\n (optional)</param>
        /// <param name="userIds">The userIds parameter should be specified as a comma delimited list of user ids and can be used to restrict the results of a specific connection.\nNote that this is particularly important if the caller intends to retrieve results for implicit connection (user within the same pod).\nImplicit connections will not be included in the response if userId is not provided.\n (optional)</param>
        /// <returns>Task of ApiResponse (UserConnectionList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserConnectionList>> V1ConnectionListGetAsyncWithHttpInfo (string sessionToken, string status = null, string userIds = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionListGet");

            var localVarPath = "/v1/connection/list";
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (userIds != null) localVarQueryParams.Add("userIds", Configuration.ApiClient.ParameterToString(userIds)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnectionList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnectionList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnectionList)));
            
        }

        /// <summary>
        /// Reject the connection request for the requesting user. Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>UserConnection</returns>
        public UserConnection V1ConnectionRejectPost (string sessionToken, UserConnectionRequest connectionRequest)
        {
             ApiResponse<UserConnection> localVarResponse = V1ConnectionRejectPostWithHttpInfo(sessionToken, connectionRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reject the connection request for the requesting user. Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>ApiResponse of UserConnection</returns>
        public ApiResponse< UserConnection > V1ConnectionRejectPostWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionRejectPost");
            // verify the required parameter 'connectionRequest' is set
            if (connectionRequest == null)
                throw new ApiException(400, "Missing required parameter 'connectionRequest' when calling ConnectionApi->V1ConnectionRejectPost");

            var localVarPath = "/v1/connection/reject";
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
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (connectionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(connectionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = connectionRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionRejectPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionRejectPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

        /// <summary>
        /// Reject the connection request for the requesting user. Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of UserConnection</returns>
        public async System.Threading.Tasks.Task<UserConnection> V1ConnectionRejectPostAsync (string sessionToken, UserConnectionRequest connectionRequest)
        {
             ApiResponse<UserConnection> localVarResponse = await V1ConnectionRejectPostAsyncWithHttpInfo(sessionToken, connectionRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reject the connection request for the requesting user. Reject the connection between the requesting user and request sender. If both users are in the same private pod,\nan error will be returned because both users have an implicit connection which cannot be rejected.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="connectionRequest"></param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionRejectPostAsyncWithHttpInfo (string sessionToken, UserConnectionRequest connectionRequest)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionRejectPost");
            // verify the required parameter 'connectionRequest' is set
            if (connectionRequest == null)
                throw new ApiException(400, "Missing required parameter 'connectionRequest' when calling ConnectionApi->V1ConnectionRejectPost");

            var localVarPath = "/v1/connection/reject";
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
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (connectionRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(connectionRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = connectionRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionRejectPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionRejectPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

        /// <summary>
        /// The status of the connection invitation to another user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>UserConnection</returns>
        public UserConnection V1ConnectionUserUserIdInfoGet (string sessionToken, string userId)
        {
             ApiResponse<UserConnection> localVarResponse = V1ConnectionUserUserIdInfoGetWithHttpInfo(sessionToken, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// The status of the connection invitation to another user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>ApiResponse of UserConnection</returns>
        public ApiResponse< UserConnection > V1ConnectionUserUserIdInfoGetWithHttpInfo (string sessionToken, string userId)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionUserUserIdInfoGet");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ConnectionApi->V1ConnectionUserUserIdInfoGet");

            var localVarPath = "/v1/connection/user/{userId}/info";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionUserUserIdInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionUserUserIdInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

        /// <summary>
        /// The status of the connection invitation to another user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>Task of UserConnection</returns>
        public async System.Threading.Tasks.Task<UserConnection> V1ConnectionUserUserIdInfoGetAsync (string sessionToken, string userId)
        {
             ApiResponse<UserConnection> localVarResponse = await V1ConnectionUserUserIdInfoGetAsyncWithHttpInfo(sessionToken, userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// The status of the connection invitation to another user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="userId">user Id</param>
        /// <returns>Task of ApiResponse (UserConnection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserConnection>> V1ConnectionUserUserIdInfoGetAsyncWithHttpInfo (string sessionToken, string userId)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConnectionApi->V1ConnectionUserUserIdInfoGet");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ConnectionApi->V1ConnectionUserUserIdInfoGet");

            var localVarPath = "/v1/connection/user/{userId}/info";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionUserUserIdInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConnectionUserUserIdInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserConnection)));
            
        }

    }
}
