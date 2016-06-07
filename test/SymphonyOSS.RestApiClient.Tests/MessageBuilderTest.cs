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
    using MessageML;
    using Xunit;

    public class MessageBuilderTest
    {
        [Fact]
        public void EnsureEmpty_message_contains_root_tag_but_no_xml_declaration()
        {
            var emptyMessage = new MessageBuilder().ToString();
            Assert.Equal("<messageML />", emptyMessage);
        }

        [Fact]
        public void EnsureBold_and_italic_are_inserted()
        {
            var emptyMessage = new MessageBuilder()
                .Bold("bold")
                .Italic("italic")
                .ToString();
            Assert.Equal("<messageML><b>bold</b><i>italic</i></messageML>", emptyMessage);
        }

        [Fact]
        public void EnsureA_link_is_inserted()
        {
            var emptyMessage = new MessageBuilder()
                .Link("https://symphony.foundation/")
                .ToString();
            Assert.Equal("<messageML><a href=\"https://symphony.foundation/\" /></messageML>", emptyMessage);
        }

        [Fact]
        public void EnsureHashtags_and_cashtags_are_inserted()
        {
            var emptyMessage = new MessageBuilder()
                .HashTag("hashtag")
                .CashTag("cashtag")
                .ToString();
            Assert.Equal("<messageML><hash tag=\"hashtag\" /><cash tag=\"cashtag\" /></messageML>", emptyMessage);
        }

        [Fact]
        public void EnsureMentions_are_inserted()
        {
            var emptyMessage = new MessageBuilder()
                .Mention(12345)
                .Mention("user@symphony.foundation")
                .ToString();
            Assert.Equal("<messageML><mention uid=\"12345\" /><mention email=\"user@symphony.foundation\" /></messageML>", emptyMessage);
        }
    }
}
