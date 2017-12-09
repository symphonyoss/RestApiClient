using System;
using AgentError = SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Error;
using PodError = SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Error;
using AuthError = SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Error;

namespace SymphonyOSS.RestApiClient.Api
{
    public class ApiException : Exception
    {
        public int HttpStatusCode { get; set; }
        public int? SymphonyError { get; set; }
        public string SymphonyErrorMessage { get; set; }

        // may not ned to expose this so making internal for now
        internal string RawMessage { get; set; }
        public static ApiException CreateFromException(Exception e)
        {
            if (e is ApiException)
            {
                return e as ApiException;
            }

            if (e is AggregateException)
            {
                e = e.InnerException;
            }

            if (e is SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.SwaggerException<AgentError>)
            {
                return new ApiException(e as SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.SwaggerException<AgentError>);
            }
            if (e is SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.SwaggerException)
            {
                return new ApiException(e as SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.SwaggerException);
            }

            if (e is SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.SwaggerException<PodError>)
            {
                return new ApiException(e as SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.SwaggerException<AgentError>);
            }
            if (e is SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.SwaggerException)
            {
                return new ApiException(e as SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.SwaggerException);
            }

            if (e is SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.SwaggerException<AgentError>)
            {
                return new ApiException(e as SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.SwaggerException<AuthError>);
            }
            if (e is SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.SwaggerException)
            {
                return new ApiException(e as SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.SwaggerException);
            }

            return new ApiException(e.Message, e, 0);
        }

        public ApiException(string message, Exception innerException, int httpStatusCode) : base(message, innerException)
        {
            HttpStatusCode = httpStatusCode;
        }

        internal ApiException(SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.SwaggerException ex) : base(ex.Message, ex)
        {
            HttpStatusCode = ParseStatusCode(ex.StatusCode);
            RawMessage = ex.Response;
        }

        internal ApiException(SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.SwaggerException<AgentError> ex) : base(ex.Message, ex)
        {
            HttpStatusCode = ParseStatusCode(ex.StatusCode);
            RawMessage = ex.Response;
            SymphonyError = ex.Result.Code;
            SymphonyErrorMessage = ex.Result.Message;
        }

        internal ApiException(SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.SwaggerException ex) : base(ex.Message, ex)
        {
            HttpStatusCode = ParseStatusCode(ex.StatusCode);
            RawMessage = ex.Response;
        }

        internal ApiException(SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.SwaggerException<PodError> ex) : base(ex.Message, ex)
        {
            HttpStatusCode = ParseStatusCode(ex.StatusCode);
            RawMessage = ex.Response;
            SymphonyError = ex.Result.Code;
            SymphonyErrorMessage = ex.Result.Message;
        }

        internal ApiException(SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.SwaggerException ex) : base(ex.Message, ex)
        {
            HttpStatusCode = ParseStatusCode(ex.StatusCode);
            RawMessage = ex.Response;
        }

        internal ApiException(SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.SwaggerException<AuthError> ex) : base(ex.Message, ex)
        {
            HttpStatusCode = ParseStatusCode(ex.StatusCode);
            RawMessage = ex.Response;
            SymphonyError = ex.Result.Code;
            SymphonyErrorMessage = ex.Result.Message;
        }

        private static int ParseStatusCode(string statusCode)
        {
            return int.TryParse(statusCode, out var retval) ? retval : 0;
        }
    }
}
