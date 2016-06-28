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

    public class UserApiTest
    {
        private readonly UserApi _userApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public UserApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            var configuration = new Configuration();
            _apiExecutorMock = new Mock<IApiExecutor>();
            _userApi = new UserApi(sessionManagerMock.Object, configuration, _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureCreateUser_uses_retry_strategy()
        {
            var payload = new UserCreate();
            _userApi.CreateUser(payload);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserCreate, UserDetail>>(), "sessionToken", payload));
        }

        [Fact]
        public void EnsureFindUser_uses_retry_strategy()
        {
            var payload = new UserFilter();
            _userApi.FindUser(payload);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserFilter, UserList>>(), "sessionToken", payload));
        }

        [Fact]
        public void EnsureGetAllUsers_uses_retry_strategy()
        {
            _userApi.GetAllUsers();
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, UserIdList>>(), "sessionToken"));
        }

        [Fact]
        public void EnsureResetPassword_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.ResetPassword(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, PasswordReset, SuccessResponse>>(), "sessionToken", uid, It.IsAny<PasswordReset>()));
        }

        [Fact]
        public void EnsureGetAvatar_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.GetAvatar(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, AvatarList>>(), "sessionToken", uid));
        }

        [Fact]
        public void EnsureUpdateAvatar_uses_retry_strategy()
        {
            var uid = 12345;
            var image = "image";
            _userApi.UpdateAvatar(uid, image);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, AvatarUpdate, SuccessResponse>>(), "sessionToken", uid, It.IsAny<AvatarUpdate>()));
        }

        [Fact]
        public void EnsureGetDelegates_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.GetDelegates(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, IntegerList>>(), "sessionToken", uid));
        }

        [Fact]
        public void EnsureUpdateDelegates_uses_retry_strategy()
        {
            var uid = 12345;
            var payload = new DelegateAction();
            _userApi.UpdateDelegates(uid, payload);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, DelegateAction, SuccessResponse>>(), "sessionToken", uid, It.IsAny<DelegateAction>()));
        }

        [Fact]
        public void EnsureGetDisclaimer_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.GetDisclaimer(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, Disclaimer>>(), "sessionToken", uid));
        }

        [Fact]
        public void EnsureUpdateDisclaimer_uses_retry_strategy()
        {
            var uid = 12345;
            var disclaimer = "disclaimer";
            _userApi.UpdateDisclaimer(uid, disclaimer);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, StringId, SuccessResponse>>(), "sessionToken", uid, It.IsAny<StringId>()));
        }

        [Fact]
        public void EnsureGetFeatures_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.GetFeatures(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, FeatureList>>(), "sessionToken", uid));
        }

        [Fact]
        public void EnsureUpdateFeatures_uses_retry_strategy()
        {
            var uid = 12345;
            var features = new List<Feature>();
            _userApi.UpdateFeatures(uid, features);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, FeatureList, SuccessResponse>>(), "sessionToken", uid, It.IsAny<FeatureList>()));
        }

        [Fact]
        public void EnsureGetDetails_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.GetDetails(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, UserDetail>>(), "sessionToken", uid));
        }

        [Fact]
        public void EnsureGetRoles_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.GetRoles(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, RoleList>>(), "sessionToken", uid));
        }

        [Fact]
        public void EnsureUpdateRoles_uses_retry_strategy()
        {
            var uid = 12345;
            var roles = new List<string>();
            _userApi.UpdateRoles(uid, roles);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, StringList, SuccessResponse>>(), "sessionToken", uid, It.IsAny<StringList>()));
        }

        [Fact]
        public void EnsureGetStatus_uses_retry_strategy()
        {
            var uid = 12345;
            _userApi.GetStatus(uid);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, UserStatus>>(), "sessionToken", uid));
        }

        [Fact]
        public void EnsureUpdateStatus_uses_retry_strategy()
        {
            var uid = 12345;
            var status = new UserStatus();
            _userApi.UpdateStatus(uid, status);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, UserStatus, SuccessResponse>>(), "sessionToken", uid, It.IsAny<UserStatus>()));
        }

        [Fact]
        public void EnsureUpdateUser_uses_retry_strategy()
        {
            var uid = 12345;
            var payload = new UserAttributes();
            _userApi.UpdateUser(uid, payload);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long?, UserAttributes, UserDetail>>(), "sessionToken", uid, It.IsAny<UserAttributes>()));
        }
    }
}
