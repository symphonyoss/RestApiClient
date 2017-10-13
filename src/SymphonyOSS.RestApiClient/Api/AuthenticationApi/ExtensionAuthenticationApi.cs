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
using System.Net.Http;
using SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi;

namespace SymphonyOSS.RestApiClient.Api.AuthenticationApi
{
    public class ExtensionAuthenticationApi : IExtensionAuthenticationApi
    {
        private readonly AuthenticateClient _client;
        public ExtensionAuthenticationApi(string baseUrl, HttpClient httpClient)
        {
            _client = new AuthenticateClient(baseUrl, httpClient);
        }

        public ExtensionAppTokens StartExtensionAuthentication(string token)
        {
            try
            {
                var returnTokens = _client.V1ExtensionappAsync(new AuthenticateRequest() {AppToken = token}).Result;
                return new ExtensionAppTokens(returnTokens);
            }
            catch (Exception e)
            {
                throw ApiException.CreateFromException(e);
            }
        }
    }
}
