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
    public interface IUtilApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Test endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>SimpleMessage</returns>
        SimpleMessage V1UtilEchoPost (string sessionToken, string keyManagerToken, SimpleMessage echoInput);

        /// <summary>
        /// Test endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>ApiResponse of SimpleMessage</returns>
        ApiResponse<SimpleMessage> V1UtilEchoPostWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput);
        /// <summary>
        /// Example of a deprecated endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>SimpleMessage</returns>
        SimpleMessage V1UtilObsoletePost (string sessionToken, string keyManagerToken, SimpleMessage echoInput);

        /// <summary>
        /// Example of a deprecated endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>ApiResponse of SimpleMessage</returns>
        ApiResponse<SimpleMessage> V1UtilObsoletePostWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Test endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of SimpleMessage</returns>
        System.Threading.Tasks.Task<SimpleMessage> V1UtilEchoPostAsync (string sessionToken, string keyManagerToken, SimpleMessage echoInput);

        /// <summary>
        /// Test endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of ApiResponse (SimpleMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<SimpleMessage>> V1UtilEchoPostAsyncWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput);
        /// <summary>
        /// Example of a deprecated endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of SimpleMessage</returns>
        System.Threading.Tasks.Task<SimpleMessage> V1UtilObsoletePostAsync (string sessionToken, string keyManagerToken, SimpleMessage echoInput);

        /// <summary>
        /// Example of a deprecated endpoint, returns input.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of ApiResponse (SimpleMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<SimpleMessage>> V1UtilObsoletePostAsyncWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UtilApi : IUtilApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UtilApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UtilApi(Configuration configuration = null)
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
        /// Test endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>SimpleMessage</returns>
        public SimpleMessage V1UtilEchoPost (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
             ApiResponse<SimpleMessage> localVarResponse = V1UtilEchoPostWithHttpInfo(sessionToken, keyManagerToken, echoInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Test endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>ApiResponse of SimpleMessage</returns>
        public ApiResponse< SimpleMessage > V1UtilEchoPostWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UtilApi->V1UtilEchoPost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling UtilApi->V1UtilEchoPost");
            // verify the required parameter 'echoInput' is set
            if (echoInput == null)
                throw new ApiException(400, "Missing required parameter 'echoInput' when calling UtilApi->V1UtilEchoPost");

            var localVarPath = "/v1/util/echo";
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
            if (echoInput.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(echoInput); // http body (model) parameter
            }
            else
            {
                localVarPostBody = echoInput; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilEchoPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilEchoPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SimpleMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleMessage)));
            
        }

        /// <summary>
        /// Test endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of SimpleMessage</returns>
        public async System.Threading.Tasks.Task<SimpleMessage> V1UtilEchoPostAsync (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
             ApiResponse<SimpleMessage> localVarResponse = await V1UtilEchoPostAsyncWithHttpInfo(sessionToken, keyManagerToken, echoInput);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Test endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of ApiResponse (SimpleMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SimpleMessage>> V1UtilEchoPostAsyncWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UtilApi->V1UtilEchoPost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling UtilApi->V1UtilEchoPost");
            // verify the required parameter 'echoInput' is set
            if (echoInput == null)
                throw new ApiException(400, "Missing required parameter 'echoInput' when calling UtilApi->V1UtilEchoPost");

            var localVarPath = "/v1/util/echo";
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
            if (echoInput.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(echoInput); // http body (model) parameter
            }
            else
            {
                localVarPostBody = echoInput; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilEchoPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilEchoPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SimpleMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleMessage)));
            
        }

        /// <summary>
        /// Example of a deprecated endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>SimpleMessage</returns>
        public SimpleMessage V1UtilObsoletePost (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
             ApiResponse<SimpleMessage> localVarResponse = V1UtilObsoletePostWithHttpInfo(sessionToken, keyManagerToken, echoInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Example of a deprecated endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>ApiResponse of SimpleMessage</returns>
        public ApiResponse< SimpleMessage > V1UtilObsoletePostWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UtilApi->V1UtilObsoletePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling UtilApi->V1UtilObsoletePost");
            // verify the required parameter 'echoInput' is set
            if (echoInput == null)
                throw new ApiException(400, "Missing required parameter 'echoInput' when calling UtilApi->V1UtilObsoletePost");

            var localVarPath = "/v1/util/obsolete";
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
            if (echoInput.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(echoInput); // http body (model) parameter
            }
            else
            {
                localVarPostBody = echoInput; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilObsoletePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilObsoletePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SimpleMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleMessage)));
            
        }

        /// <summary>
        /// Example of a deprecated endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of SimpleMessage</returns>
        public async System.Threading.Tasks.Task<SimpleMessage> V1UtilObsoletePostAsync (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
             ApiResponse<SimpleMessage> localVarResponse = await V1UtilObsoletePostAsyncWithHttpInfo(sessionToken, keyManagerToken, echoInput);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Example of a deprecated endpoint, returns input. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="echoInput">Message in plain text\n</param>
        /// <returns>Task of ApiResponse (SimpleMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SimpleMessage>> V1UtilObsoletePostAsyncWithHttpInfo (string sessionToken, string keyManagerToken, SimpleMessage echoInput)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UtilApi->V1UtilObsoletePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling UtilApi->V1UtilObsoletePost");
            // verify the required parameter 'echoInput' is set
            if (echoInput == null)
                throw new ApiException(400, "Missing required parameter 'echoInput' when calling UtilApi->V1UtilObsoletePost");

            var localVarPath = "/v1/util/obsolete";
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
            if (echoInput.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(echoInput); // http body (model) parameter
            }
            else
            {
                localVarPostBody = echoInput; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilObsoletePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UtilObsoletePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SimpleMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleMessage)));
            
        }

    }
}
