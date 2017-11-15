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

using System.Net.Http;
using System.Threading;
using SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi;
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Logging;
using SymphonyOSS.RestApiClient.Logging;

namespace SymphonyOSS.RestApiClient.Api.AuthenticationApi
{
    public class AppAuthenticationApi : IAppAuthenticationApi
    {
        private readonly AppClient _client;
        private readonly ILogger _log;

        public AppAuthenticationApi(string baseUrl, HttpClient httpClient)
        {
            _client = new AppClient(baseUrl, httpClient);
            _log = ApiLogging.LoggerFactory?.CreateLogger<AppAuthenticationApi>();
        }

        public X509Certificate2 GetPodCertificate()
        {
            try
            {
                return _client.V1PodCertificateAsync(default(CancellationToken)).Result.ToX509Certificate();
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to retrieve the pod certificate.");
                throw ApiException.CreateFromException(e);
            }
        }

        public string UserAuthenticate(long userId, string appSessionToken)
        {
            try
            {
                return _client.V1UserAuthenticateAsync(userId, appSessionToken).Result.SessionToken;
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to generate an OBO (on-behalf-of) session token for the given user {userId}.", userId);
                throw;
            }
        }

        public string Authenticate()
        {
            try
            {
                return _client.V1AuthenticateAsync().Result.Token1;
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to generate an application session token.");
                throw;
            }
        }
    }
}
