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
    using Api.PodApi;
    using Authentication;
    using Factories;
    using Moq;
    using Xunit;

    public class PodApiFactoryTest
    {
        private readonly SessionManager _sessionManager;

        public PodApiFactoryTest()
        {
            var certificateMock = new Mock<X509Certificate2>();
            _sessionManager = new SessionManager("https://sessionauth", "https://keyauth", certificateMock.Object);
        }

        [Fact]
        public void EnsureConstructs_a_MessageSuppressionApi_instance()
        {
            var podApiFactory = new PodApiFactory("https://pod");
            var result = podApiFactory.CreateMessageSuppressionApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_PresenceApi_instance()
        {
            var podApiFactory = new PodApiFactory("https://pod");
            var result = podApiFactory.CreatePresenceApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_SessionApi_instance()
        {
            var podApiFactory = new PodApiFactory("https://pod");
            var result = podApiFactory.CreateSessionApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_StreamsApi_instance()
        {
            var podApiFactory = new PodApiFactory("https://pod");
            var result = podApiFactory.CreateStreamsApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_SystemApi_instance()
        {
            var podApiFactory = new PodApiFactory("https://pod");
            var result = podApiFactory.CreateSystemApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_UsersApi_instance()
        {
            var podApiFactory = new PodApiFactory("https://pod");
            var result = podApiFactory.CreateUsersApi(_sessionManager);
            Assert.NotNull(result);
        }

        [Fact]
        public void EnsureConstructs_a_RoomMembershipApi_instance()
        {
            var podApiFactory = new PodApiFactory("https://pod");
            var result = podApiFactory.CreateRoomMembershipApi(_sessionManager);
            Assert.NotNull(result);
        }
    }
}
