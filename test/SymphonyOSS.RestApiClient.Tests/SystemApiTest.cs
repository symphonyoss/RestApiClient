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
using System.Net.Http;

namespace SymphonyOSS.RestApiClient.Tests
{
    using System;
    using Api;
    using Api.PodApi;
    using Authentication;
    using Generated.OpenApi.PodApi;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Xunit;

    public class SystemApiTest
    {
        private readonly SystemApi _systemApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public SystemApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            _apiExecutorMock = new Mock<IApiExecutor>();
            _systemApi = new SystemApi(sessionManagerMock.Object, "", new HttpClient(), _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureGetFeatures_uses_retry_strategy()
        {
            _systemApi.GetFeatures();
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<string>>>>(), "sessionToken", default(CancellationToken)));
        }
    }
}
