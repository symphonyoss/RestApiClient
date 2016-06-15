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

using System.IO;

namespace SymphonyOSS.RestApiClient.Tests
{
    using System;
    using Api;
    using Api.AgentApi;
    using Authentication;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;
    using Moq;
    using Xunit;

    public class AttachmentsApiTest
    {
        private readonly Mock<IApiExecutor> _apiExecutorMock;

        private readonly AttachmentsApi _attachmentsApi;

        public AttachmentsApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            sessionManagerMock.Setup(obj => obj.KeyManagerToken).Returns("keyManagerToken");
            var configuration = new Configuration();
            _apiExecutorMock = new Mock<IApiExecutor>();
            _attachmentsApi = new AttachmentsApi(sessionManagerMock.Object, configuration, _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureDownloadAttachment_uses_retry_strategy()
        {
            const string sid = "sid";
            const string messageId = "message";
            const string fileId = "file";
            _attachmentsApi.DownloadAttachment(sid, messageId, fileId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, string, string, string, byte[]>>(), sid, fileId, messageId, "sessionToken", "keyManagerToken"));
        }

        [Fact]
        public void EnsureUploadAttachment_uses_retry_strategy()
        {
            const string sid = "sid";
            var file = new Mock<Stream>().Object;
            _attachmentsApi.UploadAttachment(sid, file);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, string, Stream, AttachmentInfo>>(), sid, "sessionToken", "keyManagerToken", file));
        }
    }
}
