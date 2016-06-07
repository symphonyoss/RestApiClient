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
    using Api;
    using Authentication;
    using Moq;
    using Xunit;

    public class RefreshTokensRetryStrategyTest
    {
        private readonly Mock<ISessionManager> _sessionManagerMock;

        private readonly RefreshTokensRetryStrategy _refreshTokensRetryStrategy;

        public RefreshTokensRetryStrategyTest()
        {
            _sessionManagerMock = new Mock<ISessionManager>();
            _refreshTokensRetryStrategy = new RefreshTokensRetryStrategy(_sessionManagerMock.Object);
        }

        public void EnsureShouldRetry_returns_true_and_generates_tokens_on_agent_401_error()
        {
            var exception = new Mock<Generated.OpenApi.AgentApi.Client.ApiException>();
            exception.Setup(obj => obj.ErrorCode).Returns(401);
            var result = _refreshTokensRetryStrategy.ShouldRetry(exception.Object, 0);
            Assert.True(result);
            _sessionManagerMock.Verify(obj => obj.GenerateTokens());
        }

        public void EnsureShouldRetry_returns_true_and_generates_tokens_on_service_401_error()
        {
            var exception = new Mock<Generated.OpenApi.PodApi.Client.ApiException>();
            exception.Setup(obj => obj.ErrorCode).Returns(401);
            var result = _refreshTokensRetryStrategy.ShouldRetry(exception.Object, 0);
            Assert.True(result);
            _sessionManagerMock.Verify(obj => obj.GenerateTokens());
        }

        public void EnsureShouldRetry_returns_false_on_agent_500_error()
        {
            var exception = new Mock<Generated.OpenApi.AgentApi.Client.ApiException>();
            exception.Setup(obj => obj.ErrorCode).Returns(500);
            var result = _refreshTokensRetryStrategy.ShouldRetry(exception.Object, 0);
            Assert.False(result);
            _sessionManagerMock.Verify(obj => obj.GenerateTokens(), Times.Never);
        }

        public void EnsureShouldRetry_returns_false_on_service_500_error()
        {
            var exception = new Mock<Generated.OpenApi.PodApi.Client.ApiException>();
            exception.Setup(obj => obj.ErrorCode).Returns(500);
            var result = _refreshTokensRetryStrategy.ShouldRetry(exception.Object, 0);
            Assert.False(result);
            _sessionManagerMock.Verify(obj => obj.GenerateTokens(), Times.Never);
        }
    }
}
