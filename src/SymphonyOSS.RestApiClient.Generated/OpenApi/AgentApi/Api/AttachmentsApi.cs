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
    public interface IAttachmentsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Upload an attachment.
        /// </summary>
        /// <remarks>
        /// Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>AttachmentInfo</returns>
        AttachmentInfo V1StreamSidAttachmentCreatePost (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file);

        /// <summary>
        /// Upload an attachment.
        /// </summary>
        /// <remarks>
        /// Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>ApiResponse of AttachmentInfo</returns>
        ApiResponse<AttachmentInfo> V1StreamSidAttachmentCreatePostWithHttpInfo (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file);
        /// <summary>
        /// Download an attachment.
        /// </summary>
        /// <remarks>
        /// Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>byte[]</returns>
        byte[] V1StreamSidAttachmentGet (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken);

        /// <summary>
        /// Download an attachment.
        /// </summary>
        /// <remarks>
        /// Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> V1StreamSidAttachmentGetWithHttpInfo (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Upload an attachment.
        /// </summary>
        /// <remarks>
        /// Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>Task of AttachmentInfo</returns>
        System.Threading.Tasks.Task<AttachmentInfo> V1StreamSidAttachmentCreatePostAsync (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file);

        /// <summary>
        /// Upload an attachment.
        /// </summary>
        /// <remarks>
        /// Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>Task of ApiResponse (AttachmentInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttachmentInfo>> V1StreamSidAttachmentCreatePostAsyncWithHttpInfo (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file);
        /// <summary>
        /// Download an attachment.
        /// </summary>
        /// <remarks>
        /// Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> V1StreamSidAttachmentGetAsync (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken);

        /// <summary>
        /// Download an attachment.
        /// </summary>
        /// <remarks>
        /// Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> V1StreamSidAttachmentGetAsyncWithHttpInfo (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttachmentsApi : IAttachmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttachmentsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AttachmentsApi(Configuration configuration = null)
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
        /// Upload an attachment. Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>AttachmentInfo</returns>
        public AttachmentInfo V1StreamSidAttachmentCreatePost (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file)
        {
             ApiResponse<AttachmentInfo> localVarResponse = V1StreamSidAttachmentCreatePostWithHttpInfo(sid, sessionToken, keyManagerToken, file);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload an attachment. Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>ApiResponse of AttachmentInfo</returns>
        public ApiResponse< AttachmentInfo > V1StreamSidAttachmentCreatePostWithHttpInfo (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");

            var localVarPath = "/v1/stream/{sid}/attachment/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
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
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (file != null) localVarFileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttachmentInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachmentInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentInfo)));
            
        }

        /// <summary>
        /// Upload an attachment. Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>Task of AttachmentInfo</returns>
        public async System.Threading.Tasks.Task<AttachmentInfo> V1StreamSidAttachmentCreatePostAsync (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file)
        {
             ApiResponse<AttachmentInfo> localVarResponse = await V1StreamSidAttachmentCreatePostAsyncWithHttpInfo(sid, sessionToken, keyManagerToken, file);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upload an attachment. Upload an attachment to the given stream. The stream can be a chatroom,\nan IM or a multiparty IM.\n\nOnce uploaded, you can use this attachment on a message you send in that stream.\n\nIf the attachment is uploaded then 200 is returned.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <param name="file">The attachment body.</param>
        /// <returns>Task of ApiResponse (AttachmentInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttachmentInfo>> V1StreamSidAttachmentCreatePostAsyncWithHttpInfo (string sid, string sessionToken, string keyManagerToken, System.IO.Stream file)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling AttachmentsApi->V1StreamSidAttachmentCreatePost");

            var localVarPath = "/v1/stream/{sid}/attachment/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
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
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter
            if (file != null) localVarFileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentCreatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentCreatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttachmentInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachmentInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentInfo)));
            
        }

        /// <summary>
        /// Download an attachment. Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>byte[]</returns>
        public byte[] V1StreamSidAttachmentGet (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken)
        {
             ApiResponse<byte[]> localVarResponse = V1StreamSidAttachmentGetWithHttpInfo(sid, fileId, messageId, sessionToken, keyManagerToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download an attachment. Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > V1StreamSidAttachmentGetWithHttpInfo (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling AttachmentsApi->V1StreamSidAttachmentGet");

            var localVarPath = "/v1/stream/{sid}/attachment";
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
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (fileId != null) localVarQueryParams.Add("fileId", Configuration.ApiClient.ParameterToString(fileId)); // query parameter
            if (messageId != null) localVarQueryParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }

        /// <summary>
        /// Download an attachment. Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> V1StreamSidAttachmentGetAsync (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken)
        {
             ApiResponse<byte[]> localVarResponse = await V1StreamSidAttachmentGetAsyncWithHttpInfo(sid, fileId, messageId, sessionToken, keyManagerToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download an attachment. Downloads the attachment body by the attachment ID, stream ID, and message ID.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">Stream ID</param>
        /// <param name="fileId">The attachment ID</param>
        /// <param name="messageId">The ID of the message containing the attachment</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="keyManagerToken">Key Manager authentication token.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> V1StreamSidAttachmentGetAsyncWithHttpInfo (string sid, string fileId, string messageId, string sessionToken, string keyManagerToken)
        {
            // verify the required parameter 'sid' is set
            if (sid == null)
                throw new ApiException(400, "Missing required parameter 'sid' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling AttachmentsApi->V1StreamSidAttachmentGet");
            // verify the required parameter 'keyManagerToken' is set
            if (keyManagerToken == null)
                throw new ApiException(400, "Missing required parameter 'keyManagerToken' when calling AttachmentsApi->V1StreamSidAttachmentGet");

            var localVarPath = "/v1/stream/{sid}/attachment";
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
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sid != null) localVarPathParams.Add("sid", Configuration.ApiClient.ParameterToString(sid)); // path parameter
            if (fileId != null) localVarQueryParams.Add("fileId", Configuration.ApiClient.ParameterToString(fileId)); // query parameter
            if (messageId != null) localVarQueryParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (keyManagerToken != null) localVarHeaderParams.Add("keyManagerToken", Configuration.ApiClient.ParameterToString(keyManagerToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1StreamSidAttachmentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }

    }
}
