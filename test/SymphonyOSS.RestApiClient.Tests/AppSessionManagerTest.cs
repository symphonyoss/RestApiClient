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

using System.Threading;

namespace SymphonyOSS.RestApiClient.Tests
{
    using Authentication;
    using Generated.OpenApi.AuthenticatorApi;
    using Moq;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;
    using Xunit;

    public class AppSessionManagerTest
    {
        private readonly X509Certificate2 _certificate;

        private readonly Mock<IAppClient> _sessionAuthApiMock;

        public AppSessionManagerTest()
        {
            _certificate = new Mock<X509Certificate2>().Object;
            _sessionAuthApiMock = new Mock<IAppClient>();
        }

        [Fact]
        public void EnsureTokens_are_returned_without_explicitly_calling_GenerateTokens()
        {
            _sessionAuthApiMock.Setup(obj => obj.V1AuthenticateAsync(default(CancellationToken))).Returns(Task.FromResult(new Token() {Name = "appSessionToken", Token1 = "as1"}));
            _sessionAuthApiMock.Setup(obj => obj.V1UserAuthenticateAsync(0, "as1", CancellationToken.None)).Returns(Task.FromResult(new OboAuthResponse(){SessionToken = "us1"}));
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
            _sessionAuthApiMock.Setup(obj => obj.V1AuthenticateAsync(CancellationToken.None)).Returns(() =>
            {
                ++appSessionTokenCounter;
                return Task.FromResult(new Token() {Name = "appSessionToken", Token1 = "as" + appSessionTokenCounter});
            });
            var userSessionTokenCounter = 0;
            _sessionAuthApiMock.Setup(obj => obj.V1UserAuthenticateAsync(It.IsAny<long>(), It.IsAny<string>(), It.IsAny<CancellationToken>())).Returns(() =>
            {
                ++userSessionTokenCounter;
                return Task.FromResult( new OboAuthResponse() { SessionToken = "us" + userSessionTokenCounter});
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
