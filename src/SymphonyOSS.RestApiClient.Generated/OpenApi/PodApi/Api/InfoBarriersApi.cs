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
    public interface IInfoBarriersApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Add members to an Information Barrier group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>BulkActionResult</returns>
        BulkActionResult V1AdminGroupGidMembershipAddPost (string gid, string sessionToken, IntegerList users);

        /// <summary>
        /// Add members to an Information Barrier group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>ApiResponse of BulkActionResult</returns>
        ApiResponse<BulkActionResult> V1AdminGroupGidMembershipAddPostWithHttpInfo (string gid, string sessionToken, IntegerList users);
        /// <summary>
        /// Get the list of userids in this Information Barrier Group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>IntegerList</returns>
        IntegerList V1AdminGroupGidMembershipListGet (string gid, string sessionToken);

        /// <summary>
        /// Get the list of userids in this Information Barrier Group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of IntegerList</returns>
        ApiResponse<IntegerList> V1AdminGroupGidMembershipListGetWithHttpInfo (string gid, string sessionToken);
        /// <summary>
        /// Remove members from an Information Barrier group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>BulkActionResult</returns>
        BulkActionResult V1AdminGroupGidMembershipRemovePost (string gid, string sessionToken, IntegerList users);

        /// <summary>
        /// Remove members from an Information Barrier group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>ApiResponse of BulkActionResult</returns>
        ApiResponse<BulkActionResult> V1AdminGroupGidMembershipRemovePostWithHttpInfo (string gid, string sessionToken, IntegerList users);
        /// <summary>
        /// Get a list of all Information Barrier Groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>GroupList</returns>
        GroupList V1AdminGroupListGet (string sessionToken);

        /// <summary>
        /// Get a list of all Information Barrier Groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of GroupList</returns>
        ApiResponse<GroupList> V1AdminGroupListGetWithHttpInfo (string sessionToken);
        /// <summary>
        /// Get all Information Policies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>PolicyList</returns>
        PolicyList V1AdminPolicyListGet (string sessionToken);

        /// <summary>
        /// Get all Information Policies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of PolicyList</returns>
        ApiResponse<PolicyList> V1AdminPolicyListGetWithHttpInfo (string sessionToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add members to an Information Barrier group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of BulkActionResult</returns>
        System.Threading.Tasks.Task<BulkActionResult> V1AdminGroupGidMembershipAddPostAsync (string gid, string sessionToken, IntegerList users);

        /// <summary>
        /// Add members to an Information Barrier group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of ApiResponse (BulkActionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<BulkActionResult>> V1AdminGroupGidMembershipAddPostAsyncWithHttpInfo (string gid, string sessionToken, IntegerList users);
        /// <summary>
        /// Get the list of userids in this Information Barrier Group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of IntegerList</returns>
        System.Threading.Tasks.Task<IntegerList> V1AdminGroupGidMembershipListGetAsync (string gid, string sessionToken);

        /// <summary>
        /// Get the list of userids in this Information Barrier Group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (IntegerList)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerList>> V1AdminGroupGidMembershipListGetAsyncWithHttpInfo (string gid, string sessionToken);
        /// <summary>
        /// Remove members from an Information Barrier group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of BulkActionResult</returns>
        System.Threading.Tasks.Task<BulkActionResult> V1AdminGroupGidMembershipRemovePostAsync (string gid, string sessionToken, IntegerList users);

        /// <summary>
        /// Remove members from an Information Barrier group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of ApiResponse (BulkActionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<BulkActionResult>> V1AdminGroupGidMembershipRemovePostAsyncWithHttpInfo (string gid, string sessionToken, IntegerList users);
        /// <summary>
        /// Get a list of all Information Barrier Groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of GroupList</returns>
        System.Threading.Tasks.Task<GroupList> V1AdminGroupListGetAsync (string sessionToken);

        /// <summary>
        /// Get a list of all Information Barrier Groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (GroupList)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupList>> V1AdminGroupListGetAsyncWithHttpInfo (string sessionToken);
        /// <summary>
        /// Get all Information Policies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of PolicyList</returns>
        System.Threading.Tasks.Task<PolicyList> V1AdminPolicyListGetAsync (string sessionToken);

        /// <summary>
        /// Get all Information Policies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (PolicyList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PolicyList>> V1AdminPolicyListGetAsyncWithHttpInfo (string sessionToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InfoBarriersApi : IInfoBarriersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoBarriersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InfoBarriersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoBarriersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InfoBarriersApi(Configuration configuration = null)
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
        /// Add members to an Information Barrier group. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>BulkActionResult</returns>
        public BulkActionResult V1AdminGroupGidMembershipAddPost (string gid, string sessionToken, IntegerList users)
        {
             ApiResponse<BulkActionResult> localVarResponse = V1AdminGroupGidMembershipAddPostWithHttpInfo(gid, sessionToken, users);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add members to an Information Barrier group. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>ApiResponse of BulkActionResult</returns>
        public ApiResponse< BulkActionResult > V1AdminGroupGidMembershipAddPostWithHttpInfo (string gid, string sessionToken, IntegerList users)
        {
            // verify the required parameter 'gid' is set
            if (gid == null)
                throw new ApiException(400, "Missing required parameter 'gid' when calling InfoBarriersApi->V1AdminGroupGidMembershipAddPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupGidMembershipAddPost");
            // verify the required parameter 'users' is set
            if (users == null)
                throw new ApiException(400, "Missing required parameter 'users' when calling InfoBarriersApi->V1AdminGroupGidMembershipAddPost");

            var localVarPath = "/v1/admin/group/{gid}/membership/add";
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
            if (gid != null) localVarPathParams.Add("gid", Configuration.ApiClient.ParameterToString(gid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (users.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(users); // http body (model) parameter
            }
            else
            {
                localVarPostBody = users; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipAddPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipAddPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkActionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkActionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkActionResult)));
            
        }

        /// <summary>
        /// Add members to an Information Barrier group. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of BulkActionResult</returns>
        public async System.Threading.Tasks.Task<BulkActionResult> V1AdminGroupGidMembershipAddPostAsync (string gid, string sessionToken, IntegerList users)
        {
             ApiResponse<BulkActionResult> localVarResponse = await V1AdminGroupGidMembershipAddPostAsyncWithHttpInfo(gid, sessionToken, users);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add members to an Information Barrier group. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of ApiResponse (BulkActionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BulkActionResult>> V1AdminGroupGidMembershipAddPostAsyncWithHttpInfo (string gid, string sessionToken, IntegerList users)
        {
            // verify the required parameter 'gid' is set
            if (gid == null)
                throw new ApiException(400, "Missing required parameter 'gid' when calling InfoBarriersApi->V1AdminGroupGidMembershipAddPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupGidMembershipAddPost");
            // verify the required parameter 'users' is set
            if (users == null)
                throw new ApiException(400, "Missing required parameter 'users' when calling InfoBarriersApi->V1AdminGroupGidMembershipAddPost");

            var localVarPath = "/v1/admin/group/{gid}/membership/add";
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
            if (gid != null) localVarPathParams.Add("gid", Configuration.ApiClient.ParameterToString(gid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (users.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(users); // http body (model) parameter
            }
            else
            {
                localVarPostBody = users; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipAddPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipAddPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkActionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkActionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkActionResult)));
            
        }

        /// <summary>
        /// Get the list of userids in this Information Barrier Group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>IntegerList</returns>
        public IntegerList V1AdminGroupGidMembershipListGet (string gid, string sessionToken)
        {
             ApiResponse<IntegerList> localVarResponse = V1AdminGroupGidMembershipListGetWithHttpInfo(gid, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of userids in this Information Barrier Group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of IntegerList</returns>
        public ApiResponse< IntegerList > V1AdminGroupGidMembershipListGetWithHttpInfo (string gid, string sessionToken)
        {
            // verify the required parameter 'gid' is set
            if (gid == null)
                throw new ApiException(400, "Missing required parameter 'gid' when calling InfoBarriersApi->V1AdminGroupGidMembershipListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupGidMembershipListGet");

            var localVarPath = "/v1/admin/group/{gid}/membership/list";
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
            if (gid != null) localVarPathParams.Add("gid", Configuration.ApiClient.ParameterToString(gid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegerList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerList)));
            
        }

        /// <summary>
        /// Get the list of userids in this Information Barrier Group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of IntegerList</returns>
        public async System.Threading.Tasks.Task<IntegerList> V1AdminGroupGidMembershipListGetAsync (string gid, string sessionToken)
        {
             ApiResponse<IntegerList> localVarResponse = await V1AdminGroupGidMembershipListGetAsyncWithHttpInfo(gid, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of userids in this Information Barrier Group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (IntegerList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegerList>> V1AdminGroupGidMembershipListGetAsyncWithHttpInfo (string gid, string sessionToken)
        {
            // verify the required parameter 'gid' is set
            if (gid == null)
                throw new ApiException(400, "Missing required parameter 'gid' when calling InfoBarriersApi->V1AdminGroupGidMembershipListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupGidMembershipListGet");

            var localVarPath = "/v1/admin/group/{gid}/membership/list";
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
            if (gid != null) localVarPathParams.Add("gid", Configuration.ApiClient.ParameterToString(gid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegerList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerList)));
            
        }

        /// <summary>
        /// Remove members from an Information Barrier group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>BulkActionResult</returns>
        public BulkActionResult V1AdminGroupGidMembershipRemovePost (string gid, string sessionToken, IntegerList users)
        {
             ApiResponse<BulkActionResult> localVarResponse = V1AdminGroupGidMembershipRemovePostWithHttpInfo(gid, sessionToken, users);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove members from an Information Barrier group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>ApiResponse of BulkActionResult</returns>
        public ApiResponse< BulkActionResult > V1AdminGroupGidMembershipRemovePostWithHttpInfo (string gid, string sessionToken, IntegerList users)
        {
            // verify the required parameter 'gid' is set
            if (gid == null)
                throw new ApiException(400, "Missing required parameter 'gid' when calling InfoBarriersApi->V1AdminGroupGidMembershipRemovePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupGidMembershipRemovePost");
            // verify the required parameter 'users' is set
            if (users == null)
                throw new ApiException(400, "Missing required parameter 'users' when calling InfoBarriersApi->V1AdminGroupGidMembershipRemovePost");

            var localVarPath = "/v1/admin/group/{gid}/membership/remove";
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
            if (gid != null) localVarPathParams.Add("gid", Configuration.ApiClient.ParameterToString(gid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (users.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(users); // http body (model) parameter
            }
            else
            {
                localVarPostBody = users; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipRemovePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipRemovePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkActionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkActionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkActionResult)));
            
        }

        /// <summary>
        /// Remove members from an Information Barrier group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of BulkActionResult</returns>
        public async System.Threading.Tasks.Task<BulkActionResult> V1AdminGroupGidMembershipRemovePostAsync (string gid, string sessionToken, IntegerList users)
        {
             ApiResponse<BulkActionResult> localVarResponse = await V1AdminGroupGidMembershipRemovePostAsyncWithHttpInfo(gid, sessionToken, users);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove members from an Information Barrier group 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gid">URL-Safe encoded Group ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="users"></param>
        /// <returns>Task of ApiResponse (BulkActionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BulkActionResult>> V1AdminGroupGidMembershipRemovePostAsyncWithHttpInfo (string gid, string sessionToken, IntegerList users)
        {
            // verify the required parameter 'gid' is set
            if (gid == null)
                throw new ApiException(400, "Missing required parameter 'gid' when calling InfoBarriersApi->V1AdminGroupGidMembershipRemovePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupGidMembershipRemovePost");
            // verify the required parameter 'users' is set
            if (users == null)
                throw new ApiException(400, "Missing required parameter 'users' when calling InfoBarriersApi->V1AdminGroupGidMembershipRemovePost");

            var localVarPath = "/v1/admin/group/{gid}/membership/remove";
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
            if (gid != null) localVarPathParams.Add("gid", Configuration.ApiClient.ParameterToString(gid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (users.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(users); // http body (model) parameter
            }
            else
            {
                localVarPostBody = users; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipRemovePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupGidMembershipRemovePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkActionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkActionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkActionResult)));
            
        }

        /// <summary>
        /// Get a list of all Information Barrier Groups 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>GroupList</returns>
        public GroupList V1AdminGroupListGet (string sessionToken)
        {
             ApiResponse<GroupList> localVarResponse = V1AdminGroupListGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of all Information Barrier Groups 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of GroupList</returns>
        public ApiResponse< GroupList > V1AdminGroupListGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupListGet");

            var localVarPath = "/v1/admin/group/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GroupList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupList)));
            
        }

        /// <summary>
        /// Get a list of all Information Barrier Groups 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of GroupList</returns>
        public async System.Threading.Tasks.Task<GroupList> V1AdminGroupListGetAsync (string sessionToken)
        {
             ApiResponse<GroupList> localVarResponse = await V1AdminGroupListGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of all Information Barrier Groups 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (GroupList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupList>> V1AdminGroupListGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminGroupListGet");

            var localVarPath = "/v1/admin/group/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminGroupListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GroupList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupList)));
            
        }

        /// <summary>
        /// Get all Information Policies 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>PolicyList</returns>
        public PolicyList V1AdminPolicyListGet (string sessionToken)
        {
             ApiResponse<PolicyList> localVarResponse = V1AdminPolicyListGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Information Policies 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of PolicyList</returns>
        public ApiResponse< PolicyList > V1AdminPolicyListGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminPolicyListGet");

            var localVarPath = "/v1/admin/policy/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminPolicyListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminPolicyListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyList)));
            
        }

        /// <summary>
        /// Get all Information Policies 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of PolicyList</returns>
        public async System.Threading.Tasks.Task<PolicyList> V1AdminPolicyListGetAsync (string sessionToken)
        {
             ApiResponse<PolicyList> localVarResponse = await V1AdminPolicyListGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Information Policies 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (PolicyList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PolicyList>> V1AdminPolicyListGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling InfoBarriersApi->V1AdminPolicyListGet");

            var localVarPath = "/v1/admin/policy/list";
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
                throw new ApiException (localVarStatusCode, "Error calling V1AdminPolicyListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1AdminPolicyListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyList)));
            
        }

    }
}
