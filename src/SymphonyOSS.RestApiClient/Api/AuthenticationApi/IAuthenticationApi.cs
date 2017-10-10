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

using SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi;

namespace SymphonyOSS.RestApiClient.Api.AuthenticationApi
{
    public interface IAppAuthenticationApi
    {
        /// <summary>
        /// Get the certificate used to sign the JWT issued by this pod.
        /// </summary>
        /// <returns>the signing certificate</returns>
        PodCertificate GetPodCertificate();

        /// <summary>
        /// Generate an OBO (on-behalf-of) session token for the given user
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="appSessionToken">Application session token, obtained from Authenticate</param>
        /// <returns>The session token</returns>
        string UserAuthenticate(long userId, string appSessionToken);

        /// <summary>
        /// Generate an application session token
        /// </summary>
        /// <returns>The session token</returns>
        string Authenticate();
    }
}
