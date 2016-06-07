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
    using System.Xml;

    /// <summary>
    /// Constructs message strings using MessageML markup.
    /// </summary>
    public class MessageBuilder
    {
        private readonly XmlDocument _xmlDocument;

        private readonly XmlElement _rootElement;

        public MessageBuilder()
        {
            _xmlDocument = new XmlDocument();
            _rootElement = _xmlDocument.CreateElement("messageML");
            _xmlDocument.AppendChild(_rootElement);
        }

        /// <summary>
        /// Constructs a message containing a chime. No other content is permitted
        /// with a chime.
        /// </summary>
        /// <returns>The chime message as a string.</returns>
        public static string Chime => "<chime/>";

        /// <summary>
        /// Appends plain text to the message.
        /// </summary>
        /// <param name="text">The plain text string.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder Text(string text)
        {
            var xmlText = _xmlDocument.CreateTextNode(text);
            _rootElement.AppendChild(xmlText);
            return this;
        }

        /// <summary>
        /// Appends text to be emboldened.
        /// </summary>
        /// <param name="text">The emboldened text string.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder Bold(string text)
        {
            var xmlElement = CreateTextElement("b", text);
            _rootElement.AppendChild(xmlElement);
            return this;
        }

        /// <summary>
        /// Appends text to be italicized.
        /// </summary>
        /// <param name="text">The italicized text string.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder Italic(string text)
        {
            var xmlElement = CreateTextElement("i", text);
            _rootElement.AppendChild(xmlElement);
            return this;
        }

        /// <summary>
        /// Appends a cash tag.
        /// </summary>
        /// <param name="tag">The cash tag.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder CashTag(string tag)
        {
            var xmlElement = CreateSingleAttributeElement("cash", "tag", tag);
            _rootElement.AppendChild(xmlElement);
            return this;
        }

        /// <summary>
        /// Appends a hash tag.
        /// </summary>
        /// <param name="tag">The hash tag.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder HashTag(string tag)
        {
            var xmlElement = CreateSingleAttributeElement("hash", "tag", tag);
            _rootElement.AppendChild(xmlElement);
            return this;
        }

        /// <summary>
        /// Appends an @mention for a user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder Mention(long userId)
        {
            var xmlElement = CreateSingleAttributeElement("mention", "uid", userId.ToString());
            _rootElement.AppendChild(xmlElement);
            return this;
        }

        /// <summary>
        /// Appends an @mention for a user.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder Mention(string email)
        {
            var xmlElement = CreateSingleAttributeElement("mention", "email", email);
            _rootElement.AppendChild(xmlElement);
            return this;
        }

        /// <summary>
        /// Appends a hyperlink.
        /// </summary>
        /// <param name="href">The URL.</param>
        /// <returns>Itself to allow for chaining.</returns>
        public MessageBuilder Link(string href)
        {
            var xmlElement = CreateSingleAttributeElement("a", "href", href);
            _rootElement.AppendChild(xmlElement);
            return this;
        }

        /// <summary>
        /// Constructs the string representation of this message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public override string ToString()
        {
            var xmlWriterSettings = new XmlWriterSettings { OmitXmlDeclaration = true };
            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings))
                {
                    _xmlDocument.WriteTo(xmlWriter);
                    xmlWriter.Flush();
                    return stringWriter.GetStringBuilder().ToString();
                }
            }
        }

        private XmlElement CreateTextElement(string elementName, string text)
        {
            var xmlElement = _xmlDocument.CreateElement(elementName);
            xmlElement.InnerText = text;
            return xmlElement;
        }

        private XmlElement CreateSingleAttributeElement(string elementName, string attributeName, string attributeValue)
        {
            var xmlElement = _xmlDocument.CreateElement(elementName);
            xmlElement.SetAttribute(attributeName, attributeValue);
            return xmlElement;
        }
    }
}
