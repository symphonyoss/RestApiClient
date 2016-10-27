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

namespace SymphonyOSS.RestApiClient.Entities
{
    public class User
    {
        public long Id { get; }
        
        public string EmailAddress { get; }

        public string FirstName { get; }
        
        public string LastName { get; }
        
        public string DisplayName { get; }
        
        public string Title { get; }
        
        public string Company { get; }
        
        public string Username { get; }
        
        public string Location { get; }

        public User(
            long id, string emailAddress,
            string firstName, string lastName, string displayName,
            string title, string company,
            string username, string location)
        {
            Id = id;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            DisplayName = displayName;
            Title = title;
            Company = company;
            Username = username;
            Location = location;
        }
    }
}
