using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using SymphonyOSS.RestApiClient.Factories;
using SymphonyOSS.RestApiClient.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Newtonsoft.Json;
using SymphonyOSS.RestApiClient.Entities;
using SymphonyOSS.RestApiClient.Logging;

namespace DevelopmentTest
{

    public class OboSessionManger : ISessionManager
    {
        public OboSessionManger(string token)
        {
            SessionToken = token;
        }

        public X509Certificate2 Certificate => null;

        public string SessionToken { get; }

        public string KeyManagerToken { get; }

        public void GenerateTokens()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole(LogLevel.Debug);
            ApiLogging.LoggerFactory = loggerFactory;

            // get the settings file that contains certificate and other information
            var settingsContents = File.ReadAllText("s:\\settings\\RestApiSettings.json");
            var settings = JsonConvert.DeserializeObject<Settings>(settingsContents);

            var certBytes = Convert.FromBase64String(settings.certificate);
            X509Certificate2 certificate = new X509Certificate2(certBytes, settings.certificatePassword);

            var sessionManager = new UserSessionManager(settings.sessionauthUrl, settings.keyauthUrl, certificate);
            var agentApiFactory = new AgentApiFactory(settings.agentUrl);


            var messagesApi = agentApiFactory.CreateMessagesApi(sessionManager);

            var messageSubmit = new MessageSubmit("4O97z9WiybT5llo1u43bWX___qOAkG-edA", "<messageML>hello</messageML>");

            messagesApi.PostMessage(messageSubmit);

            return;
            var datafeedApi = agentApiFactory.CreateDatafeedApi(sessionManager);

            datafeedApi.OnMessage += (sender, e) =>
            {
                var message = e.Message;
                Console.WriteLine(message.Body);

            };

            try
            {
                datafeedApi.Listen();

            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Hello World!");
        }
    }
}