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

namespace SymphonyOSS.RestApiClient.MessageML
{
    using System.IO;
    using System.Text;
    using System.Xml;

    /// <summary>
    /// Provides a method for parsing messageML to plain text.
    /// </summary>
    public class MessageParser
    {
        private static readonly IXmlRenderer DefaultCashTagRenderer = new DefaultCashTagRenderer();

        private static readonly IXmlRenderer DefaultHashTagRenderer = new DefaultHashTagRenderer();

        private static readonly IXmlRenderer DefaultLinkRenderer = new DefaultLinkRenderer();

        private static readonly IXmlRenderer DefaultMentionRenderer = new DefaultMentionRenderer();

        private static readonly IXmlRenderer DefaultNewLineRenderer = new DefaultNewLineRenderer();

        public MessageParser()
        {
            CashTagRenderer = DefaultCashTagRenderer;
            HashTagRenderer = DefaultHashTagRenderer;
            LinkRenderer = DefaultLinkRenderer;
            MentionRenderer = DefaultMentionRenderer;
            NewLineRenderer = DefaultNewLineRenderer;
        }

        /// <summary>
        /// The renderer to use for cash tags (<cash tag="CASH"/>).
        /// </summary>
        public IXmlRenderer CashTagRenderer { get; set; }

        /// <summary>
        /// The renderer to use for hash tags (<hash tag="hash"/>).
        /// </summary>
        public IXmlRenderer HashTagRenderer { get; set; }

        /// <summary>
        /// The renderer to use for links (<a href="https://link"/>).
        /// </summary>
        public IXmlRenderer LinkRenderer { get; set; }

        /// <summary>
        /// The renderer to use for @mentions (<mention uid="12345"/>).
        /// </summary>
        public IXmlRenderer MentionRenderer { get; set; }

        /// <summary>
        /// The renderer to use for new lines (<br/>).
        /// </summary>
        public IXmlRenderer NewLineRenderer { get; set; }

        /// <summary>
        /// Parses a messageML message to plain text.
        /// </summary>
        /// <param name="messageMl">The messageML as a string.</param>
        /// <returns>The plain text.</returns>
        public string GetPlainText(string messageMl)
        {
            var reader = XmlReader.Create(new StringReader(messageMl));
            var result = new StringBuilder();
            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    switch (reader.Name)
                    {
                        case "cash":
                            result.Append(CashTagRenderer.Render(reader));
                            break;
                        case "hash":
                            result.Append(HashTagRenderer.Render(reader));
                            break;
                        case "a":
                            result.Append(LinkRenderer.Render(reader));
                            break;
                        case "mention":
                            result.Append(MentionRenderer.Render(reader));
                            break;
                        case "br":
                            result.Append(NewLineRenderer.Render(reader));
                            break;
                    }
                }
                else
                {
                    result.Append(reader.Value);
                }
            }

            return result.ToString();
        }
    }
}
