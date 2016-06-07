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

    public class SessionManagerTest
    {
        private readonly X509Certificate2 _certificate;

        private readonly Mock<IAuthenticationApi> _sessionAuthApiMock;

        private readonly Mock<IAuthenticationApi> _keyAuthApiMock;

        public SessionManagerTest()
        {
            _certificate = new Mock<X509Certificate2>().Object;
            _sessionAuthApiMock = new Mock<IAuthenticationApi>();
            _keyAuthApiMock = new Mock<IAuthenticationApi>();
        }

        [Fact]
        public void EnsureTokens_are_returned_without_explicitly_calling_GenerateTokens()
        {
            _sessionAuthApiMock.Setup(obj => obj.V1AuthenticatePost()).Returns(new Token("sessionToken", "s1"));
            _keyAuthApiMock.Setup(obj => obj.V1AuthenticatePost()).Returns(new Token("keyManagerToken", "km1"));
            var sessionManager = new SessionManager(_sessionAuthApiMock.Object, _keyAuthApiMock.Object, _certificate);
            var sessionToken = sessionManager.SessionToken;
            var keyManagerToken = sessionManager.KeyManagerToken;
            Assert.Equal("s1", sessionToken);
            Assert.Equal("km1", keyManagerToken);
        }

        [Fact]
        public void EnsureGenerateTokens_regenerate_tokens_every_call()
        {
            var sessionTokenCounter = 0;
            var keyManagerTokenCounter = 100;
            _sessionAuthApiMock.Setup(obj => obj.V1AuthenticatePost()).Returns(() =>
            {
                ++sessionTokenCounter;
                return new Token("sessionToken", "s" + sessionTokenCounter.ToString());
            });
            _keyAuthApiMock.Setup(obj => obj.V1AuthenticatePost()).Returns(() =>
            {
                ++keyManagerTokenCounter;
                return new Token("keyManagerToken", "km" + keyManagerTokenCounter.ToString());
            });
            var sessionManager = new SessionManager(_sessionAuthApiMock.Object, _keyAuthApiMock.Object, _certificate);
            Assert.Equal("s1", sessionManager.SessionToken);
            Assert.Equal("km101", sessionManager.KeyManagerToken);
            Assert.Equal("s1", sessionManager.SessionToken);
            Assert.Equal("km101", sessionManager.KeyManagerToken);

            sessionManager.GenerateTokens();
            Assert.Equal("s2", sessionManager.SessionToken);
            Assert.Equal("km102", sessionManager.KeyManagerToken);
            Assert.Equal("km102", sessionManager.KeyManagerToken);
        }

    }
}
