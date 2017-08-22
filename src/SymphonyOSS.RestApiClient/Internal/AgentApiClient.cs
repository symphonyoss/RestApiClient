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
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Client
{
    public partial class ApiClient
    {
        // The generated code's version of PrepareRequest is marked internal
        // so it is not accessible to our unit tests project. This function 
        // wraps the private function so that the unit tests can call into it
        internal RestRequest PrepareRequestWrapper(
    String path, Method method, List<KeyValuePair<String, String>> queryParams, Object postBody,
    Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
    Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
    String contentType)
        {
            return PrepareRequest(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        }

    }
}