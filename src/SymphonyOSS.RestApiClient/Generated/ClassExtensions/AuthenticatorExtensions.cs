// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Model

{
    public partial class PodCertificate : IEquatable<PodCertificate>
    {
        private static X509Certificate2 CertFromPem(string pem)
        {
            string type = "CERTIFICATE";
            string header = String.Format("-----BEGIN {0}-----", type);
            string footer = String.Format("-----END {0}-----", type);
            int start = pem.IndexOf(header) + header.Length;
            int end = pem.IndexOf(footer, start);
            string base64 = pem.Substring(start, (end - start));
            return new X509Certificate2(Convert.FromBase64String(base64));
        }

        /// <summary>
        /// Returns an X509Certificate representing this object by decoding the
        /// the PEM encoded certificate string and creating an X509Certificate 
        /// instance
        /// </summary>
        /// <returns>X509Certificate representing this certificate</returns>
        public X509Certificate2 ToX509Certificate()
        {
            return CertFromPem(Certificate);
        }
    }
}
