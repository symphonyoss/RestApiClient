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
using SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client;
using SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Model;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi
    {
        #region Synchronous Operations
        /// <summary>
        /// PROVISIONAL - Authenticate an application in a delegated context.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        Token V1AppAuthenticatePost ();

        /// <summary>
        /// PROVISIONAL - Authenticate an application in a delegated context.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> V1AppAuthenticatePostWithHttpInfo ();
        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>Token</returns>
        Token V1AppUsernameUsernameAuthenticatePost (string username, string sessionToken);

        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> V1AppUsernameUsernameAuthenticatePostWithHttpInfo (string username, string sessionToken);
        /// <summary>
        /// Authenticate.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        Token V1AuthenticatePost ();

        /// <summary>
        /// Authenticate.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> V1AuthenticatePostWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// PROVISIONAL - Authenticate an application in a delegated context.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> V1AppAuthenticatePostAsync ();

        /// <summary>
        /// PROVISIONAL - Authenticate an application in a delegated context.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> V1AppAuthenticatePostAsyncWithHttpInfo ();
        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> V1AppUsernameUsernameAuthenticatePostAsync (string username, string sessionToken);

        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> V1AppUsernameUsernameAuthenticatePostAsyncWithHttpInfo (string username, string sessionToken);
        /// <summary>
        /// Authenticate.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> V1AuthenticatePostAsync ();

        /// <summary>
        /// Authenticate.
        /// </summary>
        /// <remarks>
        /// Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> V1AuthenticatePostAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationApi : IAuthenticationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Configuration configuration = null)
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
        /// PROVISIONAL - Authenticate an application in a delegated context. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        public Token V1AppAuthenticatePost ()
        {
             ApiResponse<Token> localVarResponse = V1AppAuthenticatePostWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL - Authenticate an application in a delegated context. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > V1AppAuthenticatePostWithHttpInfo ()
        {

            var localVarPath = "/v1/app/authenticate";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AppAuthenticatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AppAuthenticatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        /// <summary>
        /// PROVISIONAL - Authenticate an application in a delegated context. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> V1AppAuthenticatePostAsync ()
        {
             ApiResponse<Token> localVarResponse = await V1AppAuthenticatePostAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL - Authenticate an application in a delegated context. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return an application session.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> V1AppAuthenticatePostAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/app/authenticate";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AppAuthenticatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AppAuthenticatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>Token</returns>
        public Token V1AppUsernameUsernameAuthenticatePost (string username, string sessionToken)
        {
             ApiResponse<Token> localVarResponse = V1AppUsernameUsernameAuthenticatePostWithHttpInfo(username, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > V1AppUsernameUsernameAuthenticatePostWithHttpInfo (string username, string sessionToken)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling AuthenticationApi->V1AppUsernameUsernameAuthenticatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AuthenticationApi->V1AppUsernameUsernameAuthenticatePost");

            var localVarPath = "/v1/app/username/{username}/authenticate";
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
            if (username != null) localVarPathParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AppUsernameUsernameAuthenticatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AppUsernameUsernameAuthenticatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> V1AppUsernameUsernameAuthenticatePostAsync (string username, string sessionToken)
        {
             ApiResponse<Token> localVarResponse = await V1AppUsernameUsernameAuthenticatePostAsyncWithHttpInfo(username, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PROVISIONAL - Authenicate an application in a delegated context to act on behalf of a user 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">User login name</param>
        /// <param name="sessionToken">Authorization token obtains from app/authenicate API</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> V1AppUsernameUsernameAuthenticatePostAsyncWithHttpInfo (string username, string sessionToken)
        {
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling AuthenticationApi->V1AppUsernameUsernameAuthenticatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AuthenticationApi->V1AppUsernameUsernameAuthenticatePost");

            var localVarPath = "/v1/app/username/{username}/authenticate";
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
            if (username != null) localVarPathParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AppUsernameUsernameAuthenticatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AppUsernameUsernameAuthenticatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        /// <summary>
        /// Authenticate. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        public Token V1AuthenticatePost ()
        {
             ApiResponse<Token> localVarResponse = V1AuthenticatePostWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticate. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > V1AuthenticatePostWithHttpInfo ()
        {

            var localVarPath = "/v1/authenticate";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AuthenticatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AuthenticatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        /// <summary>
        /// Authenticate. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> V1AuthenticatePostAsync ()
        {
             ApiResponse<Token> localVarResponse = await V1AuthenticatePostAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Authenticate. Based on the SSL client certificate presented by the TLS layer, authenticate\nthe API caller and return a session token.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> V1AuthenticatePostAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/authenticate";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AuthenticatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AuthenticatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

    }
}
