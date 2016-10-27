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

using SymphonyOSS.RestApiClient.Entities;

namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using Authentication;
    using Factories;
    using Generated.OpenApi.PodApi.Client;
    using Generated.OpenApi.PodApi.Model;
    using System.Collections.Generic;
    using Presence = Entities.Presence;

    /// <summary>
    /// Provides methods for getting and setting user presence, by encapsulating
    /// <see cref="Generated.OpenApi.PodApi.Api.PresenceApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class PresenceApi
    {
        private readonly Generated.OpenApi.PodApi.Api.IPresenceApi _presenceApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public PresenceApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _presenceApi = new Generated.OpenApi.PodApi.Api.PresenceApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
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
            var presences = _apiExecutor.Execute(_presenceApi.V1PresenceGet, _authTokens.SessionToken);
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
            var presence = _apiExecutor.Execute(_presenceApi.V1UserUidPresenceGet, (long?)uid, _authTokens.SessionToken);
            return PresenceFactory.Create(uid, presence);
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
            var symphonyPresence = CreateSymphonyPresence(presence);
            var result = _apiExecutor.Execute(_presenceApi.V1UserUidPresencePost, (long?)presence.UserId, _authTokens.SessionToken, symphonyPresence);
            return PresenceFactory.Create(presence.UserId, result);
        }

        private static Generated.OpenApi.PodApi.Model.Presence CreateSymphonyPresence(Presence presence)
        {
            Generated.OpenApi.PodApi.Model.Presence.CategoryEnum category;
            switch (presence.Category)
            {
                case PresenceCategory.Available:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.AVAILABLE;
                    break;
                case PresenceCategory.Away:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.AWAY;
                    break;
                case PresenceCategory.BeRightBack:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.BERIGHTBACK;
                    break;
                case PresenceCategory.Busy:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.BUSY;
                    break;
                case PresenceCategory.DoNotDisturb:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.DONOTDISTURB;
                    break;
                case PresenceCategory.Offline:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.OFFLINE;
                    break;
                case PresenceCategory.OnThePhone:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.ONTHEPHONE;
                    break;
                default:
                    category = Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.UNDEFINED;
                    break;
            }
            return new Generated.OpenApi.PodApi.Model.Presence(category);
        }
    }
}
