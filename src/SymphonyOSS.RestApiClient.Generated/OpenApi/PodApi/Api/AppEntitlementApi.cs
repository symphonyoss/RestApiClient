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
    public interface IAppEntitlementApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the list of application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>PodAppEntitlementList</returns>
        PodAppEntitlementList V1AdminAppEntitlementListGet (string sessionToken);

        /// <summary>
        /// Get the list of application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of PodAppEntitlementList</returns>
        ApiResponse<PodAppEntitlementList> V1AdminAppEntitlementListGetWithHttpInfo (string sessionToken);
        /// <summary>
        /// Update the application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>PodAppEntitlementList</returns>
        PodAppEntitlementList V1AdminAppEntitlementListPost (string sessionToken, PodAppEntitlementList payload);

        /// <summary>
        /// Update the application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of PodAppEntitlementList</returns>
        ApiResponse<PodAppEntitlementList> V1AdminAppEntitlementListPostWithHttpInfo (string sessionToken, PodAppEntitlementList payload);
        /// <summary>
        /// Get the list of application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>UserAppEntitlementList</returns>
        UserAppEntitlementList V1AdminUserUidAppEntitlementListGet (string sessionToken, long? uid);

        /// <summary>
        /// Get the list of application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>ApiResponse of UserAppEntitlementList</returns>
        ApiResponse<UserAppEntitlementList> V1AdminUserUidAppEntitlementListGetWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>UserAppEntitlementList</returns>
        UserAppEntitlementList V1AdminUserUidAppEntitlementListPost (string sessionToken, long? uid, UserAppEntitlementList payload);

        /// <summary>
        /// Update the application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserAppEntitlementList</returns>
        ApiResponse<UserAppEntitlementList> V1AdminUserUidAppEntitlementListPostWithHttpInfo (string sessionToken, long? uid, UserAppEntitlementList payload);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get the list of application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of PodAppEntitlementList</returns>
        System.Threading.Tasks.Task<PodAppEntitlementList> V1AdminAppEntitlementListGetAsync (string sessionToken);

        /// <summary>
        /// Get the list of application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (PodAppEntitlementList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PodAppEntitlementList>> V1AdminAppEntitlementListGetAsyncWithHttpInfo (string sessionToken);
        /// <summary>
        /// Update the application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of PodAppEntitlementList</returns>
        System.Threading.Tasks.Task<PodAppEntitlementList> V1AdminAppEntitlementListPostAsync (string sessionToken, PodAppEntitlementList payload);

        /// <summary>
        /// Update the application entitlements for the company
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (PodAppEntitlementList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PodAppEntitlementList>> V1AdminAppEntitlementListPostAsyncWithHttpInfo (string sessionToken, PodAppEntitlementList payload);
        /// <summary>
        /// Get the list of application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>Task of UserAppEntitlementList</returns>
        System.Threading.Tasks.Task<UserAppEntitlementList> V1AdminUserUidAppEntitlementListGetAsync (string sessionToken, long? uid);

        /// <summary>
        /// Get the list of application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>Task of ApiResponse (UserAppEntitlementList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAppEntitlementList>> V1AdminUserUidAppEntitlementListGetAsyncWithHttpInfo (string sessionToken, long? uid);
        /// <summary>
        /// Update the application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserAppEntitlementList</returns>
        System.Threading.Tasks.Task<UserAppEntitlementList> V1AdminUserUidAppEntitlementListPostAsync (string sessionToken, long? uid, UserAppEntitlementList payload);

        /// <summary>
        /// Update the application entitlements for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserAppEntitlementList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAppEntitlementList>> V1AdminUserUidAppEntitlementListPostAsyncWithHttpInfo (string sessionToken, long? uid, UserAppEntitlementList payload);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AppEntitlementApi : IAppEntitlementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEntitlementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppEntitlementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEntitlementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AppEntitlementApi(Configuration configuration = null)
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
        /// Get the list of application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>PodAppEntitlementList</returns>
        public PodAppEntitlementList V1AdminAppEntitlementListGet (string sessionToken)
        {
             ApiResponse<PodAppEntitlementList> localVarResponse = V1AdminAppEntitlementListGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of PodAppEntitlementList</returns>
        public ApiResponse< PodAppEntitlementList > V1AdminAppEntitlementListGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminAppEntitlementListGet");

            var localVarPath = "/v1/admin/app/entitlement/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PodAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PodAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PodAppEntitlementList)));
            
        }

        /// <summary>
        /// Get the list of application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of PodAppEntitlementList</returns>
        public async System.Threading.Tasks.Task<PodAppEntitlementList> V1AdminAppEntitlementListGetAsync (string sessionToken)
        {
             ApiResponse<PodAppEntitlementList> localVarResponse = await V1AdminAppEntitlementListGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (PodAppEntitlementList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PodAppEntitlementList>> V1AdminAppEntitlementListGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminAppEntitlementListGet");

            var localVarPath = "/v1/admin/app/entitlement/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PodAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PodAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PodAppEntitlementList)));
            
        }

        /// <summary>
        /// Update the application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>PodAppEntitlementList</returns>
        public PodAppEntitlementList V1AdminAppEntitlementListPost (string sessionToken, PodAppEntitlementList payload)
        {
             ApiResponse<PodAppEntitlementList> localVarResponse = V1AdminAppEntitlementListPostWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of PodAppEntitlementList</returns>
        public ApiResponse< PodAppEntitlementList > V1AdminAppEntitlementListPostWithHttpInfo (string sessionToken, PodAppEntitlementList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminAppEntitlementListPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling AppEntitlementApi->V1AdminAppEntitlementListPost");

            var localVarPath = "/v1/admin/app/entitlement/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PodAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PodAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PodAppEntitlementList)));
            
        }

        /// <summary>
        /// Update the application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of PodAppEntitlementList</returns>
        public async System.Threading.Tasks.Task<PodAppEntitlementList> V1AdminAppEntitlementListPostAsync (string sessionToken, PodAppEntitlementList payload)
        {
             ApiResponse<PodAppEntitlementList> localVarResponse = await V1AdminAppEntitlementListPostAsyncWithHttpInfo(sessionToken, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the application entitlements for the company 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (PodAppEntitlementList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PodAppEntitlementList>> V1AdminAppEntitlementListPostAsyncWithHttpInfo (string sessionToken, PodAppEntitlementList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminAppEntitlementListPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling AppEntitlementApi->V1AdminAppEntitlementListPost");

            var localVarPath = "/v1/admin/app/entitlement/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminAppEntitlementListPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PodAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PodAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PodAppEntitlementList)));
            
        }

        /// <summary>
        /// Get the list of application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>UserAppEntitlementList</returns>
        public UserAppEntitlementList V1AdminUserUidAppEntitlementListGet (string sessionToken, long? uid)
        {
             ApiResponse<UserAppEntitlementList> localVarResponse = V1AdminUserUidAppEntitlementListGetWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>ApiResponse of UserAppEntitlementList</returns>
        public ApiResponse< UserAppEntitlementList > V1AdminUserUidAppEntitlementListGetWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListGet");

            var localVarPath = "/v1/admin/user/{uid}/app/entitlement/list";
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
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAppEntitlementList)));
            
        }

        /// <summary>
        /// Get the list of application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>Task of UserAppEntitlementList</returns>
        public async System.Threading.Tasks.Task<UserAppEntitlementList> V1AdminUserUidAppEntitlementListGetAsync (string sessionToken, long? uid)
        {
             ApiResponse<UserAppEntitlementList> localVarResponse = await V1AdminUserUidAppEntitlementListGetAsyncWithHttpInfo(sessionToken, uid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <returns>Task of ApiResponse (UserAppEntitlementList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAppEntitlementList>> V1AdminUserUidAppEntitlementListGetAsyncWithHttpInfo (string sessionToken, long? uid)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListGet");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListGet");

            var localVarPath = "/v1/admin/user/{uid}/app/entitlement/list";
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
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAppEntitlementList)));
            
        }

        /// <summary>
        /// Update the application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>UserAppEntitlementList</returns>
        public UserAppEntitlementList V1AdminUserUidAppEntitlementListPost (string sessionToken, long? uid, UserAppEntitlementList payload)
        {
             ApiResponse<UserAppEntitlementList> localVarResponse = V1AdminUserUidAppEntitlementListPostWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>ApiResponse of UserAppEntitlementList</returns>
        public ApiResponse< UserAppEntitlementList > V1AdminUserUidAppEntitlementListPostWithHttpInfo (string sessionToken, long? uid, UserAppEntitlementList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListPost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListPost");

            var localVarPath = "/v1/admin/user/{uid}/app/entitlement/list";
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
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAppEntitlementList)));
            
        }

        /// <summary>
        /// Update the application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>Task of UserAppEntitlementList</returns>
        public async System.Threading.Tasks.Task<UserAppEntitlementList> V1AdminUserUidAppEntitlementListPostAsync (string sessionToken, long? uid, UserAppEntitlementList payload)
        {
             ApiResponse<UserAppEntitlementList> localVarResponse = await V1AdminUserUidAppEntitlementListPostAsyncWithHttpInfo(sessionToken, uid, payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the application entitlements for this user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="uid">User ID as a decimal integer</param>
        /// <param name="payload"></param>
        /// <returns>Task of ApiResponse (UserAppEntitlementList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAppEntitlementList>> V1AdminUserUidAppEntitlementListPostAsyncWithHttpInfo (string sessionToken, long? uid, UserAppEntitlementList payload)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListPost");
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling AppEntitlementApi->V1AdminUserUidAppEntitlementListPost");

            var localVarPath = "/v1/admin/user/{uid}/app/entitlement/list";
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
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminUserUidAppEntitlementListPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAppEntitlementList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAppEntitlementList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAppEntitlementList)));
            
        }

    }
}
