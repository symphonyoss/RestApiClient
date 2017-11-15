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

using Microsoft.Extensions.Logging;
using SymphonyOSS.RestApiClient.Logging;

namespace SymphonyOSS.RestApiClient.Api.AgentApi
{
    using System;
    using Authentication;
    using Entities;
    using Generated.OpenApi.AgentApi;
    using System.Net.Http;
    using System.IO;
    using Stream = System.IO.Stream;

    /// <summary>
    /// Provides methods for getting attachments from messages and uploading attachments to streams, by
    /// encapsulating <see cref="Generated.OpenApi.AgentApi.Api.AttachmentsApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class AttachmentsApi
    {
        private readonly Generated.OpenApi.AgentApi.StreamClient _streamApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        private readonly ILogger _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi" /> class.
        /// See <see cref="Factories.AgentApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public AttachmentsApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _streamApi = new Generated.OpenApi.AgentApi.StreamClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
            _log = ApiLogging.LoggerFactory?.CreateLogger<AttachmentsApi>();
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
                return UploadAttachment(sid, Path.GetFileName(file), stream);
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
            try
            {
                var fileParameter = new FileParameter(file, filename);
                var attachmentInfo = _apiExecutor.Execute(_streamApi.V1AttachmentCreateAsync, sid,
                    _authTokens.SessionToken,
                    _authTokens.KeyManagerToken, fileParameter);

                return new Attachment(attachmentInfo.Id, attachmentInfo.Name, attachmentInfo.Size);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while attempting to upload an attachment to stream {sid}.", sid);
                throw;
            }
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
            try
            {
                var fileResponse = _apiExecutor.Execute(_streamApi.V1AttachmentAsync, sid, fileId, messageId, _authTokens.SessionToken, _authTokens.KeyManagerToken);

                var reader = new StreamReader(fileResponse.Stream);
                var base64String = reader.ReadToEnd();
                return Convert.FromBase64String(base64String);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while attempting to download an attachment from stream {sid}.", sid);
                throw;
            }
        }
    }
}
