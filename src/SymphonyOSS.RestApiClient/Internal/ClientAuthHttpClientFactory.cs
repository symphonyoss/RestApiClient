using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using RestSharp.Portable.HttpClient.Impl;
using RestSharp.Portable;
using System.Net.Http;

namespace SymphonyOSS.RestApiClient.Internal
{
   internal class ClientAuthHttpClientFactory : DefaultHttpClientFactory
   {
      private X509Certificate2 _clientCert;

      internal ClientAuthHttpClientFactory(X509Certificate2 cert)
      {
         _clientCert = cert;
      }

      protected override HttpMessageHandler CreateMessageHandler(IRestClient client)
      {
         HttpMessageHandler handler = base.CreateMessageHandler(client);

         HttpClientHandler newHandler = handler as HttpClientHandler;
         newHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
         newHandler.ClientCertificates.Add(_clientCert);
         return newHandler;
      }
   }
}
