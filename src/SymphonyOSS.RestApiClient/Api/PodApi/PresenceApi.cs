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
using Microsoft.Extensions.Logging;
using SymphonyOSS.RestApiClient.Logging;

namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using Authentication;
    using Factories;
    using System.Net.Http;
    using System.Collections.Generic;
    using Presence = Entities.Presence;

    /// <summary>
    /// Provides methods for getting and setting user presence, by encapsulating
    /// <see cref="PresenceApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class PresenceApi
    {
        private readonly Generated.OpenApi.PodApi.PresenceClient _presenceApi;
        private readonly Generated.OpenApi.PodApi.UserClient _userApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        private readonly ILogger _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public PresenceApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _presenceApi = new Generated.OpenApi.PodApi.PresenceClient(baseUrl, httpClient);
            _userApi = new Generated.OpenApi.PodApi.UserClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
            _log = ApiLogging.LoggerFactory?.CreateLogger<PresenceApi>();

        }

        /// <summary>
        /// Get presence information about all company (pod) users. The returned data
        /// is taken from the in-memory cache for performance reasons which means inactive
        /// users may be omitted from the response. All non-inactive users WILL be returned
        /// and some inactive users MAY be included. Any omitted user IS inactive.
        /// </summary>
        /// <returns>List of presences.</returns>
        public List<Presence> GetPresences()
        {
            var presences = _apiExecutor.Execute(_presenceApi.V1Async, _authTokens.SessionToken);
            var result = new List<Presence>();
            if (presences != null)
            {
                foreach (var presence in presences)
                {
                    result.Add(PresenceFactory.Create(presence));
                }
            }
            return result;
        }

        /// <summary>
        /// Get presence information about a particular user. 
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <returns>The presence for the user.</returns>
        public Presence GetPresence(long uid)
        {
            try
            {
                var presence = _apiExecutor.Execute(_userApi.V1PresenceGet2Async, uid, _authTokens.SessionToken);
                return PresenceFactory.Create(uid, presence);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to retrieve presence information from user {uid}", uid);
                throw;
            }
        }

        /// <summary>
        /// Set presence information for a particular user. Only the following states can be set:
        /// AVAILABLE, BUSY, ON_THE_PHONE, AWAY. Attempts to set other states will result in a
        /// 403 FORBIDDEN response. The UNDEFINED value is an error case used to represent the
        /// case if the value stored in the system cannot be represented by the values known to the
        /// API. The other states are reserved for future use.
        /// </summary>
        /// <param name="uid">User ID.</param>
        /// <param name="presence">The user's presence.</param>
        /// <returns>The user's new presence.</returns>
        public Presence SetPresence(Presence presence)
        {
            try
            {
                var symphonyPresence = CreateSymphonyPresence(presence);
                //var result = _apiExecutor.Execute(_presenceApi.V1UserUidPresencePost, (long?)presence.UserId, _authTokens.SessionToken, symphonyPresence);
                var result = _apiExecutor.Execute(_userApi.V1PresencePost2Async, presence.UserId,
                    _authTokens.SessionToken, symphonyPresence);
                return PresenceFactory.Create(presence.UserId, result);
            }
            catch (Exception e)
            {
                var userId = presence.UserId;
                _log?.LogError(0, e, "An error has occured while trying to set the presence of user {userId}", userId);
                throw;
            }
        }

        private static Generated.OpenApi.PodApi.Presence CreateSymphonyPresence(Presence presence)
        {
            Generated.OpenApi.PodApi.PresenceCategory category;
            switch (presence.Category)
            {
                case SymphonyOSS.RestApiClient.Entities.PresenceCategory.Available:
                    category = Generated.OpenApi.PodApi.PresenceCategory.AVAILABLE;
                    break;
                case SymphonyOSS.RestApiClient.Entities.PresenceCategory.Away:
                    category = Generated.OpenApi.PodApi.PresenceCategory.AWAY;
                    break;
                case SymphonyOSS.RestApiClient.Entities.PresenceCategory.BeRightBack:
                    category = Generated.OpenApi.PodApi.PresenceCategory.BE_RIGHT_BACK;
                    break;
                case SymphonyOSS.RestApiClient.Entities.PresenceCategory.Busy:
                    category = Generated.OpenApi.PodApi.PresenceCategory.BUSY;
                    break;
                case SymphonyOSS.RestApiClient.Entities.PresenceCategory.DoNotDisturb:
                    category = Generated.OpenApi.PodApi.PresenceCategory.DO_NOT_DISTURB;
                    break;
                case SymphonyOSS.RestApiClient.Entities.PresenceCategory.Offline:
                    category = Generated.OpenApi.PodApi.PresenceCategory.OFFLINE;
                    break;
                case SymphonyOSS.RestApiClient.Entities.PresenceCategory.OnThePhone:
                    category = Generated.OpenApi.PodApi.PresenceCategory.ON_THE_PHONE;
                    break;
                default:
                    category = Generated.OpenApi.PodApi.PresenceCategory.UNDEFINED;
                    break;
            }
            return new Generated.OpenApi.PodApi.Presence() { Category = category };
        }
    }
}
