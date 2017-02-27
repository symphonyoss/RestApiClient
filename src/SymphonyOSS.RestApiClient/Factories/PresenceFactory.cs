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
        public static Presence Create(long userId, Generated.OpenApi.PodApi.Model.Presence presence)
        {
            return new Presence(userId, GetCategory(presence.Category.Value));
        }

        public static Presence Create(Generated.OpenApi.PodApi.Model.UserPresence userPresence)
        {
            return new Presence(userPresence.Uid.Value, GetCategory(userPresence.Category.Value));
        }

        private static PresenceCategory GetCategory(Generated.OpenApi.PodApi.Model.Presence.CategoryEnum category)
        {
            switch (category)
            {
                case Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.AVAILABLE:
                    return PresenceCategory.Available;
                case Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.AWAY:
                    return PresenceCategory.Away;
                case Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.BERIGHTBACK:
                    return PresenceCategory.BeRightBack;
                case Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.BUSY:
                    return PresenceCategory.Busy;
                case Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.DONOTDISTURB:
                    return PresenceCategory.DoNotDisturb;
                case Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.OFFLINE:
                    return PresenceCategory.Offline;
                case Generated.OpenApi.PodApi.Model.Presence.CategoryEnum.ONTHEPHONE:
                    return PresenceCategory.OnThePhone;
                default:
                    return PresenceCategory.Undefined;
            }
        }

        private static PresenceCategory GetCategory(Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum category)
        {
            switch (category)
            {
                case Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum.AVAILABLE:
                    return PresenceCategory.Available;
                case Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum.AWAY:
                    return PresenceCategory.Away;
                case Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum.BERIGHTBACK:
                    return PresenceCategory.BeRightBack;
                case Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum.BUSY:
                    return PresenceCategory.Busy;
                case Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum.DONOTDISTURB:
                    return PresenceCategory.DoNotDisturb;
                case Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum.OFFLINE:
                    return PresenceCategory.Offline;
                case Generated.OpenApi.PodApi.Model.UserPresence.CategoryEnum.ONTHEPHONE:
                    return PresenceCategory.OnThePhone;
                default:
                    return PresenceCategory.Undefined;
            }
        }
    }
}
