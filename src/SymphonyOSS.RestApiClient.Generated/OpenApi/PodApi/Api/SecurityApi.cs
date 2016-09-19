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
    public interface ISecurityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a company trusted or untrusted certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1CompanycertCreatePost (string sessionToken, CompanyCert cert);

        /// <summary>
        /// Create a company trusted or untrusted certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1CompanycertCreatePostWithHttpInfo (string sessionToken, CompanyCert cert);
        /// <summary>
        /// Delete a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1CompanycertDeletePost (string sessionToken, StringId fingerPrint);

        /// <summary>
        /// Delete a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1CompanycertDeletePostWithHttpInfo (string sessionToken, StringId fingerPrint);
        /// <summary>
        /// Get the details of a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>CompanyCertDetail</returns>
        CompanyCertDetail V1CompanycertFingerPrintGetGet (string fingerPrint, string sessionToken);

        /// <summary>
        /// Get the details of a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of CompanyCertDetail</returns>
        ApiResponse<CompanyCertDetail> V1CompanycertFingerPrintGetGetWithHttpInfo (string fingerPrint, string sessionToken);
        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>CompanyCertInfoList</returns>
        CompanyCertInfoList V1CompanycertFingerPrintIssuedByGet (string fingerPrint, string sessionToken);

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        ApiResponse<CompanyCertInfoList> V1CompanycertFingerPrintIssuedByGetWithHttpInfo (string fingerPrint, string sessionToken);
        /// <summary>
        /// Update a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1CompanycertFingerPrintUpdatePost (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes);

        /// <summary>
        /// Update a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1CompanycertFingerPrintUpdatePostWithHttpInfo (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes);
        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>CompanyCertInfoList</returns>
        CompanyCertInfoList V1CompanycertListGet (string sessionToken, int? skip = null, int? limit = null);

        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        ApiResponse<CompanyCertInfoList> V1CompanycertListGetWithHttpInfo (string sessionToken, int? skip = null, int? limit = null);
        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>CompanyCertInfoList</returns>
        CompanyCertInfoList V1CompanycertPodmanagedListGet (string sessionToken, int? skip = null, int? limit = null);

        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        ApiResponse<CompanyCertInfoList> V1CompanycertPodmanagedListGetWithHttpInfo (string sessionToken, int? skip = null, int? limit = null);
        /// <summary>
        /// List all certs of the given types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>CompanyCertInfoList</returns>
        CompanyCertInfoList V1CompanycertTypeListPost (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null);

        /// <summary>
        /// List all certs of the given types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        ApiResponse<CompanyCertInfoList> V1CompanycertTypeListPostWithHttpInfo (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a company trusted or untrusted certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1CompanycertCreatePostAsync (string sessionToken, CompanyCert cert);

        /// <summary>
        /// Create a company trusted or untrusted certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1CompanycertCreatePostAsyncWithHttpInfo (string sessionToken, CompanyCert cert);
        /// <summary>
        /// Delete a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1CompanycertDeletePostAsync (string sessionToken, StringId fingerPrint);

        /// <summary>
        /// Delete a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1CompanycertDeletePostAsyncWithHttpInfo (string sessionToken, StringId fingerPrint);
        /// <summary>
        /// Get the details of a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of CompanyCertDetail</returns>
        System.Threading.Tasks.Task<CompanyCertDetail> V1CompanycertFingerPrintGetGetAsync (string fingerPrint, string sessionToken);

        /// <summary>
        /// Get the details of a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (CompanyCertDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyCertDetail>> V1CompanycertFingerPrintGetGetAsyncWithHttpInfo (string fingerPrint, string sessionToken);
        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertFingerPrintIssuedByGetAsync (string fingerPrint, string sessionToken);

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertFingerPrintIssuedByGetAsyncWithHttpInfo (string fingerPrint, string sessionToken);
        /// <summary>
        /// Update a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1CompanycertFingerPrintUpdatePostAsync (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes);

        /// <summary>
        /// Update a company certificate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1CompanycertFingerPrintUpdatePostAsyncWithHttpInfo (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes);
        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertListGetAsync (string sessionToken, int? skip = null, int? limit = null);

        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertListGetAsyncWithHttpInfo (string sessionToken, int? skip = null, int? limit = null);
        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertPodmanagedListGetAsync (string sessionToken, int? skip = null, int? limit = null);

        /// <summary>
        /// List all trusted certs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertPodmanagedListGetAsyncWithHttpInfo (string sessionToken, int? skip = null, int? limit = null);
        /// <summary>
        /// List all certs of the given types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertTypeListPostAsync (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null);

        /// <summary>
        /// List all certs of the given types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertTypeListPostAsyncWithHttpInfo (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SecurityApi : ISecurityApi
    {
        private SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SecurityApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.Configuration.DefaultExceptionFactory;

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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

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
        /// Create a company trusted or untrusted certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1CompanycertCreatePost (string sessionToken, CompanyCert cert)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1CompanycertCreatePostWithHttpInfo(sessionToken, cert);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a company trusted or untrusted certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1CompanycertCreatePostWithHttpInfo (string sessionToken, CompanyCert cert)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertCreatePost");
            // verify the required parameter 'cert' is set
            if (cert == null)
                throw new ApiException(400, "Missing required parameter 'cert' when calling SecurityApi->V1CompanycertCreatePost");

            var localVarPath = "/v1/companycert/create";
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
            if (cert != null && cert.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cert); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cert; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertCreatePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Create a company trusted or untrusted certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1CompanycertCreatePostAsync (string sessionToken, CompanyCert cert)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1CompanycertCreatePostAsyncWithHttpInfo(sessionToken, cert);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a company trusted or untrusted certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="cert"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1CompanycertCreatePostAsyncWithHttpInfo (string sessionToken, CompanyCert cert)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertCreatePost");
            // verify the required parameter 'cert' is set
            if (cert == null)
                throw new ApiException(400, "Missing required parameter 'cert' when calling SecurityApi->V1CompanycertCreatePost");

            var localVarPath = "/v1/companycert/create";
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
            if (cert != null && cert.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cert); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cert; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertCreatePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Delete a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1CompanycertDeletePost (string sessionToken, StringId fingerPrint)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1CompanycertDeletePostWithHttpInfo(sessionToken, fingerPrint);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1CompanycertDeletePostWithHttpInfo (string sessionToken, StringId fingerPrint)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertDeletePost");
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertDeletePost");

            var localVarPath = "/v1/companycert/delete";
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
            if (fingerPrint != null && fingerPrint.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(fingerPrint); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fingerPrint; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Delete a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1CompanycertDeletePostAsync (string sessionToken, StringId fingerPrint)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1CompanycertDeletePostAsyncWithHttpInfo(sessionToken, fingerPrint);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="fingerPrint"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1CompanycertDeletePostAsyncWithHttpInfo (string sessionToken, StringId fingerPrint)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertDeletePost");
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertDeletePost");

            var localVarPath = "/v1/companycert/delete";
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
            if (fingerPrint != null && fingerPrint.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(fingerPrint); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fingerPrint; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Get the details of a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>CompanyCertDetail</returns>
        public CompanyCertDetail V1CompanycertFingerPrintGetGet (string fingerPrint, string sessionToken)
        {
             ApiResponse<CompanyCertDetail> localVarResponse = V1CompanycertFingerPrintGetGetWithHttpInfo(fingerPrint, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the details of a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of CompanyCertDetail</returns>
        public ApiResponse< CompanyCertDetail > V1CompanycertFingerPrintGetGetWithHttpInfo (string fingerPrint, string sessionToken)
        {
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertFingerPrintGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertFingerPrintGetGet");

            var localVarPath = "/v1/companycert/{fingerPrint}/get";
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
            if (fingerPrint != null) localVarPathParams.Add("fingerPrint", Configuration.ApiClient.ParameterToString(fingerPrint)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertFingerPrintGetGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertDetail)));
            
        }

        /// <summary>
        /// Get the details of a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of CompanyCertDetail</returns>
        public async System.Threading.Tasks.Task<CompanyCertDetail> V1CompanycertFingerPrintGetGetAsync (string fingerPrint, string sessionToken)
        {
             ApiResponse<CompanyCertDetail> localVarResponse = await V1CompanycertFingerPrintGetGetAsyncWithHttpInfo(fingerPrint, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the details of a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (CompanyCertDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyCertDetail>> V1CompanycertFingerPrintGetGetAsyncWithHttpInfo (string fingerPrint, string sessionToken)
        {
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertFingerPrintGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertFingerPrintGetGet");

            var localVarPath = "/v1/companycert/{fingerPrint}/get";
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
            if (fingerPrint != null) localVarPathParams.Add("fingerPrint", Configuration.ApiClient.ParameterToString(fingerPrint)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertFingerPrintGetGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertDetail)));
            
        }

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed.  
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>CompanyCertInfoList</returns>
        public CompanyCertInfoList V1CompanycertFingerPrintIssuedByGet (string fingerPrint, string sessionToken)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = V1CompanycertFingerPrintIssuedByGetWithHttpInfo(fingerPrint, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed.  
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        public ApiResponse< CompanyCertInfoList > V1CompanycertFingerPrintIssuedByGetWithHttpInfo (string fingerPrint, string sessionToken)
        {
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertFingerPrintIssuedByGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertFingerPrintIssuedByGet");

            var localVarPath = "/v1/companycert/{fingerPrint}/issuedBy";
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
            if (fingerPrint != null) localVarPathParams.Add("fingerPrint", Configuration.ApiClient.ParameterToString(fingerPrint)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertFingerPrintIssuedByGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed.  
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        public async System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertFingerPrintIssuedByGetAsync (string fingerPrint, string sessionToken)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = await V1CompanycertFingerPrintIssuedByGetAsyncWithHttpInfo(fingerPrint, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed.  
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertFingerPrintIssuedByGetAsyncWithHttpInfo (string fingerPrint, string sessionToken)
        {
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertFingerPrintIssuedByGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertFingerPrintIssuedByGet");

            var localVarPath = "/v1/companycert/{fingerPrint}/issuedBy";
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
            if (fingerPrint != null) localVarPathParams.Add("fingerPrint", Configuration.ApiClient.ParameterToString(fingerPrint)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertFingerPrintIssuedByGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

        /// <summary>
        /// Update a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1CompanycertFingerPrintUpdatePost (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1CompanycertFingerPrintUpdatePostWithHttpInfo(fingerPrint, sessionToken, certAttributes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1CompanycertFingerPrintUpdatePostWithHttpInfo (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes)
        {
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertFingerPrintUpdatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertFingerPrintUpdatePost");
            // verify the required parameter 'certAttributes' is set
            if (certAttributes == null)
                throw new ApiException(400, "Missing required parameter 'certAttributes' when calling SecurityApi->V1CompanycertFingerPrintUpdatePost");

            var localVarPath = "/v1/companycert/{fingerPrint}/update";
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
            if (fingerPrint != null) localVarPathParams.Add("fingerPrint", Configuration.ApiClient.ParameterToString(fingerPrint)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (certAttributes != null && certAttributes.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(certAttributes); // http body (model) parameter
            }
            else
            {
                localVarPostBody = certAttributes; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertFingerPrintUpdatePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Update a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1CompanycertFingerPrintUpdatePostAsync (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1CompanycertFingerPrintUpdatePostAsyncWithHttpInfo(fingerPrint, sessionToken, certAttributes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a company certificate 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fingerPrint">Certificate fingerPrint (ID)</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="certAttributes"></param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1CompanycertFingerPrintUpdatePostAsyncWithHttpInfo (string fingerPrint, string sessionToken, CompanyCertAttributes certAttributes)
        {
            // verify the required parameter 'fingerPrint' is set
            if (fingerPrint == null)
                throw new ApiException(400, "Missing required parameter 'fingerPrint' when calling SecurityApi->V1CompanycertFingerPrintUpdatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertFingerPrintUpdatePost");
            // verify the required parameter 'certAttributes' is set
            if (certAttributes == null)
                throw new ApiException(400, "Missing required parameter 'certAttributes' when calling SecurityApi->V1CompanycertFingerPrintUpdatePost");

            var localVarPath = "/v1/companycert/{fingerPrint}/update";
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
            if (fingerPrint != null) localVarPathParams.Add("fingerPrint", Configuration.ApiClient.ParameterToString(fingerPrint)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (certAttributes != null && certAttributes.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(certAttributes); // http body (model) parameter
            }
            else
            {
                localVarPostBody = certAttributes; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertFingerPrintUpdatePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>CompanyCertInfoList</returns>
        public CompanyCertInfoList V1CompanycertListGet (string sessionToken, int? skip = null, int? limit = null)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = V1CompanycertListGetWithHttpInfo(sessionToken, skip, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        public ApiResponse< CompanyCertInfoList > V1CompanycertListGetWithHttpInfo (string sessionToken, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertListGet");

            var localVarPath = "/v1/companycert/list";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertListGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        public async System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertListGetAsync (string sessionToken, int? skip = null, int? limit = null)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = await V1CompanycertListGetAsyncWithHttpInfo(sessionToken, skip, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertListGetAsyncWithHttpInfo (string sessionToken, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertListGet");

            var localVarPath = "/v1/companycert/list";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertListGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>CompanyCertInfoList</returns>
        public CompanyCertInfoList V1CompanycertPodmanagedListGet (string sessionToken, int? skip = null, int? limit = null)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = V1CompanycertPodmanagedListGetWithHttpInfo(sessionToken, skip, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        public ApiResponse< CompanyCertInfoList > V1CompanycertPodmanagedListGetWithHttpInfo (string sessionToken, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertPodmanagedListGet");

            var localVarPath = "/v1/companycert/podmanaged/list";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertPodmanagedListGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        public async System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertPodmanagedListGetAsync (string sessionToken, int? skip = null, int? limit = null)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = await V1CompanycertPodmanagedListGetAsyncWithHttpInfo(sessionToken, skip, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all trusted certs 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertPodmanagedListGetAsyncWithHttpInfo (string sessionToken, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertPodmanagedListGet");

            var localVarPath = "/v1/companycert/podmanaged/list";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertPodmanagedListGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

        /// <summary>
        /// List all certs of the given types 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>CompanyCertInfoList</returns>
        public CompanyCertInfoList V1CompanycertTypeListPost (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = V1CompanycertTypeListPostWithHttpInfo(typeIdList, sessionToken, skip, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all certs of the given types 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>ApiResponse of CompanyCertInfoList</returns>
        public ApiResponse< CompanyCertInfoList > V1CompanycertTypeListPostWithHttpInfo (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'typeIdList' is set
            if (typeIdList == null)
                throw new ApiException(400, "Missing required parameter 'typeIdList' when calling SecurityApi->V1CompanycertTypeListPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertTypeListPost");

            var localVarPath = "/v1/companycert/type/list";
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
            if (typeIdList != null && typeIdList.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(typeIdList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = typeIdList; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertTypeListPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

        /// <summary>
        /// List all certs of the given types 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of CompanyCertInfoList</returns>
        public async System.Threading.Tasks.Task<CompanyCertInfoList> V1CompanycertTypeListPostAsync (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null)
        {
             ApiResponse<CompanyCertInfoList> localVarResponse = await V1CompanycertTypeListPostAsyncWithHttpInfo(typeIdList, sessionToken, skip, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all certs of the given types 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeIdList">Certificate type list</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="skip">Pagination start (optional)</param>
        /// <param name="limit">Row limit (optional)</param>
        /// <returns>Task of ApiResponse (CompanyCertInfoList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyCertInfoList>> V1CompanycertTypeListPostAsyncWithHttpInfo (CompanyCertTypeList typeIdList, string sessionToken, int? skip = null, int? limit = null)
        {
            // verify the required parameter 'typeIdList' is set
            if (typeIdList == null)
                throw new ApiException(400, "Missing required parameter 'typeIdList' when calling SecurityApi->V1CompanycertTypeListPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling SecurityApi->V1CompanycertTypeListPost");

            var localVarPath = "/v1/companycert/type/list";
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
            if (typeIdList != null && typeIdList.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(typeIdList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = typeIdList; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1CompanycertTypeListPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyCertInfoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyCertInfoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyCertInfoList)));
            
        }

    }
}
