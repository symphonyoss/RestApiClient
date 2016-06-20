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
    using Api.AgentApi;
    using Authentication;
    using Generated.OpenApi.AgentApi.Client;

    /// <summary>
    /// Constructs an instance of an API available in the AgentApi,
    /// eg <see cref="DatafeedApi"/> and <see cref="MessagesApi"/>.
    /// </summary>
    public class AgentApiFactory
    {
        private readonly string _baseUrl;

        public AgentApiFactory(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// Constructs an AttachmentsApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The AttachmentsApi instance.</returns>
        public AttachmentsApi CreateAttachmentsApi(ISessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<AttachmentsApi>(sessionManager, apiExecutor);
        }

        /// <summary>
        /// Constructs a DatafeedApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The DatafeedApi instance.</returns>
        public DatafeedApi CreateDatafeedApi(ISessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<DatafeedApi>(sessionManager, apiExecutor);
        }

        /// <summary>
        /// Constructs a MessagesApi instance using the provided session manager
        /// for authentication.
        /// </summary>
        /// <param name="sessionManager">Session manager used for authentication.</param>
        /// <param name="apiExecutor">The executor, if none is provided <see cref="RetryStrategyApiExecutor"/>
        /// with a <see cref="RefreshTokensRetryStrategy"/> will be used.</param>
        /// <returns>The MessagesApi instance.</returns>
        public MessagesApi CreateMessagesApi(ISessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<MessagesApi>(sessionManager, apiExecutor);
        }

        public UtilApi CreateUtilApi(ISessionManager sessionManager, IApiExecutor apiExecutor = null)
        {
            return Create<UtilApi>(sessionManager, apiExecutor);
        }

        private T Create<T>(ISessionManager sessionManager, IApiExecutor apiExecutor = null)
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
