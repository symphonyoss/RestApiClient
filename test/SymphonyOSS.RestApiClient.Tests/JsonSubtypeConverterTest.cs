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
    using Newtonsoft.Json;
    using Generated.Json;
    using Generated.OpenApi.AgentApi.Model;
    using Xunit;

    public class JsonSubtypeConverterTest
    {
        [Fact]
        public void EnsureV2Message_can_be_deserialized()
        {
            JsonSubtypeConverter.Register(typeof(V2Message));
            var json =
                "{" +
                "  \"id\": \"id\", " +
                "  \"timestamp\": \"timestamp\", " +
                "  \"v2messageType\": \"V2Message\", " +
                "  \"streamId\": \"streamId\", " +
                "  \"message\": \"contents\", " +
                "  \"fromUserId\": 123" +
                "}";
            var message = JsonConvert.DeserializeObject(json, typeof(V2BaseMessage)) as V2BaseMessage;
            Assert.IsType(typeof(V2Message), message);
            Assert.Equal("contents", ((V2Message)message).Message);
            Assert.Equal(123, ((V2Message)message).FromUserId);
        }
    }

}
