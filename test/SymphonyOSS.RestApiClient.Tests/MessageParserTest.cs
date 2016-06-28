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
    using System;
    using MessageML;
    using Xunit;

    public class MessageParserTest
    {
        private MessageParser _messageParser;

        public MessageParserTest()
        {
            _messageParser = new MessageParser();
        }

        [Fact]
        public void EnsureGets_plain_text_from_simple_messageML()
        {
            var plainText = _messageParser.GetPlainText("<messageML>simple message</messageML>");
            Assert.Equal("simple message", plainText);
        }

        [Fact]
        public void EnsureGets_plain_text_from_bold_and_italic()
        {
            var plainText = _messageParser.GetPlainText("<messageML>message with <b>bold</b> and <i>italic</i></messageML>");
            Assert.Equal("message with bold and italic", plainText);
        }

        [Fact]
        public void EnsureGets_plain_text_from_hash_and_cash_tags()
        {
            var plainText = _messageParser.GetPlainText("<messageML>message with <hash tag=\"hash\"/> and <cash tag=\"CASH\"/></messageML>");
            Assert.Equal("message with #hash and $CASH", plainText);
        }

        [Fact]
        public void EnsureGets_plain_text_from_link()
        {
            var plainText = _messageParser.GetPlainText("<messageML>message with <a href=\"https://link\"/></messageML>");
            Assert.Equal("message with https://link", plainText);
        }

        [Fact]
        public void EnsureGets_plain_text_for_a_user_mention()
        {
            var plainText = _messageParser.GetPlainText("<messageML>message with <mention uid=\"12345\"/></messageML>");
            Assert.Equal("message with @12345", plainText);
        }

        [Fact]
        public void EnsureGets_plain_text_with_line_breaks()
        {
            var plainText = _messageParser.GetPlainText("<messageML>message with<br/>line break</messageML>");
            Assert.Equal("message with" + Environment.NewLine + "line break", plainText);
        }
    }
}
