namespace SymphonyOSS.RestApiClient.Api.PodApi
{
    using System;
    using Entities;

    /// <summary>
    /// Event data for connection requests.
    /// </summary>
    public class ConnectionRequestEventArgs : EventArgs
    {
        public ConnectionRequestEventArgs(Connection connection)
        {
            Connection = connection;
        }

        public Connection Connection { get; private set; }
    }
}
