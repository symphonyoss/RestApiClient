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

namespace SymphonyOSS.RestApiClient.Api.AuthenticationApi
{
    public class AppAuthenticationApi : IAppAuthenticationApi
    {
        private readonly AppClient _client;
        public AppAuthenticationApi(string baseUrl, HttpClient httpClient)
        {
            _client = new AppClient(baseUrl, httpClient);
        }

        public X509Certificate2 GetPodCertificate()
        {
            try
            {
                return _client.V1PodCertificateAsync(default(CancellationToken)).Result.ToX509Certificate();
            }
            catch (Exception e)
            {
                throw ApiException.CreateFromException(e);
            }
        }

        public string UserAuthenticate(long userId, string appSessionToken)
        {
            return _client.V1UserAuthenticateAsync(userId, appSessionToken).Result.SessionToken;
        }

        public string Authenticate()
        {
            return _client.V1AuthenticateAsync().Result.Token1;
        }
    }
}
