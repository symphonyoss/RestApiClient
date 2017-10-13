using System;
using System.Collections.Generic;
using System.Text;

namespace SymphonyOSS.RestApiClient.Api.AuthenticationApi
{
    public class ExtensionAppTokens
    {
        internal ExtensionAppTokens(Generated.OpenApi.AuthenticatorApi.ExtensionAppTokens generatedTokens)
        {
            AppId = generatedTokens.AppId;
            AppToken = generatedTokens.AppToken;
            ExpireAt = generatedTokens.ExpireAt;
            SymphonyToken = SymphonyToken;
        }

        public string AppId { get; set; }

        public string AppToken { get; set; }

        /// <summary>unix timestamp when the token expired</summary>
        public long? ExpireAt { get; set; }
        public string SymphonyToken { get; set; }

    }
}