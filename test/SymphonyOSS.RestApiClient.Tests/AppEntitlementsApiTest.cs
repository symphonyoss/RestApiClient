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

using System.Net.Http;
using SymphonyOSS.RestApiClient.Entities;

namespace SymphonyOSS.RestApiClient.Tests
{
    using Api;
    using Api.PodApi;
    using Authentication;
    using Generated.OpenApi.PodApi;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;
    

    public class AppEntitlementsApiTest
    {
        private readonly AppEntitlementsApi _presenceApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public AppEntitlementsApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            _apiExecutorMock = new Mock<IApiExecutor>();
            _presenceApi = new AppEntitlementsApi(sessionManagerMock.Object, "", new HttpClient(), _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureGetAllAppEntitlements_uses_retry_strategy()
        {
            _presenceApi.GetAllAppEntitlements();
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<UserPresence>>>>(), "sessionToken", default(CancellationToken)));
        }
    }
}
