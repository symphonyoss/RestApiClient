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
    public interface IConfigurationInstanceApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        ConfigurationInstanceResponse V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        ApiResponse<ConfigurationInstanceResponse> V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        ConfigurationInstanceResponse V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        ApiResponse<ConfigurationInstanceResponse> V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstance</returns>
        ConfigurationInstance V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        ApiResponse<ConfigurationInstance> V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ConfigurationInstance</returns>
        ConfigurationInstance V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);

        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        ApiResponse<ConfigurationInstance> V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);
        /// <summary>
        /// Get a list of configuration Instances from an Integration.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ConfigurationInstanceList</returns>
        ConfigurationInstanceList V1AdminConfigurationConfigurationIdInstanceListGet (string configurationId, string sessionToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Get a list of configuration Instances from an Integration.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of ConfigurationInstanceList</returns>
        ApiResponse<ConfigurationInstanceList> V1AdminConfigurationConfigurationIdInstanceListGetWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null);
        /// <summary>
        /// Create a Configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ConfigurationInstance</returns>
        ConfigurationInstance V1ConfigurationConfigurationIdInstanceCreatePost (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance);

        /// <summary>
        /// Create a Configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        ApiResponse<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceCreatePostWithHttpInfo (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance);
        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        ConfigurationInstanceResponse V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        ApiResponse<ConfigurationInstanceResponse> V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        ConfigurationInstanceResponse V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        ApiResponse<ConfigurationInstanceResponse> V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstance</returns>
        ConfigurationInstance V1ConfigurationConfigurationIdInstanceInstanceIdGetGet (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        ApiResponse<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceInstanceIdGetGetWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ConfigurationInstance</returns>
        ConfigurationInstance V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);

        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        ApiResponse<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);
        /// <summary>
        /// Get a list of configuration Instances from an specific user.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ConfigurationInstanceList</returns>
        ConfigurationInstanceList V1ConfigurationConfigurationIdInstanceListGet (string configurationId, string sessionToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Get a list of configuration Instances from an specific user.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of ConfigurationInstanceList</returns>
        ApiResponse<ConfigurationInstanceList> V1ConfigurationConfigurationIdInstanceListGetWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostAsync (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsync (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstance</returns>
        System.Threading.Tasks.Task<ConfigurationInstance> V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetAsync (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ConfigurationInstance</returns>
        System.Threading.Tasks.Task<ConfigurationInstance> V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsync (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);

        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);
        /// <summary>
        /// Get a list of configuration Instances from an Integration.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ConfigurationInstanceList</returns>
        System.Threading.Tasks.Task<ConfigurationInstanceList> V1AdminConfigurationConfigurationIdInstanceListGetAsync (string configurationId, string sessionToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Get a list of configuration Instances from an Integration.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceList>> V1AdminConfigurationConfigurationIdInstanceListGetAsyncWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null);
        /// <summary>
        /// Create a Configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ConfigurationInstance</returns>
        System.Threading.Tasks.Task<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceCreatePostAsync (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance);

        /// <summary>
        /// Create a Configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1ConfigurationConfigurationIdInstanceCreatePostAsyncWithHttpInfo (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance);
        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostAsync (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Activates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsync (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstance</returns>
        System.Threading.Tasks.Task<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceInstanceIdGetGetAsync (string configurationId, string instanceId, string sessionToken);

        /// <summary>
        /// Get a configuration Instance from a Configuration.
        /// </summary>
        /// <remarks>
        /// A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1ConfigurationConfigurationIdInstanceInstanceIdGetGetAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken);
        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ConfigurationInstance</returns>
        System.Threading.Tasks.Task<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsync (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);

        /// <summary>
        /// Update a configuration Instance object.
        /// </summary>
        /// <remarks>
        /// A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance);
        /// <summary>
        /// Get a list of configuration Instances from an specific user.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ConfigurationInstanceList</returns>
        System.Threading.Tasks.Task<ConfigurationInstanceList> V1ConfigurationConfigurationIdInstanceListGetAsync (string configurationId, string sessionToken, int? offset = null, int? limit = null);

        /// <summary>
        /// Get a list of configuration Instances from an specific user.
        /// </summary>
        /// <remarks>
        /// A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceList>> V1ConfigurationConfigurationIdInstanceListGetAsyncWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigurationInstanceApi : IConfigurationInstanceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationInstanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationInstanceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationInstanceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigurationInstanceApi(Configuration configuration = null)
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
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        public ConfigurationInstanceResponse V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        public ApiResponse< ConfigurationInstanceResponse > V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/activate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostAsync (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = await V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostAsyncWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/activate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        public ConfigurationInstanceResponse V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        public ApiResponse< ConfigurationInstanceResponse > V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/deactivate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsync (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = await V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsyncWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/deactivate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstance</returns>
        public ConfigurationInstance V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        public ApiResponse< ConfigurationInstance > V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/get";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstance</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstance> V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetAsync (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = await V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetAsyncWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGetAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/get";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ConfigurationInstance</returns>
        public ConfigurationInstance V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutWithHttpInfo(configurationId, instanceId, sessionToken, configurationInstance);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        public ApiResponse< ConfigurationInstance > V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'configurationInstance' is set
            if (configurationInstance == null)
                throw new ApiException(400, "Missing required parameter 'configurationInstance' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/update";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (configurationInstance.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configurationInstance); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configurationInstance; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ConfigurationInstance</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstance> V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsync (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = await V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsyncWithHttpInfo(configurationId, instanceId, sessionToken, configurationInstance);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'configurationInstance' is set
            if (configurationInstance == null)
                throw new ApiException(400, "Missing required parameter 'configurationInstance' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/{instanceId}/update";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (configurationInstance.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configurationInstance); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configurationInstance; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Get a list of configuration Instances from an Integration. A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ConfigurationInstanceList</returns>
        public ConfigurationInstanceList V1AdminConfigurationConfigurationIdInstanceListGet (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
             ApiResponse<ConfigurationInstanceList> localVarResponse = V1AdminConfigurationConfigurationIdInstanceListGetWithHttpInfo(configurationId, sessionToken, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of configuration Instances from an Integration. A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of ConfigurationInstanceList</returns>
        public ApiResponse< ConfigurationInstanceList > V1AdminConfigurationConfigurationIdInstanceListGetWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceListGet");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/list";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceList)));
            
        }

        /// <summary>
        /// Get a list of configuration Instances from an Integration. A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ConfigurationInstanceList</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstanceList> V1AdminConfigurationConfigurationIdInstanceListGetAsync (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
             ApiResponse<ConfigurationInstanceList> localVarResponse = await V1AdminConfigurationConfigurationIdInstanceListGetAsyncWithHttpInfo(configurationId, sessionToken, offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of configuration Instances from an Integration. A caller can get all configuration Instances objects for a given Configuration ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceList>> V1AdminConfigurationConfigurationIdInstanceListGetAsyncWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1AdminConfigurationConfigurationIdInstanceListGet");

            var localVarPath = "/v1/admin/configuration/{configurationId}/instance/list";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminConfigurationConfigurationIdInstanceListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceList)));
            
        }

        /// <summary>
        /// Create a Configuration Instance object. A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ConfigurationInstance</returns>
        public ConfigurationInstance V1ConfigurationConfigurationIdInstanceCreatePost (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = V1ConfigurationConfigurationIdInstanceCreatePostWithHttpInfo(configurationId, sessionToken, configurationInstance);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Configuration Instance object. A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        public ApiResponse< ConfigurationInstance > V1ConfigurationConfigurationIdInstanceCreatePostWithHttpInfo (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceCreatePost");
            // verify the required parameter 'configurationInstance' is set
            if (configurationInstance == null)
                throw new ApiException(400, "Missing required parameter 'configurationInstance' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceCreatePost");

            var localVarPath = "/v1/configuration/{configurationId}/instance/create";
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
            if (configurationInstance.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configurationInstance); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configurationInstance; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Create a Configuration Instance object. A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ConfigurationInstance</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceCreatePostAsync (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = await V1ConfigurationConfigurationIdInstanceCreatePostAsyncWithHttpInfo(configurationId, sessionToken, configurationInstance);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Configuration Instance object. A caller can create a Configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1ConfigurationConfigurationIdInstanceCreatePostAsyncWithHttpInfo (string configurationId, string sessionToken, ConfigurationInstanceSubmissionCreate configurationInstance)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceCreatePost");
            // verify the required parameter 'configurationInstance' is set
            if (configurationInstance == null)
                throw new ApiException(400, "Missing required parameter 'configurationInstance' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceCreatePost");

            var localVarPath = "/v1/configuration/{configurationId}/instance/create";
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
            if (configurationInstance.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configurationInstance); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configurationInstance; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        public ConfigurationInstanceResponse V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        public ApiResponse< ConfigurationInstanceResponse > V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/activate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostAsync (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = await V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostAsyncWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activates a configuration Instance from a Configuration. A caller can activate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already active, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the Instance will be made active.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1ConfigurationConfigurationIdInstanceInstanceIdActivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/activate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdActivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstanceResponse</returns>
        public ConfigurationInstanceResponse V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstanceResponse</returns>
        public ApiResponse< ConfigurationInstanceResponse > V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/deactivate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstanceResponse</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstanceResponse> V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsync (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstanceResponse> localVarResponse = await V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsyncWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivates a configuration Instance from a Configuration. A caller can deactivate a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the configuration Instance is already inactive, a 200 will be returned.\n\nIf the ID is correct, then 200 is returned and the instance will be made inactive.\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceResponse>> V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePostAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/deactivate";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdDeactivatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceResponse)));
            
        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ConfigurationInstance</returns>
        public ConfigurationInstance V1ConfigurationConfigurationIdInstanceInstanceIdGetGet (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = V1ConfigurationConfigurationIdInstanceInstanceIdGetGetWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        public ApiResponse< ConfigurationInstance > V1ConfigurationConfigurationIdInstanceInstanceIdGetGetWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdGetGet");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/get";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ConfigurationInstance</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceInstanceIdGetGetAsync (string configurationId, string instanceId, string sessionToken)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = await V1ConfigurationConfigurationIdInstanceInstanceIdGetGetAsyncWithHttpInfo(configurationId, instanceId, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a configuration Instance from a Configuration. A caller can get a configuration Instance object for a given Configuration and Instance ID.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n\nIf the ID is correct, then 200 is returned along with the configuration\nInstance.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1ConfigurationConfigurationIdInstanceInstanceIdGetGetAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdGetGet");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/get";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ConfigurationInstance</returns>
        public ConfigurationInstance V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutWithHttpInfo(configurationId, instanceId, sessionToken, configurationInstance);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>ApiResponse of ConfigurationInstance</returns>
        public ApiResponse< ConfigurationInstance > V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'configurationInstance' is set
            if (configurationInstance == null)
                throw new ApiException(400, "Missing required parameter 'configurationInstance' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/update";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (configurationInstance.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configurationInstance); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configurationInstance; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ConfigurationInstance</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstance> V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsync (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
             ApiResponse<ConfigurationInstance> localVarResponse = await V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsyncWithHttpInfo(configurationId, instanceId, sessionToken, configurationInstance);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a configuration Instance object. A caller can update a configuration Instance object.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf the {instanceId} is invalid, a client error results.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="instanceId">Configuration Instance ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="configurationInstance"></param>
        /// <returns>Task of ApiResponse (ConfigurationInstance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstance>> V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePutAsyncWithHttpInfo (string configurationId, string instanceId, string sessionToken, ConfigurationInstanceSubmissionUpdate configurationInstance)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new ApiException(400, "Missing required parameter 'instanceId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");
            // verify the required parameter 'configurationInstance' is set
            if (configurationInstance == null)
                throw new ApiException(400, "Missing required parameter 'configurationInstance' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut");

            var localVarPath = "/v1/configuration/{configurationId}/instance/{instanceId}/update";
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
            if (instanceId != null) localVarPathParams.Add("instanceId", Configuration.ApiClient.ParameterToString(instanceId)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (configurationInstance.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configurationInstance); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configurationInstance; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceInstanceIdUpdatePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstance)));
            
        }

        /// <summary>
        /// Get a list of configuration Instances from an specific user. A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ConfigurationInstanceList</returns>
        public ConfigurationInstanceList V1ConfigurationConfigurationIdInstanceListGet (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
             ApiResponse<ConfigurationInstanceList> localVarResponse = V1ConfigurationConfigurationIdInstanceListGetWithHttpInfo(configurationId, sessionToken, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of configuration Instances from an specific user. A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>ApiResponse of ConfigurationInstanceList</returns>
        public ApiResponse< ConfigurationInstanceList > V1ConfigurationConfigurationIdInstanceListGetWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceListGet");

            var localVarPath = "/v1/configuration/{configurationId}/instance/list";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceList)));
            
        }

        /// <summary>
        /// Get a list of configuration Instances from an specific user. A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ConfigurationInstanceList</returns>
        public async System.Threading.Tasks.Task<ConfigurationInstanceList> V1ConfigurationConfigurationIdInstanceListGetAsync (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
             ApiResponse<ConfigurationInstanceList> localVarResponse = await V1ConfigurationConfigurationIdInstanceListGetAsyncWithHttpInfo(configurationId, sessionToken, offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of configuration Instances from an specific user. A caller can get all configuration instances objects of the current user.\n\nIf the {configurationId} is invalid, a client error results.\n\nIf there are no configuration Instances to return, a 204 response will be\nreturned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configurationId">Configuration ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="offset">No. of configuration Instances to skip.\n (optional)</param>
        /// <param name="limit">Max No. of configuration Instances to return. If no value is\nprovided, 50 is the default.\n (optional)</param>
        /// <returns>Task of ApiResponse (ConfigurationInstanceList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationInstanceList>> V1ConfigurationConfigurationIdInstanceListGetAsyncWithHttpInfo (string configurationId, string sessionToken, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'configurationId' is set
            if (configurationId == null)
                throw new ApiException(400, "Missing required parameter 'configurationId' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling ConfigurationInstanceApi->V1ConfigurationConfigurationIdInstanceListGet");

            var localVarPath = "/v1/configuration/{configurationId}/instance/list";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1ConfigurationConfigurationIdInstanceListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfigurationInstanceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationInstanceList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationInstanceList)));
            
        }

    }
}
