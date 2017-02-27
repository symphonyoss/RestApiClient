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
    using System;
    using Api;
    using Api.PodApi;
    using Authentication;
    using Generated.OpenApi.PodApi.Client;
    using Generated.OpenApi.PodApi.Model;
    using Moq;
    using Xunit;

    public class UsersApiTest
    {
        private readonly UsersApi _usersApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public UsersApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            var configuration = new Configuration();
            _apiExecutorMock = new Mock<IApiExecutor>();
            _usersApi = new UsersApi(sessionManagerMock.Object, configuration, _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureGetUser_uses_retry_strategy()
        {
            const string email = "email";
            _usersApi.GetUserId(email);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, bool?, User>>(), email, "sessionToken", (bool?) null));
        }

        [Fact]
        public void EnsureGetUser_by_user_id_uses_retry_strategy()
        {
            const long userId = 12345;
            _usersApi.GetUser(userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, string, string, bool?, UserV2>>(), "sessionToken", userId, (string)null, (string)null, (bool?)null));
        }

    }
}
