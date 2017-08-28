using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace SymphonyOSS.RestApiClient.Logging
{
    public class ApiLogging
    {
        // Set the global logger factory that will be used by the RestApiClient
        public static ILoggerFactory LoggerFactory { get; set; }
    }
}
