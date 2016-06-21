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
            var configuration = new Configuration();
            _apiExecutorMock = new Mock<IApiExecutor>();
            _roomMembershipApi = new RoomMembershipApi(sessionManagerMock.Object, configuration, _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureAddMemberToRoom_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.AddMemberToRoom(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, SuccessResponse>>(), roomId, new UserId(userId), "sessionToken"));
        }

        [Fact]
        public void EnsureRemoveMemberFromRoom_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.RemoveMemberFromRoom(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, SuccessResponse>>(), roomId, new UserId(userId), "sessionToken"));
        }

        [Fact]
        public void EnsurePromoteUserToRoomOwner_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.PromoteUserToRoomOwner(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, SuccessResponse>>(), roomId, new UserId(userId), "sessionToken"));
        }

        [Fact]
        public void EnsureDemoteRoomOwner_uses_retry_strategy()
        {
            var roomId = "some_room";
            var userId = 123456789;
            _roomMembershipApi.DemoteRoomOwner(roomId, userId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserId, string, SuccessResponse>>(), roomId, new UserId(userId), "sessionToken"));
        }

        [Fact]
        public void EnsureGetRoomMembers_uses_retry_strategy()
        {
            var roomId = "some_room";
            _roomMembershipApi.GetRoomMembers(roomId);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, MembershipList>>(), roomId, "sessionToken"));
        }
    }
}
