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
    using Generated.OpenApi.AuthenticatorApi;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using System.Security.Cryptography.X509Certificates;
    using Xunit;

    public class UserSessionManagerTest
    {
        private readonly X509Certificate2 _certificate;

        private readonly Mock<IAuthenticateClient> _sessionAuthApiMock;

        private readonly Mock<IAuthenticateClient> _keyAuthApiMock;

        public UserSessionManagerTest()
        {
            _certificate = new Mock<X509Certificate2>().Object;
            _sessionAuthApiMock = new Mock<IAuthenticateClient>();
            _keyAuthApiMock = new Mock<IAuthenticateClient>();
        }

        [Fact]
        public void EnsureTokens_are_returned_without_explicitly_calling_GenerateTokens()
        {
            _sessionAuthApiMock.Setup(obj => obj.V1Async(default(CancellationToken))).Returns(Task.FromResult(new Token() {Name = "sessionToken",Token1 = "s1"}));
            _keyAuthApiMock.Setup(obj => obj.V1Async(default(CancellationToken))).Returns(Task.FromResult(new Token() { Name = "keyManagerToken", Token1 = "km1" }));
            var userSessionManager = new UserSessionManager(_sessionAuthApiMock.Object, _keyAuthApiMock.Object, _certificate);
            var sessionToken = userSessionManager.SessionToken;
            var keyManagerToken = userSessionManager.KeyManagerToken;
            Assert.Equal("s1", sessionToken);
            Assert.Equal("km1", keyManagerToken);
        }

        [Fact]
        public void EnsureGenerateTokens_regenerate_tokens_every_call()
        {
            var sessionTokenCounter = 0;
            var keyManagerTokenCounter = 100;
            _sessionAuthApiMock.Setup(obj => obj.V1Async(default(CancellationToken))).Returns(() =>
            {
                ++sessionTokenCounter;
                return Task.FromResult(new Token() {Name = "sessionToken", Token1 = "s" + sessionTokenCounter.ToString()});
            });
            _keyAuthApiMock.Setup(obj => obj.V1Async(default(CancellationToken))).Returns(() =>
            {
                ++keyManagerTokenCounter;
                return Task.FromResult(new Token() { Name = "keyManagerToken", Token1 = "km" + keyManagerTokenCounter.ToString() });

            });
            var userSessionManager = new UserSessionManager(_sessionAuthApiMock.Object, _keyAuthApiMock.Object, _certificate);
            Assert.Equal("s1", userSessionManager.SessionToken);
            Assert.Equal("km101", userSessionManager.KeyManagerToken);
            Assert.Equal("s1", userSessionManager.SessionToken);
            Assert.Equal("km101", userSessionManager.KeyManagerToken);

            userSessionManager.GenerateTokens();
            Assert.Equal("s2", userSessionManager.SessionToken);
            Assert.Equal("km102", userSessionManager.KeyManagerToken);
            Assert.Equal("km102", userSessionManager.KeyManagerToken);
        }

    }
}
