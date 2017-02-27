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
    using System.Security.Cryptography.X509Certificates;
    using Generated.OpenApi.AuthenticatorApi.Api;
    using Generated.OpenApi.AuthenticatorApi.Client;

    /// <summary>
    /// Constructs an instance of an Api available in the AuthenticatorApi,
    /// eg <see cref="AuthenticationApi"/>.
    /// </summary>
    public class AuthenticatorApiFactory
    {
        private readonly string _baseUrl;

        public AuthenticatorApiFactory(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// Constructs an AuthenticationApi using the provided client certificate
        /// for authentication.
        /// </summary>
        /// <param name="certificate">Client certificate used for authentication.</param>
        /// <returns>The AuthenticationApi.</returns>
        public AuthenticationApi CreateAuthenticationApi(X509Certificate2 certificate)
        {
            return Create<AuthenticationApi>(certificate);
        }

        /// <summary>
        /// Constructs a PodApi instance using the provided client certificate for
        /// // authentication
        /// </summary>
        /// <param name="certificate">Client certificate used for authentication.</param>
        /// <returns>The PodApi.</returns>
        public PodApi CreatePodApi(X509Certificate2 certificate)
        {
            return Create<PodApi>(certificate);
        }
        /// <summary>
        /// Constructs an AuthenticatorApi instance using the provided client certificate
        /// for authentication.
        /// </summary>
        /// <typeparam name="T">The type of AuthenticatorApi instance to construct.</typeparam>
        /// <param name="certificate">Client certificate used for authentication.</param>
        /// <returns>The AuthenticatorApi instance.</returns>
        private T Create<T>(X509Certificate2 certificate)
        {
            var apiClient = new ApiClient(_baseUrl)
            {
                RestClient =
                {
                    ClientCertificates = new X509Certificate2Collection
                    {
                        certificate
                    }
                }
            };
            var configuration = new Configuration(apiClient);
            return ApiFactoryUtils.CallConstructor<T>(new object[] { configuration });
        }
    }
}
