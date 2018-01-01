namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using Microsoft.Extensions.Logging;
    using SymphonyOSS.RestApiClient.Authentication;
    using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi;
    using SymphonyOSS.RestApiClient.Logging;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    public class AppEntitlementsApi
    {
        private readonly ILogger _log;

        private readonly AdminClient _appEntitlementsApi;

        private readonly IAuthTokens _authTokens;

        private readonly IApiExecutor _apiExecutor;

        public AppEntitlementsApi(IAuthTokens authTokens, string baseUrl, HttpClient httpClient, IApiExecutor apiExecutor)
        {
            _log = ApiLogging.LoggerFactory?.CreateLogger<AppEntitlementsApi>();

            _appEntitlementsApi = new AdminClient(baseUrl, httpClient);
            _authTokens = authTokens;
            _apiExecutor = apiExecutor;
        }

        public IEnumerable<PodAppEntitlement> GetAllAppEntitlements()
        {
            try
            {
                return _apiExecutor.Execute(_appEntitlementsApi.V1AppEntitlementListGetAsync, _authTokens.SessionToken);
            }
            catch (Exception e)
            {
                _log?.LogError(0, e, "An error has occured while trying to retrieve application entitlements");
                throw;
            }
        }

    }
}
