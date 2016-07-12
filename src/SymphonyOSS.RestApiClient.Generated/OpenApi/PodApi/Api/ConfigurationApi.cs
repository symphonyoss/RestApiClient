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
    public interface IConfigurationApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Activates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1ConfigurationResponse</returns>
        V1ConfigurationResponse V1ConfigurationConfigurationIdActivatePost (string configurationId, string sessionToken);

        /// <summary>
        /// Activates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1ConfigurationResponse</returns>
        ApiResponse<V1ConfigurationResponse> V1ConfigurationConfigurationIdActivatePostWithHttpInfo (string configurationId, string sessionToken);
        /// <summary>
        /// Deactivates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1ConfigurationResponse</returns>
        V1ConfigurationResponse V1ConfigurationConfigurationIdDeactivatePost (string configurationId, string sessionToken);

        /// <summary>
        /// Deactivates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1ConfigurationResponse</returns>
        ApiResponse<V1ConfigurationResponse> V1ConfigurationConfigurationIdDeactivatePostWithHttpInfo (string configurationId, string sessionToken);
        /// <summary>
        /// Gets a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1Configuration</returns>
        V1Configuration V1ConfigurationConfigurationIdGetGet (string configurationId, string sessionToken);

        /// <summary>
        /// Gets a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1Configuration</returns>
        ApiResponse<V1Configuration> V1ConfigurationConfigurationIdGetGetWithHttpInfo (string configurationId, string sessionToken);
        /// <summary>
        /// Update a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>V1Configuration</returns>
        V1Configuration V1ConfigurationConfigurationIdUpdatePut (string configurationId, string sessionToken, V1Configuration configuration);

        /// <summary>
        /// Update a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>ApiResponse of V1Configuration</returns>
        ApiResponse<V1Configuration> V1ConfigurationConfigurationIdUpdatePutWithHttpInfo (string configurationId, string sessionToken, V1Configuration configuration);
        /// <summary>
        /// Create a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration object.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>V1Configuration</returns>
        V1Configuration V1ConfigurationCreatePost (string sessionToken, V1ConfigurationSubmissionCreate configuration);

        /// <summary>
        /// Create a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration object.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>ApiResponse of V1Configuration</returns>
        ApiResponse<V1Configuration> V1ConfigurationCreatePostWithHttpInfo (string sessionToken, V1ConfigurationSubmissionCreate configuration);
        /// <summary>
        /// Gets a list of Configurations.
        /// </summary>
        /// <remarks>
        /// A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>ConfigurationList</returns>
        ConfigurationList V1ConfigurationListGet (string sessionToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Gets a list of Configurations.
        /// </summary>
        /// <remarks>
        /// A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of ConfigurationList</returns>
        ApiResponse<ConfigurationList> V1ConfigurationListGetWithHttpInfo (string sessionToken, int? offset = null, int? limit = null);
        /// <summary>
        /// Gets a Configuration object by configuration type.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1Configuration</returns>
        V1Configuration V1ConfigurationTypeConfigurationTypeGetGet (string configurationType, string sessionToken);

        /// <summary>
        /// Gets a Configuration object by configuration type.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1Configuration</returns>
        ApiResponse<V1Configuration> V1ConfigurationTypeConfigurationTypeGetGetWithHttpInfo (string configurationType, string sessionToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Activates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1ConfigurationResponse</returns>
        System.Threading.Tasks.Task<V1ConfigurationResponse> V1ConfigurationConfigurationIdActivatePostAsync (string configurationId, string sessionToken);

        /// <summary>
        /// Activates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1ConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1ConfigurationResponse>> V1ConfigurationConfigurationIdActivatePostAsyncWithHttpInfo (string configurationId, string sessionToken);
        /// <summary>
        /// Deactivates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1ConfigurationResponse</returns>
        System.Threading.Tasks.Task<V1ConfigurationResponse> V1ConfigurationConfigurationIdDeactivatePostAsync (string configurationId, string sessionToken);

        /// <summary>
        /// Deactivates a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1ConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1ConfigurationResponse>> V1ConfigurationConfigurationIdDeactivatePostAsyncWithHttpInfo (string configurationId, string sessionToken);
        /// <summary>
        /// Gets a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1Configuration</returns>
        System.Threading.Tasks.Task<V1Configuration> V1ConfigurationConfigurationIdGetGetAsync (string configurationId, string sessionToken);

        /// <summary>
        /// Gets a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationConfigurationIdGetGetAsyncWithHttpInfo (string configurationId, string sessionToken);
        /// <summary>
        /// Update a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of V1Configuration</returns>
        System.Threading.Tasks.Task<V1Configuration> V1ConfigurationConfigurationIdUpdatePutAsync (string configurationId, string sessionToken, V1Configuration configuration);

        /// <summary>
        /// Update a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationConfigurationIdUpdatePutAsyncWithHttpInfo (string configurationId, string sessionToken, V1Configuration configuration);
        /// <summary>
        /// Create a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration object.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of V1Configuration</returns>
        System.Threading.Tasks.Task<V1Configuration> V1ConfigurationCreatePostAsync (string sessionToken, V1ConfigurationSubmissionCreate configuration);

        /// <summary>
        /// Create a Configuration object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration object.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationCreatePostAsyncWithHttpInfo (string sessionToken, V1ConfigurationSubmissionCreate configuration);
        /// <summary>
        /// Gets a list of Configurations.
        /// </summary>
        /// <remarks>
        /// A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>Task of ConfigurationList</returns>
        System.Threading.Tasks.Task<ConfigurationList> V1ConfigurationListGetAsync (string sessionToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Gets a list of Configurations.
        /// </summary>
        /// <remarks>
        /// A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (ConfigurationList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationList>> V1ConfigurationListGetAsyncWithHttpInfo (string sessionToken, int? offset = null, int? limit = null);
        /// <summary>
        /// Gets a Configuration object by configuration type.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1Configuration</returns>
        System.Threading.Tasks.Task<V1Configuration> V1ConfigurationTypeConfigurationTypeGetGetAsync (string configurationType, string sessionToken);

        /// <summary>
        /// Gets a Configuration object by configuration type.
        /// </summary>
        /// <remarks>
        /// A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationTypeConfigurationTypeGetGetAsyncWithHttpInfo (string configurationType, string sessionToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigurationApi : IConfigurationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigurationApi(Configuration configuration = null)
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
        /// Activates a Configuration object. A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1ConfigurationResponse</returns>
        public V1ConfigurationResponse V1ConfigurationConfigurationIdActivatePost (string configurationId, string sessionToken)
        {
             ApiResponse<V1ConfigurationResponse> localVarResponse = V1ConfigurationConfigurationIdActivatePostWithHttpInfo(configurationId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activates a Configuration object. A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1ConfigurationResponse</returns>
        public ApiResponse< V1ConfigurationResponse > V1ConfigurationConfigurationIdActivatePostWithHttpInfo (string configurationId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdActivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdActivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/activate";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdActivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdActivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1ConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1ConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1ConfigurationResponse)));
            
        }

        /// <summary>
        /// Activates a Configuration object. A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1ConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<V1ConfigurationResponse> V1ConfigurationConfigurationIdActivatePostAsync (string configurationId, string sessionToken)
        {
             ApiResponse<V1ConfigurationResponse> localVarResponse = await V1ConfigurationConfigurationIdActivatePostAsyncWithHttpInfo(configurationId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activates a Configuration object. A caller can activate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already active, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1ConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1ConfigurationResponse>> V1ConfigurationConfigurationIdActivatePostAsyncWithHttpInfo (string configurationId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdActivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdActivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/activate";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdActivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdActivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1ConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1ConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1ConfigurationResponse)));
            
        }

        /// <summary>
        /// Deactivates a Configuration object. A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1ConfigurationResponse</returns>
        public V1ConfigurationResponse V1ConfigurationConfigurationIdDeactivatePost (string configurationId, string sessionToken)
        {
             ApiResponse<V1ConfigurationResponse> localVarResponse = V1ConfigurationConfigurationIdDeactivatePostWithHttpInfo(configurationId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivates a Configuration object. A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1ConfigurationResponse</returns>
        public ApiResponse< V1ConfigurationResponse > V1ConfigurationConfigurationIdDeactivatePostWithHttpInfo (string configurationId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdDeactivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdDeactivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/deactivate";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdDeactivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdDeactivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1ConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1ConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1ConfigurationResponse)));
            
        }

        /// <summary>
        /// Deactivates a Configuration object. A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1ConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<V1ConfigurationResponse> V1ConfigurationConfigurationIdDeactivatePostAsync (string configurationId, string sessionToken)
        {
             ApiResponse<V1ConfigurationResponse> localVarResponse = await V1ConfigurationConfigurationIdDeactivatePostAsyncWithHttpInfo(configurationId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivates a Configuration object. A caller can deactivate a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the intended Configuration is already inactive, 200 will be returned.\n\nIf the ID is correct, 200 is returned and the Configuration will be made inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1ConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1ConfigurationResponse>> V1ConfigurationConfigurationIdDeactivatePostAsyncWithHttpInfo (string configurationId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdDeactivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdDeactivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/deactivate";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdDeactivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdDeactivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1ConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1ConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1ConfigurationResponse)));
            
        }

        /// <summary>
        /// Gets a Configuration object. A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1Configuration</returns>
        public V1Configuration V1ConfigurationConfigurationIdGetGet (string configurationId, string sessionToken)
        {
             ApiResponse<V1Configuration> localVarResponse = V1ConfigurationConfigurationIdGetGetWithHttpInfo(configurationId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a Configuration object. A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1Configuration</returns>
        public ApiResponse< V1Configuration > V1ConfigurationConfigurationIdGetGetWithHttpInfo (string configurationId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdGetGet");

            var localVarPath = "/v1/configuration/{configurationId}/get";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

        /// <summary>
        /// Gets a Configuration object. A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1Configuration</returns>
        public async System.Threading.Tasks.Task<V1Configuration> V1ConfigurationConfigurationIdGetGetAsync (string configurationId, string sessionToken)
        {
             ApiResponse<V1Configuration> localVarResponse = await V1ConfigurationConfigurationIdGetGetAsyncWithHttpInfo(configurationId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a Configuration object. A caller can get a Configuration object for a given ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationConfigurationIdGetGetAsyncWithHttpInfo (string configurationId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdGetGet");

            var localVarPath = "/v1/configuration/{configurationId}/get";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

        /// <summary>
        /// Update a Configuration object. A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>V1Configuration</returns>
        public V1Configuration V1ConfigurationConfigurationIdUpdatePut (string configurationId, string sessionToken, V1Configuration configuration)
        {
             ApiResponse<V1Configuration> localVarResponse = V1ConfigurationConfigurationIdUpdatePutWithHttpInfo(configurationId, sessionToken, configuration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Configuration object. A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>ApiResponse of V1Configuration</returns>
        public ApiResponse< V1Configuration > V1ConfigurationConfigurationIdUpdatePutWithHttpInfo (string configurationId, string sessionToken, V1Configuration configuration)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdUpdatePut");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdUpdatePut");
            // verify the required parameter 'configuration' is set
            if (configuration == null)
                throw new ApiException(400, "Missing required parameter 'configuration' when calling ConfigurationApi->V1ConfigurationConfigurationIdUpdatePut");

            var localVarPath = "/v1/configuration/{configurationId}/update";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (configuration.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuration; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdUpdatePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdUpdatePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

        /// <summary>
        /// Update a Configuration object. A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of V1Configuration</returns>
        public async System.Threading.Tasks.Task<V1Configuration> V1ConfigurationConfigurationIdUpdatePutAsync (string configurationId, string sessionToken, V1Configuration configuration)
        {
             ApiResponse<V1Configuration> localVarResponse = await V1ConfigurationConfigurationIdUpdatePutAsyncWithHttpInfo(configurationId, sessionToken, configuration);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Configuration object. A caller can update a Configuration object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationConfigurationIdUpdatePutAsyncWithHttpInfo (string configurationId, string sessionToken, V1Configuration configuration)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationApi->V1ConfigurationConfigurationIdUpdatePut");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationConfigurationIdUpdatePut");
            // verify the required parameter 'configuration' is set
            if (configuration == null)
                throw new ApiException(400, "Missing required parameter 'configuration' when calling ConfigurationApi->V1ConfigurationConfigurationIdUpdatePut");

            var localVarPath = "/v1/configuration/{configurationId}/update";
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
            if (configurationId != null) localVarPathParams.Add("configurationId", Configuration.ApiClient.ParameterToString(configurationId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (configuration.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuration; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdUpdatePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdUpdatePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

        /// <summary>
        /// Create a Configuration object. A caller can create a Configuration object.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>V1Configuration</returns>
        public V1Configuration V1ConfigurationCreatePost (string sessionToken, V1ConfigurationSubmissionCreate configuration)
        {
             ApiResponse<V1Configuration> localVarResponse = V1ConfigurationCreatePostWithHttpInfo(sessionToken, configuration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Configuration object. A caller can create a Configuration object.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>ApiResponse of V1Configuration</returns>
        public ApiResponse< V1Configuration > V1ConfigurationCreatePostWithHttpInfo (string sessionToken, V1ConfigurationSubmissionCreate configuration)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationCreatePost");
            // verify the required parameter 'configuration' is set
            if (configuration == null)
                throw new ApiException(400, "Missing required parameter 'configuration' when calling ConfigurationApi->V1ConfigurationCreatePost");

            var localVarPath = "/v1/configuration/create";
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
            if (configuration.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuration; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

        /// <summary>
        /// Create a Configuration object. A caller can create a Configuration object.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of V1Configuration</returns>
        public async System.Threading.Tasks.Task<V1Configuration> V1ConfigurationCreatePostAsync (string sessionToken, V1ConfigurationSubmissionCreate configuration)
        {
             ApiResponse<V1Configuration> localVarResponse = await V1ConfigurationCreatePostAsyncWithHttpInfo(sessionToken, configuration);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Configuration object. A caller can create a Configuration object.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configuration"></param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationCreatePostAsyncWithHttpInfo (string sessionToken, V1ConfigurationSubmissionCreate configuration)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationCreatePost");
            // verify the required parameter 'configuration' is set
            if (configuration == null)
                throw new ApiException(400, "Missing required parameter 'configuration' when calling ConfigurationApi->V1ConfigurationCreatePost");

            var localVarPath = "/v1/configuration/create";
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
            if (configuration.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuration; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

        /// <summary>
        /// Gets a list of Configurations. A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>ConfigurationList</returns>
        public ConfigurationList V1ConfigurationListGet (string sessionToken, int? offset = null, int? limit = null)
        {
             ApiResponse<ConfigurationList> localVarResponse = V1ConfigurationListGetWithHttpInfo(sessionToken, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of Configurations. A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of ConfigurationList</returns>
        public ApiResponse< ConfigurationList > V1ConfigurationListGetWithHttpInfo (string sessionToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationListGet");

            var localVarPath = "/v1/configuration/list";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationList)));
            
        }

        /// <summary>
        /// Gets a list of Configurations. A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>Task of ConfigurationList</returns>
        public async System.Threading.Tasks.Task<ConfigurationList> V1ConfigurationListGetAsync (string sessionToken, int? offset = null, int? limit = null)
        {
             ApiResponse<ConfigurationList> localVarResponse = await V1ConfigurationListGetAsyncWithHttpInfo(sessionToken, offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of Configurations. A caller can get all Configuration objects.\n\nIf there are no Configurations to return, a 204 response will be returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of Configurations to skip.\n (optional)</param>
        /// <param name="limit">Max No. of Configurations to return. If no value is provided,\n50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (ConfigurationList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationList>> V1ConfigurationListGetAsyncWithHttpInfo (string sessionToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationListGet");

            var localVarPath = "/v1/configuration/list";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationList)));
            
        }

        /// <summary>
        /// Gets a Configuration object by configuration type. A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>V1Configuration</returns>
        public V1Configuration V1ConfigurationTypeConfigurationTypeGetGet (string configurationType, string sessionToken)
        {
             ApiResponse<V1Configuration> localVarResponse = V1ConfigurationTypeConfigurationTypeGetGetWithHttpInfo(configurationType, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a Configuration object by configuration type. A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of V1Configuration</returns>
        public ApiResponse< V1Configuration > V1ConfigurationTypeConfigurationTypeGetGetWithHttpInfo (string configurationType, string sessionToken)
        {
            // verify the required parameter 'configurationType' is set
            if (configurationType == null)
                throw new ApiException(400, "Missing required parameter 'configurationType' when calling ConfigurationApi->V1ConfigurationTypeConfigurationTypeGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationTypeConfigurationTypeGetGet");

            var localVarPath = "/v1/configuration/type/{configurationType}/get";
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
            if (configurationType != null) localVarPathParams.Add("configurationType", Configuration.ApiClient.ParameterToString(configurationType)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationTypeConfigurationTypeGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationTypeConfigurationTypeGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

        /// <summary>
        /// Gets a Configuration object by configuration type. A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of V1Configuration</returns>
        public async System.Threading.Tasks.Task<V1Configuration> V1ConfigurationTypeConfigurationTypeGetGetAsync (string configurationType, string sessionToken)
        {
             ApiResponse<V1Configuration> localVarResponse = await V1ConfigurationTypeConfigurationTypeGetGetAsyncWithHttpInfo(configurationType, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a Configuration object by configuration type. A caller can get a Configuration object for a given configuration type.\n\nIf the {configurationType} is invalid, a client error results.\n\nIf the type is correct, then 200 is returned along with the Configuration.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationType">Configuration type</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (V1Configuration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1Configuration>> V1ConfigurationTypeConfigurationTypeGetGetAsyncWithHttpInfo (string configurationType, string sessionToken)
        {
            // verify the required parameter 'configurationType' is set
            if (configurationType == null)
                throw new ApiException(400, "Missing required parameter 'configurationType' when calling ConfigurationApi->V1ConfigurationTypeConfigurationTypeGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationApi->V1ConfigurationTypeConfigurationTypeGetGet");

            var localVarPath = "/v1/configuration/type/{configurationType}/get";
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
            if (configurationType != null) localVarPathParams.Add("configurationType", Configuration.ApiClient.ParameterToString(configurationType)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationTypeConfigurationTypeGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationTypeConfigurationTypeGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<V1Configuration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Configuration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Configuration)));
            
        }

    }
}
