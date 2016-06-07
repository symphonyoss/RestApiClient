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
    using Api;
    using Api.PodApi;
    using Authentication;
    using Generated.OpenApi.PodApi.Client;

    /// <summary>
    /// Constructs an instance of an Api available in the PodApi,
    /// eg <see cref="PresenceApi"/>, <see cref="StreamsApi"/>, or <see cref="UsersApi"/>.
    /// </summary>
    public class PodApiFactory
    {
        private readonly string _baseUrl;

        public PodApiFactory(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// Constructs a MessageSuppressionApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The MessageSuppressionApi instance.</returns>
        public MessageSuppressionApi CreateMessageSuppressionApi(SessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<MessageSuppressionApi>(sessionManager, apiExecutor);
        }

        /// <summary>
        /// Constructs a PresenceApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The PresenceApi instance.</returns>
        public PresenceApi CreatePresenceApi(SessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<PresenceApi>(sessionManager, apiExecutor);
        }

        /// <summary>
        /// Constructs a SessionApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The SessionApi instance.</returns>
        public SessionApi CreateSessionApi(SessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<SessionApi>(sessionManager, apiExecutor);
        }

        /// <summary>
        /// Constructs a StreamsApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The StreamsApi instance.</returns>
        public StreamsApi CreateStreamsApi(SessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<StreamsApi>(sessionManager, apiExecutor);
        }

        /// <summary>
        /// Constructs a SystemApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The SystemApi instance.</returns>
        public SystemApi CreateSystemApi(SessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<SystemApi>(sessionManager, apiExecutor);
        }

        /// <summary>
        /// Constructs a UsersApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The UsersApi instance.</returns>
        public UsersApi CreateUsersApi(SessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<UsersApi>(sessionManager, apiExecutor);
        }

        private T Create<T>(SessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            var apiClient = new ApiClient(_baseUrl)
            {
                RestClient =
                {
                    ClientCertificates = new X509Certificate2Collection
                    {
                        sessionManager.Certificate
                    }
                }
            };
            var configuration = new Configuration(apiClient);
            if (apiExecutor == null)
            {
                var retryStrategy = new RefreshTokensRetryStrategy(sessionManager);
                apiExecutor = new RetryStrategyApiExecutor(retryStrategy);
            }

            return ApiFactoryUtils.CallConstructor<T>(new object[] { sessionManager, configuration, apiExecutor });
        }
    }
}
