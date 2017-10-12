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

namespace SymphonyOSS.RestApiClient.Authentication
{
    using System.Security.Cryptography.X509Certificates;
    using Factories;
    using Generated.OpenApi.AuthenticatorApi;

    /// <summary>
    /// Contains the session and key manager tokens needed for authentication, and
    /// the logic for generating these tokens using the authentication endpoints.
    /// </summary>
    public class UserSessionManager : ISessionManager
    {
        private readonly IAuthenticateClient _sessionAuthApi;

        private readonly IAuthenticateClient _keyAuthApi;

        private string _sessionToken;

        private string _keyManagerToken;

        public UserSessionManager(string sessionAuthUrl, string keyAuthUrl, X509Certificate2 certificate)
        {
            Certificate = certificate;
            var sessionAuthApiFactory = new AuthenticatorApiFactory(sessionAuthUrl);
            var keyAuthApiFactory = new AuthenticatorApiFactory(keyAuthUrl);
            _sessionAuthApi = sessionAuthApiFactory.CreateAuthenticationApi(certificate);
            _keyAuthApi = keyAuthApiFactory.CreateAuthenticationApi(certificate);
        }

        public UserSessionManager(IAuthenticateClient sessionAuthApi, IAuthenticateClient keyAuthApi, X509Certificate2 certificate)
        {
            Certificate = certificate;
            _sessionAuthApi = sessionAuthApi;
            _keyAuthApi = keyAuthApi;
        }

        public X509Certificate2 Certificate { get; }

        public string SessionToken
        {
            get
            {
                if (_sessionToken == null)
                {
                    GenerateSessionToken();
                }

                return _sessionToken;
            }
        }

        public string KeyManagerToken
        {
            get
            {
                if (_keyManagerToken == null)
                {
                    GenerateKeyManagerToken();
                }

                return _keyManagerToken;
            }
        }

        /// <summary>
        /// Generates both the session and key manager tokens.
        /// </summary>
        public void GenerateTokens()
        {
            GenerateSessionToken();
            GenerateKeyManagerToken();
        }

        /// <summary>
        /// Generates the session token by calling the authentication endpoint.
        /// </summary>
        public void GenerateSessionToken()
        {
            _sessionToken = _sessionAuthApi.V1Async().Result.Token1;
        }

        /// <summary>
        /// Generates the key manager token by calling the authentication endpoint.
        /// </summary>
        public void GenerateKeyManagerToken()
        {
            _keyManagerToken = _keyAuthApi.V1Async().Result.Token1;
        }
    }
}
