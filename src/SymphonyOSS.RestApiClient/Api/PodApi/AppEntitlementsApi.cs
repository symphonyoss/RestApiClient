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
    using Microsoft.Extensions.Logging;
    using SymphonyOSS.RestApiClient.Authentication;
    using SymphonyOSS.RestApiClient.Entities;
    using SymphonyOSS.RestApiClient.Factories;
    using SymphonyOSS.RestApiClient.Logging;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Net.Http;

    public class AppEntitlementsApi
    {
        private readonly ILogger _log;

        private readonly Generated.OpenApi.PodApi.AdminClient _appEntitlementsApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        public AppEntitlementsApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _log = ApiLogging.LoggerFactory?.CreateLogger<AppEntitlementsApi>();

            _appEntitlementsApi = new Generated.OpenApi.PodApi.AdminClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }
        /// <summary>
        /// Get the list of available application entitlements for the company Pod
        /// </summary>
        /// <returns>List of app entitlements</returns>
        public IEnumerable<PodAppEntitlement> GetAppEntitlements()
        {
            try
            {
                var podAppEnttlementsGenerated = _apiExecutor.Execute(_appEntitlementsApi.V1AppEntitlementListGetAsync, _authTokens.SessionToken);
                if (podAppEnttlementsGenerated == null)
                    return null;

                return podAppEnttlementsGenerated.Select(x => PodAppEntitlementFactory.Create(x));
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to retrieve application entitlements");
                throw;
            }
        }
        /// <summary>
        /// Update the list of application entitlements for the company Pod
        /// </summary>
        /// <param name="appEntitlements">List of app entitlements to be updated</param>
        /// <returns>List of updated app entitlements</returns>
        public IEnumerable<PodAppEntitlement> UpdateAppEntitlements(IEnumerable<PodAppEntitlement> appEntitlements)
        {
            try
            {
                if (appEntitlements == null)
                    return null;
                var generatedPodAppEntitlement = appEntitlements.Select(x => new Generated.OpenApi.PodApi.PodAppEntitlement { AppId = x.AppId, AppName = x.AppName, Enable = x.Enable, Install = x.Install, Listed = x.Listed });
                var podAppEnttlementsGenerated = _apiExecutor.Execute(_appEntitlementsApi.V1AppEntitlementListPostAsync, _authTokens.SessionToken, generatedPodAppEntitlement);
                if (podAppEnttlementsGenerated == null)
                    return null;

                return podAppEnttlementsGenerated.Select(x => PodAppEntitlementFactory.Create(x));

            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to update application entitlements");
                throw;
            }
        }
        /// <summary>
        /// Get the list of  application entitlements for the user
        /// </summary>
        /// <param name="uid">User id</param>
        /// <returns>List of application entitlements for the user</returns>
        public IEnumerable<UserAppEntitlement> GetUserAppEntitlements(long uid)
        {
            try
            {
                var userAppEntitlements = _apiExecutor.Execute(_appEntitlementsApi.V1UserAppEntitlementListGetAsync, _authTokens.SessionToken, uid);
                if (userAppEntitlements == null)
                    return null;
                return userAppEntitlements.Select(x => UserAppEntitlementFactory.Create(x));
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to update application entitlements");
                throw;
            }
        }
        /// <summary>
        /// Get the list of  application entitlements for the user
        /// </summary>
        /// <param name="uid">User id</param>
        /// <param name="appEntitlements"></param>
        /// <returns>List of updated application entitlements for the user</returns>
        public IEnumerable<UserAppEntitlement> UpdateUserAppEntitlements(long uid, IEnumerable<UserAppEntitlement> appEntitlements)
        {
            try
            {
                if (appEntitlements == null)
                    return null;
                var generatedUserAppEntitlements = appEntitlements.Select(x => CreateSymphonyUserAppEntitlement(x));
                var updatedAppEntitlements = _apiExecutor.Execute(_appEntitlementsApi.V1UserAppEntitlementListPostAsync, _authTokens.SessionToken, uid, generatedUserAppEntitlements);
                if (updatedAppEntitlements == null)
                    return null;
                return updatedAppEntitlements.Select(x => UserAppEntitlementFactory.Create(x));
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to update application entitlements");
                throw;
            }
        }
        private Generated.OpenApi.PodApi.UserAppEntitlement CreateSymphonyUserAppEntitlement(UserAppEntitlement userAppEntitlement)
        {
            Generated.OpenApi.PodApi.Product prodEntityToGenConverted(Product x) { return new Generated.OpenApi.PodApi.Product { AppId = x.AppId, Name = x.Name, Sku = x.Sku, Subscribed = x.Subscribed, Type = x.Type }; }
            var generatedPodAppEntitlement = new Generated.OpenApi.PodApi.UserAppEntitlement
            {
                AppId = userAppEntitlement.AppId,
                AppName = userAppEntitlement.AppName,
                Products = new ObservableCollection<Generated.OpenApi.PodApi.Product>(userAppEntitlement.Products?.Select(y => prodEntityToGenConverted(y))),
                Install = userAppEntitlement.Install,
                Listed = userAppEntitlement.Listed
            };
            return generatedPodAppEntitlement;
        }
    }
}
