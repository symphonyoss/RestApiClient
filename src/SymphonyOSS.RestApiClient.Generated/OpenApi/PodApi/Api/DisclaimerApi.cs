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
    public interface IDisclaimerApi
    {
        #region Synchronous Operations
        /// <summary>
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Disclaimer</returns>
        Disclaimer V1AdminDisclaimerCreatePost (string sessionToken, Disclaimer payload);

        /// <summary>
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of Disclaimer</returns>
        ApiResponse<Disclaimer> V1AdminDisclaimerCreatePostWithHttpInfo (string sessionToken, Disclaimer payload);
        /// <summary>
        /// Get a disclaimer by disclaimer id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Disclaimer</returns>
        Disclaimer V1AdminDisclaimerDidGet (string sessionToken, string did);

        /// <summary>
        /// Get a disclaimer by disclaimer id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>ApiResponse of Disclaimer</returns>
        ApiResponse<Disclaimer> V1AdminDisclaimerDidGetWithHttpInfo (string sessionToken, string did);
        /// <summary>
        /// PROVISIONAL Modify a disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>Disclaimer</returns>
        Disclaimer V1AdminDisclaimerDidUpdatePost (string sessionToken, string did, Disclaimer payload);

        /// <summary>
        /// PROVISIONAL Modify a disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of Disclaimer</returns>
        ApiResponse<Disclaimer> V1AdminDisclaimerDidUpdatePostWithHttpInfo (string sessionToken, string did, Disclaimer payload);
        /// <summary>
        /// List all users assigned to this disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>UserIdList</returns>
        UserIdList V1AdminDisclaimerDidUsersGet (string sessionToken, string did);

        /// <summary>
        /// List all users assigned to this disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>ApiResponse of UserIdList</returns>
        ApiResponse<UserIdList> V1AdminDisclaimerDidUsersGetWithHttpInfo (string sessionToken, string did);
        /// <summary>
        /// List all disclaimers for the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>DisclaimerList</returns>
        DisclaimerList V1AdminDisclaimerListGet (string sessionToken);

        /// <summary>
        /// List all disclaimers for the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of DisclaimerList</returns>
        ApiResponse<DisclaimerList> V1AdminDisclaimerListGetWithHttpInfo (string sessionToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of Disclaimer</returns>
        System.Threading.Tasks.Task<Disclaimer> V1AdminDisclaimerCreatePostAsync (string sessionToken, Disclaimer payload);

        /// <summary>
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminDisclaimerCreatePostAsyncWithHttpInfo (string sessionToken, Disclaimer payload);
        /// <summary>
        /// Get a disclaimer by disclaimer id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of Disclaimer</returns>
        System.Threading.Tasks.Task<Disclaimer> V1AdminDisclaimerDidGetAsync (string sessionToken, string did);

        /// <summary>
        /// Get a disclaimer by disclaimer id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminDisclaimerDidGetAsyncWithHttpInfo (string sessionToken, string did);
        /// <summary>
        /// PROVISIONAL Modify a disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>Task of Disclaimer</returns>
        System.Threading.Tasks.Task<Disclaimer> V1AdminDisclaimerDidUpdatePostAsync (string sessionToken, string did, Disclaimer payload);

        /// <summary>
        /// PROVISIONAL Modify a disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminDisclaimerDidUpdatePostAsyncWithHttpInfo (string sessionToken, string did, Disclaimer payload);
        /// <summary>
        /// List all users assigned to this disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of UserIdList</returns>
        System.Threading.Tasks.Task<UserIdList> V1AdminDisclaimerDidUsersGetAsync (string sessionToken, string did);

        /// <summary>
        /// List all users assigned to this disclaimer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of ApiResponse (UserIdList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserIdList>> V1AdminDisclaimerDidUsersGetAsyncWithHttpInfo (string sessionToken, string did);
        /// <summary>
        /// List all disclaimers for the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of DisclaimerList</returns>
        System.Threading.Tasks.Task<DisclaimerList> V1AdminDisclaimerListGetAsync (string sessionToken);

        /// <summary>
        /// List all disclaimers for the company (pod)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (DisclaimerList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DisclaimerList>> V1AdminDisclaimerListGetAsyncWithHttpInfo (string sessionToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DisclaimerApi : IDisclaimerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisclaimerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DisclaimerApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisclaimerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DisclaimerApi(Configuration configuration = null)
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
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Disclaimer</returns>
        public Disclaimer V1AdminDisclaimerCreatePost (string sessionToken, Disclaimer payload)
        {
             ApiResponse<Disclaimer> localVarResponse = V1AdminDisclaimerCreatePostWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of Disclaimer</returns>
        public ApiResponse< Disclaimer > V1AdminDisclaimerCreatePostWithHttpInfo (string sessionToken, Disclaimer payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerCreatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling DisclaimerApi->V1AdminDisclaimerCreatePost");

            var localVarPath = "/v1/admin/disclaimer/create";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of Disclaimer</returns>
        public async System.Threading.Tasks.Task<Disclaimer> V1AdminDisclaimerCreatePostAsync (string sessionToken, Disclaimer payload)
        {
             ApiResponse<Disclaimer> localVarResponse = await V1AdminDisclaimerCreatePostAsyncWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL Create a new disclaimer. The id and timestamps should not be set, they will be assigned in the response. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminDisclaimerCreatePostAsyncWithHttpInfo (string sessionToken, Disclaimer payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerCreatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling DisclaimerApi->V1AdminDisclaimerCreatePost");

            var localVarPath = "/v1/admin/disclaimer/create";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// Get a disclaimer by disclaimer id 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Disclaimer</returns>
        public Disclaimer V1AdminDisclaimerDidGet (string sessionToken, string did)
        {
             ApiResponse<Disclaimer> localVarResponse = V1AdminDisclaimerDidGetWithHttpInfo(sessionToken, did);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a disclaimer by disclaimer id 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>ApiResponse of Disclaimer</returns>
        public ApiResponse< Disclaimer > V1AdminDisclaimerDidGetWithHttpInfo (string sessionToken, string did)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerDidGet");
            // verify the required parameter 'did' is set
            if (did == null)
                throw new ApiException(400, "Missing required parameter 'did' when calling DisclaimerApi->V1AdminDisclaimerDidGet");

            var localVarPath = "/v1/admin/disclaimer/{did}";
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
            if (did != null) localVarPathParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// Get a disclaimer by disclaimer id 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of Disclaimer</returns>
        public async System.Threading.Tasks.Task<Disclaimer> V1AdminDisclaimerDidGetAsync (string sessionToken, string did)
        {
             ApiResponse<Disclaimer> localVarResponse = await V1AdminDisclaimerDidGetAsyncWithHttpInfo(sessionToken, did);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a disclaimer by disclaimer id 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminDisclaimerDidGetAsyncWithHttpInfo (string sessionToken, string did)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerDidGet");
            // verify the required parameter 'did' is set
            if (did == null)
                throw new ApiException(400, "Missing required parameter 'did' when calling DisclaimerApi->V1AdminDisclaimerDidGet");

            var localVarPath = "/v1/admin/disclaimer/{did}";
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
            if (did != null) localVarPathParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// PROVISIONAL Modify a disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>Disclaimer</returns>
        public Disclaimer V1AdminDisclaimerDidUpdatePost (string sessionToken, string did, Disclaimer payload)
        {
             ApiResponse<Disclaimer> localVarResponse = V1AdminDisclaimerDidUpdatePostWithHttpInfo(sessionToken, did, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL Modify a disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of Disclaimer</returns>
        public ApiResponse< Disclaimer > V1AdminDisclaimerDidUpdatePostWithHttpInfo (string sessionToken, string did, Disclaimer payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerDidUpdatePost");
            // verify the required parameter 'did' is set
            if (did == null)
                throw new ApiException(400, "Missing required parameter 'did' when calling DisclaimerApi->V1AdminDisclaimerDidUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling DisclaimerApi->V1AdminDisclaimerDidUpdatePost");

            var localVarPath = "/v1/admin/disclaimer/{did}/update";
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
            if (did != null) localVarPathParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// PROVISIONAL Modify a disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>Task of Disclaimer</returns>
        public async System.Threading.Tasks.Task<Disclaimer> V1AdminDisclaimerDidUpdatePostAsync (string sessionToken, string did, Disclaimer payload)
        {
             ApiResponse<Disclaimer> localVarResponse = await V1AdminDisclaimerDidUpdatePostAsyncWithHttpInfo(sessionToken, did, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL Modify a disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (Disclaimer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Disclaimer>> V1AdminDisclaimerDidUpdatePostAsyncWithHttpInfo (string sessionToken, string did, Disclaimer payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerDidUpdatePost");
            // verify the required parameter 'did' is set
            if (did == null)
                throw new ApiException(400, "Missing required parameter 'did' when calling DisclaimerApi->V1AdminDisclaimerDidUpdatePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling DisclaimerApi->V1AdminDisclaimerDidUpdatePost");

            var localVarPath = "/v1/admin/disclaimer/{did}/update";
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
            if (did != null) localVarPathParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUpdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUpdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Disclaimer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Disclaimer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Disclaimer)));
            
        }

        /// <summary>
        /// List all users assigned to this disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>UserIdList</returns>
        public UserIdList V1AdminDisclaimerDidUsersGet (string sessionToken, string did)
        {
             ApiResponse<UserIdList> localVarResponse = V1AdminDisclaimerDidUsersGetWithHttpInfo(sessionToken, did);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all users assigned to this disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>ApiResponse of UserIdList</returns>
        public ApiResponse< UserIdList > V1AdminDisclaimerDidUsersGetWithHttpInfo (string sessionToken, string did)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerDidUsersGet");
            // verify the required parameter 'did' is set
            if (did == null)
                throw new ApiException(400, "Missing required parameter 'did' when calling DisclaimerApi->V1AdminDisclaimerDidUsersGet");

            var localVarPath = "/v1/admin/disclaimer/{did}/users";
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
            if (did != null) localVarPathParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserIdList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserIdList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserIdList)));
            
        }

        /// <summary>
        /// List all users assigned to this disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of UserIdList</returns>
        public async System.Threading.Tasks.Task<UserIdList> V1AdminDisclaimerDidUsersGetAsync (string sessionToken, string did)
        {
             ApiResponse<UserIdList> localVarResponse = await V1AdminDisclaimerDidUsersGetAsyncWithHttpInfo(sessionToken, did);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all users assigned to this disclaimer 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="did">The ID of the entity</param>
        /// <returns>Task of ApiResponse (UserIdList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserIdList>> V1AdminDisclaimerDidUsersGetAsyncWithHttpInfo (string sessionToken, string did)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerDidUsersGet");
            // verify the required parameter 'did' is set
            if (did == null)
                throw new ApiException(400, "Missing required parameter 'did' when calling DisclaimerApi->V1AdminDisclaimerDidUsersGet");

            var localVarPath = "/v1/admin/disclaimer/{did}/users";
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
            if (did != null) localVarPathParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerDidUsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserIdList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserIdList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserIdList)));
            
        }

        /// <summary>
        /// List all disclaimers for the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>DisclaimerList</returns>
        public DisclaimerList V1AdminDisclaimerListGet (string sessionToken)
        {
             ApiResponse<DisclaimerList> localVarResponse = V1AdminDisclaimerListGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all disclaimers for the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of DisclaimerList</returns>
        public ApiResponse< DisclaimerList > V1AdminDisclaimerListGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerListGet");

            var localVarPath = "/v1/admin/disclaimer/list";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DisclaimerList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DisclaimerList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DisclaimerList)));
            
        }

        /// <summary>
        /// List all disclaimers for the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of DisclaimerList</returns>
        public async System.Threading.Tasks.Task<DisclaimerList> V1AdminDisclaimerListGetAsync (string sessionToken)
        {
             ApiResponse<DisclaimerList> localVarResponse = await V1AdminDisclaimerListGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all disclaimers for the company (pod) 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (DisclaimerList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DisclaimerList>> V1AdminDisclaimerListGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling DisclaimerApi->V1AdminDisclaimerListGet");

            var localVarPath = "/v1/admin/disclaimer/list";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminDisclaimerListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DisclaimerList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DisclaimerList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DisclaimerList)));
            
        }

    }
}
