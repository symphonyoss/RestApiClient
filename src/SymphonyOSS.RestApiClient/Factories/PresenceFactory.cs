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

namespace SymphonyOSS.RestApiClient.Factories
{
    using Entities;
    using Presence = Entities.Presence;

    public abstract class PresenceFactory
    {
        public static Presence Create(long userId, Generated.OpenApi.PodApi.Presence presence)
        {
            return new Presence(userId, GetCategory(presence.Category.Value));
        }

        public static Presence Create(Generated.OpenApi.PodApi.UserPresence userPresence)
        {
            return new Presence(userPresence.Uid.Value, GetCategory(userPresence.Category.Value));
        }

        private static PresenceCategory GetCategory(Generated.OpenApi.PodApi.PresenceCategory category)
        {
            switch (category)
            {
                case Generated.OpenApi.PodApi.PresenceCategory.AVAILABLE:
                    return PresenceCategory.Available;
                case Generated.OpenApi.PodApi.PresenceCategory.AWAY:
                    return PresenceCategory.Away;
                case Generated.OpenApi.PodApi.PresenceCategory.BE_RIGHT_BACK:
                    return PresenceCategory.BeRightBack;
                case Generated.OpenApi.PodApi.PresenceCategory.BUSY:
                    return PresenceCategory.Busy;
                case Generated.OpenApi.PodApi.PresenceCategory.DO_NOT_DISTURB:
                    return PresenceCategory.DoNotDisturb;
                case Generated.OpenApi.PodApi.PresenceCategory.OFFLINE:
                    return PresenceCategory.Offline;
                case Generated.OpenApi.PodApi.PresenceCategory.ON_THE_PHONE:
                    return PresenceCategory.OnThePhone;
                default:
                    return PresenceCategory.Undefined;
            }
        }

        private static PresenceCategory GetCategory(Generated.OpenApi.PodApi.UserPresenceCategory category)
        {
            switch (category)
            {
                case Generated.OpenApi.PodApi.UserPresenceCategory.AVAILABLE:
                    return PresenceCategory.Available;
                case Generated.OpenApi.PodApi.UserPresenceCategory.AWAY:
                    return PresenceCategory.Away;
                case Generated.OpenApi.PodApi.UserPresenceCategory.BE_RIGHT_BACK:
                    return PresenceCategory.BeRightBack;
                case Generated.OpenApi.PodApi.UserPresenceCategory.BUSY:
                    return PresenceCategory.Busy;
                case Generated.OpenApi.PodApi.UserPresenceCategory.DO_NOT_DISTURB:
                    return PresenceCategory.DoNotDisturb;
                case Generated.OpenApi.PodApi.UserPresenceCategory.OFFLINE:
                    return PresenceCategory.Offline;
                case Generated.OpenApi.PodApi.UserPresenceCategory.ON_THE_PHONE:
                    return PresenceCategory.OnThePhone;
                default:
                    return PresenceCategory.Undefined;
            }
        }
    }
}
