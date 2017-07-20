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

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using System;
    using Authentication;
    using Entities;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;
    using System.IO;
    using RestSharp.Portable;
    using Stream = System.IO.Stream;

    /// <summary>
    /// Provides methods for getting attachments from messages and uploading attachments to streams, by
    /// encapsulating <see cref="Generated.OpenApi.AgentApi.Api.AttachmentsApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class AttachmentsApi
    {
        private readonly Generated.OpenApi.AgentApi.Api.IAttachmentsApi _attachmentsApi;

        private readonly Configuration _configuration;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public AttachmentsApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _attachmentsApi = new Generated.OpenApi.AgentApi.Api.AttachmentsApi(configuration);
            _configuration = configuration;
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Uploads an attachment to an existing stream. After the attachment is uploaded it can
        /// be used on a message in that stream.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="file">The path of the file to upload as an attachment.</param>
        /// <returns>Attachment info.</returns>
        public Attachment UploadAttachment(string sid, string file)
        {
            using (var stream = File.OpenRead(file))
            {
                return _apiExecutor.Execute(UploadAttachment, sid, Path.GetFileName(file), stream);
            }
        }

        /// <summary>
        /// Uploads an attachment to an existing stream. After the attachment is uploaded it can
        /// be used on a message in that stream.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="filename">The filename.</param>
        /// <param name="file">The stream of the file to upload as an attachment.</param>
        /// <returns>Attachment info.</returns>
        public Attachment UploadAttachment(string sid, string filename, Stream file)
        {
            var request = new RestRequest("v1/stream/" + sid + "/attachment/create", Method.POST);
            request.AddHeader("sessionToken", _authTokens.SessionToken);
            request.AddHeader("keyManagerToken", _authTokens.KeyManagerToken);
            request.AddFile("file", file, filename, "application/octet-stream");

            var apiClient = _configuration.ApiClient;
            var response = apiClient.RestClient.Execute(request);
            var attachmentInfo = (AttachmentInfo)apiClient.Deserialize(response.Result, typeof(AttachmentInfo));
            return new Attachment(attachmentInfo.Id, attachmentInfo.Name, attachmentInfo.Size ?? -1);
        }

        /// <summary>
        /// Downloads an attachment from a message.
        /// </summary>
        /// <param name="sid">Stream ID.</param>
        /// <param name="messageId">The ID of the message containing the attachment.</param>
        /// <param name="fileId">Attachment ID.</param>
        /// <returns>The contents of the attached file.</returns>
        public byte[] DownloadAttachment(string sid, string messageId, string fileId)
        {
            var base64Bytes = _apiExecutor.Execute(_attachmentsApi.V1StreamSidAttachmentGet, sid, fileId, messageId, _authTokens.SessionToken, _authTokens.KeyManagerToken);
            var base64String = System.Text.Encoding.UTF8.GetString(base64Bytes);
            return Convert.FromBase64String(base64String);
        }
    }
}
