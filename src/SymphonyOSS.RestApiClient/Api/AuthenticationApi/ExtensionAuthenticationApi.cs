using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
