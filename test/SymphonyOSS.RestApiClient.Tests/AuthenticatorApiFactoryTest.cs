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
    using System.Security.Cryptography.X509Certificates;
    using Factories;
    using Generated.OpenApi.AuthenticatorApi;
    using Moq;
    using Xunit;

    public class AuthenticatorApiFactoryTest
    {
        private readonly Mock<X509Certificate2> _certificateMock;

        public AuthenticatorApiFactoryTest()
        {
            _certificateMock = new Mock<X509Certificate2>();
        }

        [Fact]
        public void EnsureConstructs_AuthenticationApi()
        {
            var authenticatorApiFactory = new AuthenticatorApiFactory("https://authurl");
            var result = authenticatorApiFactory.CreateAppAuthenticationApi(_certificateMock.Object);
            Assert.NotNull(result);
        }

    }
}
