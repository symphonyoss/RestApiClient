using System;
using System.Collections.Generic;
using System.Text;

namespace SymphonyOSS.RestApiClient.Api.AuthenticationApi
{
    interface IExtensionAuthenticationApi
    {
        ExtensionAppTokens StartExtensionAuthentication(string token);
    }
}
