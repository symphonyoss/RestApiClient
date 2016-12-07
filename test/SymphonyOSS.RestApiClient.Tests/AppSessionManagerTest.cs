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

namespace SymphonyOSS.RestApiClient.Tests
{
    using Authentication;
    using Generated.OpenApi.AuthenticatorApi.Api;
    using Generated.OpenApi.AuthenticatorApi.Model;
    using Moq;
    using System.Security.Cryptography.X509Certificates;
    using Xunit;

    public class AppSessionManagerTest
    {
        private readonly X509Certificate2 _certificate;

        private readonly Mock<IAuthenticationApi> _sessionAuthApiMock;

        public AppSessionManagerTest()
        {
            _certificate = new Mock<X509Certificate2>().Object;
            _sessionAuthApiMock = new Mock<IAuthenticationApi>();
        }

        [Fact]
        public void EnsureTokens_are_returned_without_explicitly_calling_GenerateTokens()
        {
            _sessionAuthApiMock.Setup(obj => obj.V1AppAuthenticatePost()).Returns(new Token("appSessionToken", "as1"));
            _sessionAuthApiMock.Setup(obj => obj.V1AppUserUidAuthenticatePost(0, "as1")).Returns(new OboAuthResponse("us1", "agentUrl"));
            var appSessionManager = new AppSessionManager(_sessionAuthApiMock.Object, _certificate);
            var sessionToken = appSessionManager.SessionToken;
            var keyManagerToken = appSessionManager.KeyManagerToken;
            Assert.Equal("us1", sessionToken);
            Assert.Null(keyManagerToken);
        }

        [Fact]
        public void EnsureGenerateTokens_regenerate_tokens_every_call()
        {
            var appSessionTokenCounter = 0;
            _sessionAuthApiMock.Setup(obj => obj.V1AppAuthenticatePost()).Returns(() =>
            {
                ++appSessionTokenCounter;
                return new Token("appSessionToken", "as" + appSessionTokenCounter);
            });
            var userSessionTokenCounter = 0;
            _sessionAuthApiMock.Setup(obj => obj.V1AppUserUidAuthenticatePost(It.IsAny<int>(), It.IsAny<string>())).Returns(() =>
            {
                ++userSessionTokenCounter;
                return new OboAuthResponse("us" + userSessionTokenCounter, "agentUrl");
            });
            var appSessionManager = new AppSessionManager(_sessionAuthApiMock.Object, _certificate);
            Assert.Equal("us1", appSessionManager.SessionToken);
            Assert.Null(appSessionManager.KeyManagerToken);

            appSessionManager.GenerateTokens();
            Assert.Equal("us2", appSessionManager.SessionToken);
            Assert.Null(appSessionManager.KeyManagerToken);
        }

    }
}
