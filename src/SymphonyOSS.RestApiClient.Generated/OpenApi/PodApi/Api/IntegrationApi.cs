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
    public interface IIntegrationApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Checks the health of the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// Used to validate health of the Integration Bridge.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>IntegrationBridgeHealth</returns>
        IntegrationBridgeHealth V1IntegrationHealthCheckGet (string sessionToken);

        /// <summary>
        /// Checks the health of the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// Used to validate health of the Integration Bridge.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of IntegrationBridgeHealth</returns>
        ApiResponse<IntegrationBridgeHealth> V1IntegrationHealthCheckGetWithHttpInfo (string sessionToken);
        /// <summary>
        /// Get the information about the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>IntegrationInfo</returns>
        IntegrationInfo V1IntegrationInfoGet (string sessionToken);

        /// <summary>
        /// Get the information about the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of IntegrationInfo</returns>
        ApiResponse<IntegrationInfo> V1IntegrationInfoGetWithHttpInfo (string sessionToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Checks the health of the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// Used to validate health of the Integration Bridge.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of IntegrationBridgeHealth</returns>
        System.Threading.Tasks.Task<IntegrationBridgeHealth> V1IntegrationHealthCheckGetAsync (string sessionToken);

        /// <summary>
        /// Checks the health of the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// Used to validate health of the Integration Bridge.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (IntegrationBridgeHealth)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegrationBridgeHealth>> V1IntegrationHealthCheckGetAsyncWithHttpInfo (string sessionToken);
        /// <summary>
        /// Get the information about the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of IntegrationInfo</returns>
        System.Threading.Tasks.Task<IntegrationInfo> V1IntegrationInfoGetAsync (string sessionToken);

        /// <summary>
        /// Get the information about the Integration Bridge.
        /// </summary>
        /// <remarks>
        /// A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (IntegrationInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegrationInfo>> V1IntegrationInfoGetAsyncWithHttpInfo (string sessionToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IntegrationApi : IIntegrationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntegrationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IntegrationApi(Configuration configuration = null)
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
        /// Checks the health of the Integration Bridge. Used to validate health of the Integration Bridge.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>IntegrationBridgeHealth</returns>
        public IntegrationBridgeHealth V1IntegrationHealthCheckGet (string sessionToken)
        {
             ApiResponse<IntegrationBridgeHealth> localVarResponse = V1IntegrationHealthCheckGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Checks the health of the Integration Bridge. Used to validate health of the Integration Bridge.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of IntegrationBridgeHealth</returns>
        public ApiResponse< IntegrationBridgeHealth > V1IntegrationHealthCheckGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling IntegrationApi->V1IntegrationHealthCheckGet");

            var localVarPath = "/v1/integration/healthCheck";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationHealthCheckGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationHealthCheckGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationBridgeHealth>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegrationBridgeHealth) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationBridgeHealth)));
            
        }

        /// <summary>
        /// Checks the health of the Integration Bridge. Used to validate health of the Integration Bridge.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of IntegrationBridgeHealth</returns>
        public async System.Threading.Tasks.Task<IntegrationBridgeHealth> V1IntegrationHealthCheckGetAsync (string sessionToken)
        {
             ApiResponse<IntegrationBridgeHealth> localVarResponse = await V1IntegrationHealthCheckGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Checks the health of the Integration Bridge. Used to validate health of the Integration Bridge.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (IntegrationBridgeHealth)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegrationBridgeHealth>> V1IntegrationHealthCheckGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling IntegrationApi->V1IntegrationHealthCheckGet");

            var localVarPath = "/v1/integration/healthCheck";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationHealthCheckGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationHealthCheckGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationBridgeHealth>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegrationBridgeHealth) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationBridgeHealth)));
            
        }

        /// <summary>
        /// Get the information about the Integration Bridge. A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>IntegrationInfo</returns>
        public IntegrationInfo V1IntegrationInfoGet (string sessionToken)
        {
             ApiResponse<IntegrationInfo> localVarResponse = V1IntegrationInfoGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the information about the Integration Bridge. A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of IntegrationInfo</returns>
        public ApiResponse< IntegrationInfo > V1IntegrationInfoGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling IntegrationApi->V1IntegrationInfoGet");

            var localVarPath = "/v1/integration/info";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegrationInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationInfo)));
            
        }

        /// <summary>
        /// Get the information about the Integration Bridge. A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of IntegrationInfo</returns>
        public async System.Threading.Tasks.Task<IntegrationInfo> V1IntegrationInfoGetAsync (string sessionToken)
        {
             ApiResponse<IntegrationInfo> localVarResponse = await V1IntegrationInfoGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the information about the Integration Bridge. A caller can get information about the Integration Bridge.\n\nIf there is no information to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (IntegrationInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegrationInfo>> V1IntegrationInfoGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling IntegrationApi->V1IntegrationInfoGet");

            var localVarPath = "/v1/integration/info";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationInfoGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1IntegrationInfoGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegrationInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegrationInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegrationInfo)));
            
        }

    }
}
