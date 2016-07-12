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
    public interface ISystemApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Checks the health of the Agent.
        /// </summary>
        /// <remarks>
        /// Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>V1HealthCheckResponse</returns>
        V1HealthCheckResponse V1HealthCheckGet ();

        /// <summary>
        /// Checks the health of the Agent.
        /// </summary>
        /// <remarks>
        /// Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of V1HealthCheckResponse</returns>
        ApiResponse<V1HealthCheckResponse> V1HealthCheckGetWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Checks the health of the Agent.
        /// </summary>
        /// <remarks>
        /// Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of V1HealthCheckResponse</returns>
        System.Threading.Tasks.Task<V1HealthCheckResponse> V1HealthCheckGetAsync ();

        /// <summary>
        /// Checks the health of the Agent.
        /// </summary>
        /// <remarks>
        /// Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (V1HealthCheckResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1HealthCheckResponse>> V1HealthCheckGetAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SystemApi : ISystemApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemApi(Configuration configuration = null)
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
        /// Checks the health of the Agent. Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>V1HealthCheckResponse</returns>
        public V1HealthCheckResponse V1HealthCheckGet ()
        {
             ApiResponse<V1HealthCheckResponse> localVarResponse = V1HealthCheckGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Checks the health of the Agent. Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of V1HealthCheckResponse</returns>
        public ApiResponse< V1HealthCheckResponse > V1HealthCheckGetWithHttpInfo ()
        {

            var localVarPath = "/v1/HealthCheck";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1HealthCheckGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1HealthCheckGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1HealthCheckResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1HealthCheckResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1HealthCheckResponse)));
            
        }

        /// <summary>
        /// Checks the health of the Agent. Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of V1HealthCheckResponse</returns>
        public async System.Threading.Tasks.Task<V1HealthCheckResponse> V1HealthCheckGetAsync ()
        {
             ApiResponse<V1HealthCheckResponse> localVarResponse = await V1HealthCheckGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Checks the health of the Agent. Used to validate the configuration of the agent.\nMakes a request to the HealthCheck on the Symphony cloud.\nMakes a request to the HealthCheck on the Key Manager service.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (V1HealthCheckResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1HealthCheckResponse>> V1HealthCheckGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/HealthCheck";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1HealthCheckGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1HealthCheckGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1HealthCheckResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1HealthCheckResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1HealthCheckResponse)));
            
        }

    }
}
