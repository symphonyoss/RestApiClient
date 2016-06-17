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
    using Authentication;
    using Generated.OpenApi.PodApi.Client;
    using Generated.OpenApi.PodApi.Model;

    /// <summary>
    /// Provides methods for suppressing messages.
    /// Encapsulates <see cref="Generated.OpenApi.PodApi.Api.MessageSuppressionApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class MessageSuppressionApi
    {
        private readonly Generated.OpenApi.PodApi.Api.IMessageSuppressionApi _messageSuppressionApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSuppressionApi" /> class.
        /// Provides methods for discovering functions available through the API endpoints.
        /// Encapsulates <see cref="Generated.OpenApi.PodApi.Api.MessageSuppressionApi"/>,
        /// adding authentication token management and a custom execution strategy.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public MessageSuppressionApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _messageSuppressionApi = new Generated.OpenApi.PodApi.Api.MessageSuppressionApi();
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Suppresses a message.
        /// </summary>
        /// <param name="id">URL-safe message ID.</param>
        /// <returns>The response.</returns>
        public MessageSuppressionResponse SuppressMessage(string id)
        {
            return _apiExecutor.Execute(_messageSuppressionApi.V1AdminMessagesuppressionIdSuppressPost, id, _authTokens.SessionToken);
        }
    }
}
