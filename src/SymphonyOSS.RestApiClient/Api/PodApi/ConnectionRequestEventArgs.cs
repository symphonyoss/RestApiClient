namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using System;
    using Generated.OpenApi.PodApi.Model;

    /// <summary>
    /// Event data for connection requests.
    /// </summary>
    public class ConnectionRequestEventArgs : EventArgs
    {
        public ConnectionRequestEventArgs(UserConnection connection)
        {
            Connection = connection;
        }

        public UserConnection Connection { get; private set; }
    }
}
