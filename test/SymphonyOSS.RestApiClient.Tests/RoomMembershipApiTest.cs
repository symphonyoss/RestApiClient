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
    using Moq;
    using Xunit;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Summary description for RoomMembershipApiTest
    /// </summary>
    public class RoomMembershipApiTest
    {
        private readonly RoomMembershipApi _roomMembershipApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public RoomMembershipApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            _apiExecutorMock = new Mock<IApiExecutor>();
            _roomMembershipApi = new RoomMembershipApi(sessionManagerMock.Object, "", new HttpClient(), _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureAddMemberToRoom_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.AddMemberToRoom(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, CancellationToken, Task<SuccessResponse>>>(), roomId, It.IsAny<UserId>(), "sessionToken", default(CancellationToken)));
        }

        [Fact]
        public void EnsureRemoveMemberFromRoom_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.RemoveMemberFromRoom(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, CancellationToken, Task<SuccessResponse>>>(), roomId, It.IsAny<UserId>(), "sessionToken", default(CancellationToken)));
        }

        [Fact]
        public void EnsurePromoteUserToRoomOwner_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.PromoteUserToRoomOwner(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, CancellationToken, Task<SuccessResponse>>>(), roomId, It.IsAny<UserId>(), "sessionToken", default(CancellationToken)));
        }

        [Fact]
        public void EnsureDemoteRoomOwner_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.DemoteRoomOwner(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, CancellationToken, Task<SuccessResponse>>>(), roomId, It.IsAny<UserId>(), "sessionToken", default(CancellationToken)));
        }

        [Fact]
        public void EnsureGetRoomMembers_uses_retry_strategy()
        {
            var roomId = "some_room";
            _roomMembershipApi.GetRoomMembers(roomId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<MemberInfo>>>>(), roomId, "sessionToken", default(CancellationToken)));
        }
    }
}
