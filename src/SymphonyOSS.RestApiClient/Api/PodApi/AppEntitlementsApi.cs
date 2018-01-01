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
    using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi;
    using SymphonyOSS.RestApiClient.Logging;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    public class AppEntitlementsApi
    {
        private readonly ILogger _log;

        private readonly AdminClient _appEntitlementsApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        public AppEntitlementsApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _log = ApiLogging.LoggerFactory?.CreateLogger<AppEntitlementsApi>();

            _appEntitlementsApi = new AdminClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        public IEnumerable<PodAppEntitlement> GetAllAppEntitlements()
        {
            try
            {
                return _apiExecutor.Execute(_appEntitlementsApi.V1AppEntitlementListGetAsync, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to retrieve application entitlements");
                throw;
            }
        }

    }
}
