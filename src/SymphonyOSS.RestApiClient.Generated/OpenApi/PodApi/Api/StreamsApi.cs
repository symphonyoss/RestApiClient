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
    public interface IStreamsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new single or multi party instant message conversation
        /// </summary>
        /// <remarks>
        /// At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Stream</returns>
        Stream V1ImCreatePost (UserIdList uidList, string sessionToken);

        /// <summary>
        /// Create a new single or multi party instant message conversation
        /// </summary>
        /// <remarks>
        /// At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of Stream</returns>
        ApiResponse<Stream> V1ImCreatePostWithHttpInfo (UserIdList uidList, string sessionToken);
        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        RoomDetail V1RoomCreatePost (RoomCreate payload, string sessionToken);

        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        ApiResponse<RoomDetail> V1RoomCreatePostWithHttpInfo (RoomCreate payload, string sessionToken);
        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        RoomDetail V1RoomIdInfoGet (string id, string sessionToken);

        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        ApiResponse<RoomDetail> V1RoomIdInfoGetWithHttpInfo (string id, string sessionToken);
        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        RoomDetail V1RoomIdSetActivePost (string id, bool? active, string sessionToken);

        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        ApiResponse<RoomDetail> V1RoomIdSetActivePostWithHttpInfo (string id, bool? active, string sessionToken);
        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        RoomDetail V1RoomIdUpdatePost (string id, RoomAttributes payload, string sessionToken);

        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        ApiResponse<RoomDetail> V1RoomIdUpdatePostWithHttpInfo (string id, RoomAttributes payload, string sessionToken);
        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V2RoomDetail</returns>
        V2RoomDetail V2RoomCreatePost (V2RoomAttributes payload, string sessionToken);

        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V2RoomDetail</returns>
        ApiResponse<V2RoomDetail> V2RoomCreatePostWithHttpInfo (V2RoomAttributes payload, string sessionToken);
        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V2RoomDetail</returns>
        V2RoomDetail V2RoomIdInfoGet (string id, string sessionToken);

        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V2RoomDetail</returns>
        ApiResponse<V2RoomDetail> V2RoomIdInfoGetWithHttpInfo (string id, string sessionToken);
        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V2RoomDetail</returns>
        V2RoomDetail V2RoomIdUpdatePost (string id, V2RoomAttributes payload, string sessionToken);

        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V2RoomDetail</returns>
        ApiResponse<V2RoomDetail> V2RoomIdUpdatePostWithHttpInfo (string id, V2RoomAttributes payload, string sessionToken);
        /// <summary>
        /// Search rooms according to the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>RoomSearchResults</returns>
        RoomSearchResults V2RoomSearchPost (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null);

        /// <summary>
        /// Search rooms according to the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of RoomSearchResults</returns>
        ApiResponse<RoomSearchResults> V2RoomSearchPostWithHttpInfo (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a new single or multi party instant message conversation
        /// </summary>
        /// <remarks>
        /// At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> V1ImCreatePostAsync (UserIdList uidList, string sessionToken);

        /// <summary>
        /// Create a new single or multi party instant message conversation
        /// </summary>
        /// <remarks>
        /// At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> V1ImCreatePostAsyncWithHttpInfo (UserIdList uidList, string sessionToken);
        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        System.Threading.Tasks.Task<RoomDetail> V1RoomCreatePostAsync (RoomCreate payload, string sessionToken);

        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomCreatePostAsyncWithHttpInfo (RoomCreate payload, string sessionToken);
        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        System.Threading.Tasks.Task<RoomDetail> V1RoomIdInfoGetAsync (string id, string sessionToken);

        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomIdInfoGetAsyncWithHttpInfo (string id, string sessionToken);
        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        System.Threading.Tasks.Task<RoomDetail> V1RoomIdSetActivePostAsync (string id, bool? active, string sessionToken);

        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomIdSetActivePostAsyncWithHttpInfo (string id, bool? active, string sessionToken);
        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        System.Threading.Tasks.Task<RoomDetail> V1RoomIdUpdatePostAsync (string id, RoomAttributes payload, string sessionToken);

        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomIdUpdatePostAsyncWithHttpInfo (string id, RoomAttributes payload, string sessionToken);
        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V2RoomDetail</returns>
        System.Threading.Tasks.Task<V2RoomDetail> V2RoomCreatePostAsync (V2RoomAttributes payload, string sessionToken);

        /// <summary>
        /// Create a new chatroom.
        /// </summary>
        /// <remarks>
        /// Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V2RoomDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<V2RoomDetail>> V2RoomCreatePostAsyncWithHttpInfo (V2RoomAttributes payload, string sessionToken);
        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V2RoomDetail</returns>
        System.Threading.Tasks.Task<V2RoomDetail> V2RoomIdInfoGetAsync (string id, string sessionToken);

        /// <summary>
        /// Get information about a partcular chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V2RoomDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<V2RoomDetail>> V2RoomIdInfoGetAsyncWithHttpInfo (string id, string sessionToken);
        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V2RoomDetail</returns>
        System.Threading.Tasks.Task<V2RoomDetail> V2RoomIdUpdatePostAsync (string id, V2RoomAttributes payload, string sessionToken);

        /// <summary>
        /// Update the attributes of an existing chatroom.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V2RoomDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<V2RoomDetail>> V2RoomIdUpdatePostAsyncWithHttpInfo (string id, V2RoomAttributes payload, string sessionToken);
        /// <summary>
        /// Search rooms according to the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of RoomSearchResults</returns>
        System.Threading.Tasks.Task<RoomSearchResults> V2RoomSearchPostAsync (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null);

        /// <summary>
        /// Search rooms according to the specified criteria.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (RoomSearchResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomSearchResults>> V2RoomSearchPostAsyncWithHttpInfo (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StreamsApi : IStreamsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StreamsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StreamsApi(Configuration configuration = null)
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
        /// Create a new single or multi party instant message conversation At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Stream</returns>
        public Stream V1ImCreatePost (UserIdList uidList, string sessionToken)
        {
             ApiResponse<Stream> localVarResponse = V1ImCreatePostWithHttpInfo(uidList, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new single or multi party instant message conversation At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of Stream</returns>
        public ApiResponse< Stream > V1ImCreatePostWithHttpInfo (UserIdList uidList, string sessionToken)
        {
            // verify the required parameter 'uidList' is set
            if (uidList == null)
                throw new ApiException(400, "Missing required parameter 'uidList' when calling StreamsApi->V1ImCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1ImCreatePost");

            var localVarPath = "/v1/im/create";
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
            if (uidList.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(uidList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = uidList; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ImCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ImCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stream)));
            
        }

        /// <summary>
        /// Create a new single or multi party instant message conversation At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> V1ImCreatePostAsync (UserIdList uidList, string sessionToken)
        {
             ApiResponse<Stream> localVarResponse = await V1ImCreatePostAsyncWithHttpInfo(uidList, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new single or multi party instant message conversation At least one user ID must be provided or\nan error response will be sent.\n\nThe caller is implicitly included in the members of the\ncreated chat.\n\nDuplicate users will be included in the membership of the chat but\nthe duplication will be silently ignored.\n\nIf there is an existing IM conversation with the same set of participants then\nthe id of that existing stream will be returned.\n\nThis method was incorrectly specified to take a query parameter in\nversion 1.0 of this specification but now expects a JSON array of\nuser IDs in the body of the request.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uidList">List of (integer) User IDs of participants</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> V1ImCreatePostAsyncWithHttpInfo (UserIdList uidList, string sessionToken)
        {
            // verify the required parameter 'uidList' is set
            if (uidList == null)
                throw new ApiException(400, "Missing required parameter 'uidList' when calling StreamsApi->V1ImCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1ImCreatePost");

            var localVarPath = "/v1/im/create";
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
            if (uidList.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(uidList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = uidList; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ImCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ImCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stream)));
            
        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        public RoomDetail V1RoomCreatePost (RoomCreate payload, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = V1RoomCreatePostWithHttpInfo(payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        public ApiResponse< RoomDetail > V1RoomCreatePostWithHttpInfo (RoomCreate payload, string sessionToken)
        {
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V1RoomCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomCreatePost");

            var localVarPath = "/v1/room/create";
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
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        public async System.Threading.Tasks.Task<RoomDetail> V1RoomCreatePostAsync (RoomCreate payload, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = await V1RoomCreatePostAsyncWithHttpInfo(payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no attributes are specified, the room is created as a private chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomCreatePostAsyncWithHttpInfo (RoomCreate payload, string sessionToken)
        {
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V1RoomCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomCreatePost");

            var localVarPath = "/v1/room/create";
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
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        public RoomDetail V1RoomIdInfoGet (string id, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = V1RoomIdInfoGetWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        public ApiResponse< RoomDetail > V1RoomIdInfoGetWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V1RoomIdInfoGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomIdInfoGet");

            var localVarPath = "/v1/room/{id}/info";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        public async System.Threading.Tasks.Task<RoomDetail> V1RoomIdInfoGetAsync (string id, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = await V1RoomIdInfoGetAsyncWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomIdInfoGetAsyncWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V1RoomIdInfoGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomIdInfoGet");

            var localVarPath = "/v1/room/{id}/info";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        public RoomDetail V1RoomIdSetActivePost (string id, bool? active, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = V1RoomIdSetActivePostWithHttpInfo(id, active, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        public ApiResponse< RoomDetail > V1RoomIdSetActivePostWithHttpInfo (string id, bool? active, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V1RoomIdSetActivePost");
            // verify the required parameter 'active' is set
            if (active == null)
                throw new ApiException(400, "Missing required parameter 'active' when calling StreamsApi->V1RoomIdSetActivePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomIdSetActivePost");

            var localVarPath = "/v1/room/{id}/setActive";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdSetActivePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdSetActivePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        public async System.Threading.Tasks.Task<RoomDetail> V1RoomIdSetActivePostAsync (string id, bool? active, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = await V1RoomIdSetActivePostAsyncWithHttpInfo(id, active, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivate or reactivate a chatroom. At creation, a new chatroom is active. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="active"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomIdSetActivePostAsyncWithHttpInfo (string id, bool? active, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V1RoomIdSetActivePost");
            // verify the required parameter 'active' is set
            if (active == null)
                throw new ApiException(400, "Missing required parameter 'active' when calling StreamsApi->V1RoomIdSetActivePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomIdSetActivePost");

            var localVarPath = "/v1/room/{id}/setActive";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdSetActivePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdSetActivePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>RoomDetail</returns>
        public RoomDetail V1RoomIdUpdatePost (string id, RoomAttributes payload, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = V1RoomIdUpdatePostWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of RoomDetail</returns>
        public ApiResponse< RoomDetail > V1RoomIdUpdatePostWithHttpInfo (string id, RoomAttributes payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V1RoomIdUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V1RoomIdUpdatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomIdUpdatePost");

            var localVarPath = "/v1/room/{id}/update";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of RoomDetail</returns>
        public async System.Threading.Tasks.Task<RoomDetail> V1RoomIdUpdatePostAsync (string id, RoomAttributes payload, string sessionToken)
        {
             ApiResponse<RoomDetail> localVarResponse = await V1RoomIdUpdatePostAsyncWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (RoomDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoomDetail>> V1RoomIdUpdatePostAsyncWithHttpInfo (string id, RoomAttributes payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V1RoomIdUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V1RoomIdUpdatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V1RoomIdUpdatePost");

            var localVarPath = "/v1/room/{id}/update";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomDetail)));
            
        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V2RoomDetail</returns>
        public V2RoomDetail V2RoomCreatePost (V2RoomAttributes payload, string sessionToken)
        {
             ApiResponse<V2RoomDetail> localVarResponse = V2RoomCreatePostWithHttpInfo(payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V2RoomDetail</returns>
        public ApiResponse< V2RoomDetail > V2RoomCreatePostWithHttpInfo (V2RoomAttributes payload, string sessionToken)
        {
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V2RoomCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomCreatePost");

            var localVarPath = "/v2/room/create";
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
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2RoomDetail)));
            
        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V2RoomDetail</returns>
        public async System.Threading.Tasks.Task<V2RoomDetail> V2RoomCreatePostAsync (V2RoomAttributes payload, string sessionToken)
        {
             ApiResponse<V2RoomDetail> localVarResponse = await V2RoomCreatePostAsyncWithHttpInfo(payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new chatroom. Create a new chatroom.\n\nIf no  attributes are specified, the room is created as a public chatroom.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V2RoomDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V2RoomDetail>> V2RoomCreatePostAsyncWithHttpInfo (V2RoomAttributes payload, string sessionToken)
        {
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V2RoomCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomCreatePost");

            var localVarPath = "/v2/room/create";
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
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2RoomDetail)));
            
        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V2RoomDetail</returns>
        public V2RoomDetail V2RoomIdInfoGet (string id, string sessionToken)
        {
             ApiResponse<V2RoomDetail> localVarResponse = V2RoomIdInfoGetWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V2RoomDetail</returns>
        public ApiResponse< V2RoomDetail > V2RoomIdInfoGetWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V2RoomIdInfoGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomIdInfoGet");

            var localVarPath = "/v2/room/{id}/info";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2RoomDetail)));
            
        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V2RoomDetail</returns>
        public async System.Threading.Tasks.Task<V2RoomDetail> V2RoomIdInfoGetAsync (string id, string sessionToken)
        {
             ApiResponse<V2RoomDetail> localVarResponse = await V2RoomIdInfoGetAsyncWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about a partcular chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V2RoomDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V2RoomDetail>> V2RoomIdInfoGetAsyncWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V2RoomIdInfoGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomIdInfoGet");

            var localVarPath = "/v2/room/{id}/info";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2RoomDetail)));
            
        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V2RoomDetail</returns>
        public V2RoomDetail V2RoomIdUpdatePost (string id, V2RoomAttributes payload, string sessionToken)
        {
             ApiResponse<V2RoomDetail> localVarResponse = V2RoomIdUpdatePostWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V2RoomDetail</returns>
        public ApiResponse< V2RoomDetail > V2RoomIdUpdatePostWithHttpInfo (string id, V2RoomAttributes payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V2RoomIdUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V2RoomIdUpdatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomIdUpdatePost");

            var localVarPath = "/v2/room/{id}/update";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2RoomDetail)));
            
        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V2RoomDetail</returns>
        public async System.Threading.Tasks.Task<V2RoomDetail> V2RoomIdUpdatePostAsync (string id, V2RoomAttributes payload, string sessionToken)
        {
             ApiResponse<V2RoomDetail> localVarResponse = await V2RoomIdUpdatePostAsyncWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of an existing chatroom. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V2RoomDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V2RoomDetail>> V2RoomIdUpdatePostAsyncWithHttpInfo (string id, V2RoomAttributes payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StreamsApi->V2RoomIdUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling StreamsApi->V2RoomIdUpdatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomIdUpdatePost");

            var localVarPath = "/v2/room/{id}/update";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomIdUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V2RoomDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V2RoomDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V2RoomDetail)));
            
        }

        /// <summary>
        /// Search rooms according to the specified criteria. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>RoomSearchResults</returns>
        public RoomSearchResults V2RoomSearchPost (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null)
        {
             ApiResponse<RoomSearchResults> localVarResponse = V2RoomSearchPostWithHttpInfo(sessionToken, query, skip, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search rooms according to the specified criteria. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of RoomSearchResults</returns>
        public ApiResponse< RoomSearchResults > V2RoomSearchPostWithHttpInfo (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomSearchPost");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling StreamsApi->V2RoomSearchPost");

            var localVarPath = "/v2/room/search";
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
            if (skip != null) localVarQueryParams.Add("skip", Configuration.ApiClient.ParameterToString(skip)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (query.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomSearchPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomSearchPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomSearchResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomSearchResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomSearchResults)));
            
        }

        /// <summary>
        /// Search rooms according to the specified criteria. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of RoomSearchResults</returns>
        public async System.Threading.Tasks.Task<RoomSearchResults> V2RoomSearchPostAsync (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null)
        {
             ApiResponse<RoomSearchResults> localVarResponse = await V2RoomSearchPostAsyncWithHttpInfo(sessionToken, query, skip, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search rooms according to the specified criteria. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="query">The search query object.</param>
        /// <param name="skip">No. of results to skip.\n (optional)</param>
        /// <param name="limit">Max no. of results to return. If no value is provided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (RoomSearchResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoomSearchResults>> V2RoomSearchPostAsyncWithHttpInfo (string sessionToken, RoomSearchCriteria query, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling StreamsApi->V2RoomSearchPost");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling StreamsApi->V2RoomSearchPost");

            var localVarPath = "/v2/room/search";
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
            if (skip != null) localVarQueryParams.Add("skip", Configuration.ApiClient.ParameterToString(skip)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (query.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomSearchPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V2RoomSearchPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoomSearchResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoomSearchResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoomSearchResults)));
            
        }

    }
}
