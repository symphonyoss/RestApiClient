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

namespace SymphonyOSS.RestApiClient.Tests
{
    using Xunit;
    using SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client;
    using System.Collections.Generic;
    using System;
    using System.Text;
    using RestSharp.Portable;
    using SymphonyOSS.RestApiClient.Entities;
    public class AgentApiClientTests
    {

        // There is a bug with Swagger code gen for c# where the request's content type
        // will only be set to multipart form-data if there is a file attachment since
        // the default collection mode is MultiPartForFileParameters. We edited the
        // generated code, so this will test that change

        [Fact]
        void TestFormDataRequest()
        {
            var client = new ApiClient();
            var formParams = new Dictionary<string, string>()
            {
                { "foo", "bar" }
            };

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>() { { "foo", "bar" } };
            var localVarFileParams = new Dictionary<String, FileParameter>();

            var response = client.PrepareRequestWrapper("/", RestSharp.Portable.Method.POST, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams, localVarPathParams, "multipart/form-data");
            Assert.Equal(response.ContentCollectionMode, ContentCollectionMode.MultiPart);
        }

        [Fact]
        void TestFileParameterModification()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("foo");
            var stream = new NamedStream("myFile.txt", bytes);
            var client = new ApiClient();
            var result = client.ParameterToFile("bar", stream);

            Assert.Equal(result.FileName, "myFile.txt");
            Assert.Equal(result.Name, "bar");

        }
    }
}