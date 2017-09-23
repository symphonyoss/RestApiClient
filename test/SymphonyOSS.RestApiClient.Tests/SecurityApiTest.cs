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
using System.Threading.Tasks;

namespace SymphonyOSS.RestApiClient.Tests
{
    using System;
    using Api;
    using Api.PodApi;
    using Authentication;
    using Generated.OpenApi.PodApi;
    using Moq;
    using Xunit;
    using System.Threading;

    public class SecurityApiTest
    {
        private readonly Mock<IApiExecutor> _apiExecutorMock;

        private readonly SecurityApi _securityApi;

        public SecurityApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            sessionManagerMock.Setup(obj => obj.KeyManagerToken).Returns("keyManagerToken");
            _apiExecutorMock = new Mock<IApiExecutor>();
            _securityApi = new SecurityApi(sessionManagerMock.Object, "", new HttpClient(), _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureCreate_uses_api_executor()
        {
            var cert = new CompanyCert()
            {
                Pem = "pem",
                Attributes = new CompanyCertAttributes()
                {
                    Name = "name",
                    Type = new CompanyCertType()
                    {
                        Type = CompanyCertTypeType.OPERATIONSSIGNING
                    },
                    Status = new CompanyCertStatus()
                    {
                        Type = CompanyCertStatusType.TRUSTED
                    }
                }
            };
            _securityApi.Create(cert);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, CompanyCert, CancellationToken, Task<SuccessResponse>>>(), "sessionToken", cert, default(CancellationToken)));
        }

        [Fact]
        public void EnsureDelete_uses_api_executor()
        {
            _securityApi.Delete("fingerPrint");
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, StringId, CancellationToken, Task<SuccessResponse>>>(), "sessionToken", It.IsAny<StringId>(), default(CancellationToken)));
        }

        [Fact]
        public void EnsureGet_uses_api_executor()
        {
            _securityApi.Get("fingerPrint");
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<CompanyCertDetail>>>(), "fingerPrint", "sessionToken", default(CancellationToken)));
        }

        [Fact]
        public void EnsureGetIssued_uses_api_executor()
        {
            _securityApi.GetIssued("fingerPrint");
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<Anonymous>>>>(), "fingerPrint", "sessionToken", default(CancellationToken)));
        }

        [Fact]
        public void EnsureUpdate_uses_api_executor()
        {
            var certAttributes = new CompanyCertAttributes()
            {
                Name = "name",
                Type = new CompanyCertType()
                {
                    Type = CompanyCertTypeType.OPERATIONSSIGNING
                },
                Status = new CompanyCertStatus()
                {
                    Type = CompanyCertStatusType.TRUSTED
                }
            };
            _securityApi.Update("fingerPrint", certAttributes);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, CompanyCertAttributes, CancellationToken, Task<SuccessResponse>>>(), "fingerPrint", "sessionToken", certAttributes, default(CancellationToken)));
        }

        [Fact]
        public void EnsureGetAllTrusted_uses_api_executor()
        {
            _securityApi.GetAllTrusted(0, 10);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, int?, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<Anonymous>>>>(), "sessionToken", 0, 10, default(CancellationToken)));
        }

        [Fact]
        public void EnsureGetPodManaged_uses_api_executor()
        {
            _securityApi.GetPodManaged(0, 10);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, int?, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<Anonymous>>>>(), "sessionToken", 0, 10, default(CancellationToken)));
        }

        [Fact]
        public void EnsureGetByTypes_uses_api_executor()
        {
            var types = new List<CompanyCertType>() as IEnumerable<CompanyCertType>;
            _securityApi.GetByTypes(types, 0, 10);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<IEnumerable<CompanyCertType>, string, int?, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<Anonymous>>>>(), types, "sessionToken", 0, 10, default(CancellationToken)));
        }
    }
}
