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

namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using System.Collections.Generic;
    using Authentication;
    using Generated.OpenApi.PodApi.Client;
    using Generated.OpenApi.PodApi.Model;

    /// <summary>
    /// Provides methods for managing pod users, by encapsulating
    /// <see cref="Generated.OpenApi.PodApi.Api.UserApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class UserApi
    {
        private readonly Generated.OpenApi.PodApi.Api.IUserApi _userApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public UserApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _userApi = new Generated.OpenApi.PodApi.Api.UserApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="payload"></param>
        /// <returns>User details.</returns>
        public UserDetail CreateUser(UserCreate payload)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserCreatePost, _authTokens.SessionToken, payload);
        }

        /// <summary>
        /// Find a user based on attributes.
        /// </summary>
        /// <param name="payload"></param>
        /// <returns>List of users.</returns>
        public UserList FindUser(UserFilter payload)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserFindPost, _authTokens.SessionToken, payload);
        }

        /// <summary>
        /// Retreive a list of all users in the company (pod).
        /// </summary>
        /// <returns>The list of user IDs.</returns>
        public UserIdList GetAllUsers()
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserListGet, _authTokens.SessionToken);
        }

        /// <summary>
        /// Send a password reset email to the email address of a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>Success response.</returns>
        public SuccessResponse ResetPassword(long uid)
        {
            return _apiExecutor.Execute(
                _userApi.V1AdminUserUidActionPasswordResetPost,
                _authTokens.SessionToken,
                (long?)uid,
                new PasswordReset(PasswordReset.TypeEnum.Email));
        }

        /// <summary>
        /// Get the URL of the avatar of a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>List of avatars.</returns>
        public AvatarList GetAvatar(long uid)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidAvatarGet, _authTokens.SessionToken, (long?)uid);
        }

        /// <summary>
        /// Update the avatar of a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="image">Base64 encoded image.</param>
        /// <returns>Success response.</returns>
        public SuccessResponse UpdateAvatar(long uid, string image)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidAvatarUpdatePost, _authTokens.SessionToken, (long?)uid, new AvatarUpdate(image));
        }

        /// <summary>
        /// Get the delegates assigned to a user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>List of delegates.</returns>
        public IntegerList GetDelegates(long uid)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidDelegatesGet, _authTokens.SessionToken, (long?)uid);
        }

        /// <summary>
        /// Update the delegates assigned to a user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="payload"></param>
        /// <returns>Success response.</returns>
        public SuccessResponse UpdateDelegates(long uid, DelegateAction payload)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidDelegatesUpdatePost, _authTokens.SessionToken, (long?)uid, payload);
        }

        /// <summary>
        /// Get the disclaimer assigned to a user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>The disclaimer.</returns>
        public Disclaimer GetDisclaimer(long uid)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidDisclaimerGet, _authTokens.SessionToken, (long?)uid);
        }

        /// <summary>
        /// Assign a disclaimer to a user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="disclaimer">The disclaimer.</param>
        /// <returns>Success response.</returns>
        public SuccessResponse UpdateDisclaimer(long uid, string disclaimer)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidDisclaimerUpdatePost, _authTokens.SessionToken, (long?)uid, new StringId(disclaimer));
        }

        /// <summary>
        /// Get the list of feature entitlements enabled for a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>List of features.</returns>
        public FeatureList GetFeatures(long uid)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidFeaturesGet, _authTokens.SessionToken, (long?)uid);
        }

        /// <summary>
        /// Update the list of feature entitlements for a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="features">List of features.</param>
        /// <returns>Success response.</returns>
        public SuccessResponse UpdateFeatures(long uid, List<Feature> features)
        {
            var payload = new FeatureList();
            payload.AddRange(features);
            return _apiExecutor.Execute(_userApi.V1AdminUserUidFeaturesUpdatePost, _authTokens.SessionToken, (long?)uid, payload);
        }

        /// <summary>
        /// Retreive user details for a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>User details.</returns>
        public UserDetail GetDetails(long uid)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidGet, _authTokens.SessionToken, (long?)uid);
        }

        /// <summary>
        /// Get the list of roles assigned to a user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>List of roles.</returns>
        public RoleList GetRoles(long uid)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidRolesGet, _authTokens.SessionToken, (long?)uid);
        }

        /// <summary>
        /// Update the list of roles assigned to a user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="roles">List of roles.</param>
        /// <returns>Success response.</returns>
        public SuccessResponse UpdateRoles(long uid, List<string> roles)
        {
            var payload = new StringList();
            payload.AddRange(roles);
            return _apiExecutor.Execute(_userApi.V1AdminUserUidRolesUpdatePost, _authTokens.SessionToken, (long?)uid, payload);
        }

        /// <summary>
        /// Get the status, active or inactive, for a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>User status.</returns>
        public UserStatus GetStatus(long uid)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidStatusGet, _authTokens.SessionToken, (long?)uid);
        }

        /// <summary>
        /// Update the status of a particular user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="payload"></param>
        /// <returns>Success response.</returns>
        public SuccessResponse UpdateStatus(long uid, UserStatus payload)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidStatusUpdatePost, _authTokens.SessionToken, (long?)uid, payload);
        }

        /// <summary>
        /// Update an existing user.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="payload"></param>
        /// <returns>User details.</returns>
        public UserDetail UpdateUser(long uid, UserAttributes payload)
        {
            return _apiExecutor.Execute(_userApi.V1AdminUserUidUpdatePost, _authTokens.SessionToken, (long?)uid, payload);
        }
    }
}
