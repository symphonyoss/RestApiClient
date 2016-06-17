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
    /// Provides methods for managing the company certificates, by encapsulating
    /// <see cref="Generated.OpenApi.PodApi.Api.SecurityApi"/>,
    /// adding authentication token management and a custom execution strategy.
    /// </summary>
    public class SecurityApi
    {
        private readonly Generated.OpenApi.PodApi.Api.SecurityApi _securityApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi" /> class.
        /// See <see cref="Factories.PodApiFactory"/> for conveniently constructing
        /// an instance.
        /// </summary>
        /// <param name="authTokens">Authentication tokens.</param>
        /// <param name="configuration">Api configuration.</param>
        /// <param name="apiExecutor">Execution strategy.</param>
        public SecurityApi(IAuthTokens authTokens, Configuration configuration, IApiExecutor apiExecutor)
        {
            _securityApi = new Generated.OpenApi.PodApi.Api.SecurityApi(configuration);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Create a company trusted or untrusted certificate. 
        /// </summary>
        /// <returns>Success response.</returns>
        public SuccessResponse Create(CompanyCert cert)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertCreatePost, _authTokens.SessionToken, cert);
        }

        /// <summary>
        /// Delete a company certificate. 
        /// </summary>
        /// <returns>Success response.</returns>
        public SuccessResponse Delete(string fingerPrint)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertDeletePost, _authTokens.SessionToken, new StringId(fingerPrint));
        }

        /// <summary>
        /// Get the details of a company certificate.
        /// </summary>
        /// <returns>Company certificate details.</returns>
        public CompanyCertDetail Get(string fingerPrint)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertFingerPrintGetGet, fingerPrint, _authTokens.SessionToken);
        }

        /// <summary>
        /// Return a list of all certificates which were verified to the cert whose fingerprint is passed.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public CompanyCertInfoList GetIssued(string fingerPrint)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertFingerPrintIssuedByGet, fingerPrint, _authTokens.SessionToken);
        }

        /// <summary>
        /// Update a company certificate.
        /// </summary>
        /// <returns>Success response.</returns>
        public SuccessResponse Update(string fingerPrint, CompanyCertAttributes certAttributes)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertFingerPrintUpdatePost, fingerPrint, _authTokens.SessionToken, certAttributes);
        }

        /// <summary>
        /// List all trusted certs.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public CompanyCertInfoList Get(int? skip = null, int? limit = null)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertListGet, _authTokens.SessionToken, skip, limit);
        }

        /// <summary>
        /// List all trusted certs.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public CompanyCertInfoList GetPodManaged(int? skip = null, int? limit = null)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertPodmanagedListGet, _authTokens.SessionToken, skip, limit);
        }

        /// <summary>
        /// List all certs of the given types.
        /// </summary>
        /// <returns>List of certificates.</returns>
        public CompanyCertInfoList Get(CompanyCertTypeList typeIdList, int? skip = null, int? limit = null)
        {
            return _apiExecutor.Execute(_securityApi.V1CompanycertTypeListPost, typeIdList, _authTokens.SessionToken, skip, limit);
        }
    }
}
