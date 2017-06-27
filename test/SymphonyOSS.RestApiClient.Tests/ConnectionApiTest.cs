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

using System.Collections.Generic;

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

    public class ConnectionApiTest
    {
        private readonly Mock<IApiExecutor> _apiExecutorMock;

        private readonly ConnectionApi _connectionApi;

        public ConnectionApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            sessionManagerMock.Setup(obj => obj.KeyManagerToken).Returns("keyManagerToken");
            var configuration = new Configuration();
            _apiExecutorMock = new Mock<IApiExecutor>();
            _connectionApi = new ConnectionApi(sessionManagerMock.Object, configuration, _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureGet_uses_api_executor()
        {
            var userId = 12345;
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, UserConnection>>(), "sessionToken", userId.ToString()))
                .Returns(new UserConnection(userId, UserConnection.StatusEnum.ACCEPTED, 0, 0, 0));
            _connectionApi.Get(userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, UserConnection>>(), "sessionToken", userId.ToString()));
        }

        [Fact]
        public void EnsureList_uses_api_executor_for_null_null()
        {
            _connectionApi.List(null, null);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, string, UserConnectionList>>(), "sessionToken", null, null));
        }

        [Fact]
        public void EnsureList_uses_api_executor_for_status_and_user_ids()
        {
            _connectionApi.List(
                UserConnection.StatusEnum.ACCEPTED,
                new List<long>()
                {
                    12345,
                    67890
                });
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, string, UserConnectionList>>(), "sessionToken", "accepted", "12345,67890"));
        }

        [Fact]
        public void EnsureCreate_uses_api_executor()
        {
            var userId = 12345;
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, UserConnectionRequest, UserConnection>>(), "sessionToken", It.IsAny<UserConnectionRequest>()))
                .Returns(new UserConnection(userId, UserConnection.StatusEnum.ACCEPTED, 0, 0, 0));
            _connectionApi.Create(userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserConnectionRequest, UserConnection>>(), "sessionToken", new UserConnectionRequest(userId)));
        }

        [Fact]
        public void EnsureAccept_uses_api_executor()
        {
            var userId = 12345;
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, UserConnectionRequest, UserConnection>>(), "sessionToken", It.IsAny<UserConnectionRequest>()))
                .Returns(new UserConnection(userId, UserConnection.StatusEnum.ACCEPTED, 0, 0, 0));
            _connectionApi.Accept(userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserConnectionRequest, UserConnection>>(), "sessionToken", new UserConnectionRequest(userId)));
        }

        [Fact]
        public void EnsureReject_uses_api_executor()
        {
            var userId = 12345;
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, UserConnectionRequest, UserConnection>>(), "sessionToken", It.IsAny<UserConnectionRequest>()))
                .Returns(new UserConnection(userId, UserConnection.StatusEnum.ACCEPTED, 0, 0, 0));
            _connectionApi.Reject(userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserConnectionRequest, UserConnection>>(), "sessionToken", new UserConnectionRequest(userId)));
        }
    }
}
