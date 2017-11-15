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

using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SymphonyOSS.RestApiClient.Logging;

namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using Authentication;
    using Generated.OpenApi.PodApi;
    using System.Net.Http;

    /// <summary>
    /// Provides methods for operating over multy party chats
    /// and chat rooms, by encapsulating <see cref="RoomMembershipApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class RoomMembershipApi
    {
        private readonly Generated.OpenApi.PodApi.AdminClient _roomMembershipApi;
        private readonly Generated.OpenApi.PodApi.RoomClient _roomApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        private readonly ILogger _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMembershipApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public RoomMembershipApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _roomMembershipApi = new Generated.OpenApi.PodApi.AdminClient(baseUrl, httpClient);
            _roomApi = new Generated.OpenApi.PodApi.RoomClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
            _log = ApiLogging.LoggerFactory?.CreateLogger<RoomMembershipApi>();

        }

        /// <summary>
        /// Adds a member to an existing room.
        /// </summary>
        /// <param name="roomId">The id of the room.</param>
        /// <param name="userId">The id of the user to add to the room.</param>
        /// <returns></returns>
        public SuccessResponse AddMemberToRoom(string roomId, long userId)
        {
            try
            {
                return _apiExecutor.Execute(_roomMembershipApi.V1RoomMembershipAddAsync, roomId, new UserId() { Id = userId }, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to add user {userId} to room {roomId}", userId, roomId);
                throw;
            }
        }

        /// <summary>
        /// Removes a member from an existing room.
        /// </summary>
        /// <param name="roomId">The id of the room.</param>
        /// <param name="userId">The id of the user to add to the room.</param>
        /// <returns></returns>
        public SuccessResponse RemoveMemberFromRoom(string roomId, long userId)
        {
            try
            {
                return _apiExecutor.Execute(_roomMembershipApi.V1RoomMembershipRemoveAsync, roomId, new UserId() { Id = userId }, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to remove user {userId} from room {roomId}", userId, roomId);
                throw;
            }
        }

        /// <summary>
        /// Promotes a user to owner of the room.
        /// </summary>
        /// <param name="roomId">The id of the room.</param>
        /// <param name="userId">The id of the user to add to the room.</param>
        /// <returns></returns>
        public SuccessResponse PromoteUserToRoomOwner(string roomId, long userId)
        {
            try
            {
                return _apiExecutor.Execute(_roomApi.V1MembershipPromoteownerAsync, roomId, new UserId() { Id = userId }, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to promote user {userId} from room {roomId}", userId, roomId);
                throw;
            }
        }

        /// <summary>
        /// Demotes a user from owner of a room.
        /// </summary>
        /// <param name="roomId">The id of the room.</param>
        /// <param name="userId">The id of the user to add to the room.</param>
        /// <returns></returns>
        public SuccessResponse DemoteRoomOwner(string roomId, long userId)
        {
            try
            {
                return _apiExecutor.Execute(_roomApi.V1MembershipDemoteownerAsync, roomId, new UserId() { Id = userId }, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to demote user {userId} from room {roomId}", userId, roomId);
                throw;
            }
        }

        /// <summary>
        /// Gets the members of a room.
        /// </summary>
        /// <param name="roomId">The id of the room.</param>
        /// <returns></returns>
        public IEnumerable<MemberInfo> GetRoomMembers(string roomId)
        {
            try
            {
                return _apiExecutor.Execute(_roomApi.V2MembershipListAsync, roomId, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to retrieve all the members of room {roomId}", roomId);
                throw;
            }
        }
    }
}
