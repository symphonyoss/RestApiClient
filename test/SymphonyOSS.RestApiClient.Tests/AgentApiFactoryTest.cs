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
    using Factories;
    using System.Security.Cryptography.X509Certificates;
    using Moq;
    using Xunit;

    public class AgentApiFactoryTest
    {
        private readonly SessionManager _sessionManager;

        public AgentApiFactoryTest()
        {
            var certificateMock = new Mock<X509Certificate2>();
            _sessionManager = new SessionManager("https://sessionauth", "https://keyauth", certificateMock.Object);
        }

        [Fact]
        public void EnsureConstructs_an_AttachmentsApi_instance()
        {
            var agentApiFactory = new AgentApiFactory("https://agent");
            var result = agentApiFactory.CreateAttachmentsApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_DatafeedApi_instance()
        {
            var agentApiFactory = new AgentApiFactory("https://agent");
            var result = agentApiFactory.CreateDatafeedApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_MessagesApi_instance()
        {
            var agentApiFactory = new AgentApiFactory("https://agent");
            var result = agentApiFactory.CreateMessagesApi(_sessionManager);
            Assert.NotNull(result);
        }
    }

}
