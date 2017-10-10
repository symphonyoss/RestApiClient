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

namespace SymphonyOSS.RestApiClient.Api
{
    using System;
    using System.Net;
    using Authentication;

    /// <summary>
    /// Retries once on unauthorized (401) exceptions, after refreshing
    /// the authentication tokens.
    /// </summary>
    public class RefreshTokensRetryStrategy : IRetryStrategy
    {
        private readonly ISessionManager _authTokens;

        public RefreshTokensRetryStrategy(ISessionManager authTokens)
        {
            _authTokens = authTokens;
        }

        public bool ShouldRetry(Exception e, int retries)
        {
            if (retries > 0)
            {
                return false;
            }

            if (e is AggregateException)
            {
                e = e.InnerException;
            }

            var agentApiException = e as Generated.OpenApi.AgentApi.SwaggerException;
            var errorCode = agentApiException?.StatusCode;
            if (errorCode == null)
            {
                var podApiException = e as Generated.OpenApi.PodApi.SwaggerException;
                errorCode = podApiException?.StatusCode;
            }

            if (errorCode == ((int) HttpStatusCode.Unauthorized).ToString())
            {
                _authTokens.GenerateTokens();
                return true;
            }

            return false;
        }
    }
}
