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
using SymphonyOSS.RestApiClient.Factories;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi;

namespace SymphonyOSS.RestApiClient.Tests
{
    using Xunit;

    public class ConnectionFactoryTest
    {
        [Fact]
        public void EnsureCreation_sets_null_timestamps_to_min_value()
        {
            var connection = ConnectionFactory.Create(new UserConnection() { UserId = 12345, Status = UserConnectionStatus.ACCEPTED});
            Assert.Equal(DateTime.MinValue, connection.FirstRequestedAt);
            Assert.Equal(DateTime.MinValue, connection.UpdatedAt);
        }
    }
}
