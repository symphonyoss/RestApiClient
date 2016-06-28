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

namespace SymphonyOSS.RestApiClient.Generated.Json
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SubtypeAlreadyRegisteredException : Exception
    {
        public string TagValue { get; private set; }

        public Type RootType { get; private set; }

        public Type OldType { get; private set; }

        public Type NewType { get; private set; }

        public SubtypeAlreadyRegisteredException(Type rootType, string tagValue, Type oldType, Type newType) : base(
            string.Format(
                "Subtype has already been registered for {0}[tag={1}]: oldType = {2}, newType = {3}",
                rootType.FullName,
                tagValue,
                oldType.FullName,
                newType.FullName
            )
        )
        {
            TagValue = tagValue;
            RootType = rootType;
            OldType = oldType;
            NewType = newType;
        }
    }

    public class NoRootException : Exception
    {
        public Type SubType { get; private set; }

        public NoRootException(Type subType) : base(
            string.Format(
                "{0} must be a descendant of the class with the [JsonConverter(typeof(JsonSubtypeConverter))] attribute",
                subType.FullName
            )
        )
        {
            SubType = subType;
        }
    }

    public class NoJsonSubtypeException : Exception
    {
        public Type SubType { get; private set; }

        public NoJsonSubtypeException(Type subType) : base(
            string.Format(
                @"{0} must have a [JsonSubtype(""..."")] attribute",
                subType.FullName
            )
        )
        {
            SubType = subType;
        }

    }

    public class JsonSubtypeNotRegisteredException : Exception
    {
        public Type Root { get; private set; }

        public string TagValue { get; private set; }

        public JsonSubtypeNotRegisteredException(Type root, string tagValue) : base(
            string.Format(
                @"Unknown tag={1} for class {0}",
                root.FullName,
                tagValue
            )
        )
        {
            Root = root;
            TagValue = tagValue;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class JsonSubtypeAttribute : Attribute
    {
        public JsonSubtypeAttribute(string tagValue)
        {
            TagValue = tagValue;
        }

        public string TagValue { get; }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class JsonDiscriminator : Attribute
    {
        public JsonDiscriminator(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }

    public static class JsonSubtypesExtension
    {
        private static readonly Dictionary<Type, PropertyInfo> DiscriminatorProperties = new Dictionary<Type, PropertyInfo>();

        public static bool TryGetAttribute<T>(this Type t, out T attribute) where T : Attribute
        {
            attribute = t.GetCustomAttributes(typeof(T), false).Cast<T>().FirstOrDefault();
            return attribute != null;
        }

        public static bool TryGetDiscriminatorProperty(this Type type, out PropertyInfo discriminatorProperty)
        {
            if (DiscriminatorProperties.TryGetValue(type, out discriminatorProperty))
            {
                return discriminatorProperty != null;
            }
            JsonConverterAttribute conv;
            if (type.TryGetAttribute(out conv) && conv.ConverterType == typeof(JsonSubtypeConverter))
            {
                JsonDiscriminator discriminator;
                if (type.TryGetAttribute(out discriminator))
                {
                    discriminatorProperty = type.GetProperty(discriminator.Value);
                }
            }
            DiscriminatorProperties[type] = discriminatorProperty;
            return discriminatorProperty != null;
        }

        public static bool TryGetRoot(this Type t, out Type root, out PropertyInfo tagProperty)
        {
            root = t;
            do
            {
                if (root.TryGetDiscriminatorProperty(out tagProperty))
                {
                    return true;
                }
                root = root.BaseType;
            } while (root != null);
            return false;
        }
    }

    public class DiscriminatorInfo
    {
        public PropertyInfo Property { get; set; }

        public string Value { get; set; }
    }

    public class RootInfo
    {
        public PropertyInfo Property { get; set; }

        public Type Root { get; set; }
    }

    public abstract class DefaultJsonConverter : JsonConverter
    {
        [ThreadStatic]
        private static bool _silentWrite;

        [ThreadStatic]
        private static bool _silentRead;

        public sealed override bool CanWrite
        {
            get
            {
                var canWrite = !_silentWrite;
                _silentWrite = false;
                return canWrite;
            }
        }

        public sealed override bool CanRead
        {
            get
            {
                var canRead = !_silentRead;
                _silentRead = false;
                return canRead;
            }
        }

        protected void _WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            _silentWrite = true;
            serializer.Serialize(writer, value);
        }

        protected object _ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            _silentRead = true;
            return serializer.Deserialize(reader, objectType);
        }
    }

    public class JsonSubtypeConverter : DefaultJsonConverter
    {
        private static readonly Dictionary<Type, Dictionary<string, Type>> Implementations = new Dictionary<Type, Dictionary<string, Type>>();

        private static readonly Dictionary<Type, DiscriminatorInfo> Discriminators = new Dictionary<Type, DiscriminatorInfo>();

        private static readonly Dictionary<Type, RootInfo> Roots = new Dictionary<Type, RootInfo>();

        public static void Register(Type newType)
        {
            Type root;
            PropertyInfo tagProperty;
            if (!newType.TryGetRoot(out root, out tagProperty))
            {
                throw new NoRootException(newType);
            }
            for (var t = newType; t != root; t = t.BaseType)
            {
                Roots[t] = new RootInfo()
                {
                    Property = tagProperty,
                    Root = root
                };
            }
            Roots[root] = new RootInfo()
            {
                Property = tagProperty,
                Root = root
            };
            Dictionary<string, Type> implementationMap;
            if (!Implementations.TryGetValue(root, out implementationMap))
            {
                implementationMap = new Dictionary<string, Type>();
                Implementations[root] = implementationMap;
            }
            JsonSubtypeAttribute attr;
            if (!newType.TryGetAttribute(out attr))
            {
                throw new NoJsonSubtypeException(newType);
            }
            var tagValue = attr.TagValue;
            Type oldType;
            if (implementationMap.TryGetValue(tagValue, out oldType) && oldType != newType)
            {
                throw new SubtypeAlreadyRegisteredException(root, tagValue, oldType, newType);
            }
            implementationMap[tagValue] = newType;
            Discriminators[newType] = new DiscriminatorInfo()
            {
                Property = tagProperty,
                Value = tagValue
            };
        }

        public override bool CanConvert(Type t)
        {
            return true;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            _WriteJson(writer, EnsureDiscriminatorValue(value), serializer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            while (true)
            {
                DiscriminatorInfo discriminatorInfo;
                if (Discriminators.TryGetValue(objectType, out discriminatorInfo))
                {
                    return _ReadJson(reader, objectType, existingValue, serializer);
                }
                else
                {
                    RootInfo rootInfo;
                    if (Roots.TryGetValue(objectType, out rootInfo))
                    {
                        var t = JToken.ReadFrom(reader);
                        var stub = _ReadJson(t.CreateReader(), rootInfo.Root, existingValue, serializer);
                        var tagValue = rootInfo.Property.GetValue(stub) as string;
                        var implementationMap = Implementations[rootInfo.Root];
                        Type implementation;
                        if (implementationMap.TryGetValue(tagValue, out implementation))
                        {
                            reader = t.CreateReader();
                            objectType = implementation;
                        }
                        else
                        {
                            throw new JsonSubtypeNotRegisteredException(rootInfo.Root, tagValue);
                        }
                    }
                    else
                    {
                        return _ReadJson(reader, objectType, existingValue, serializer);
                    }
                }
            }
        }

        private static T EnsureDiscriminatorValue<T>(T value)
        {
            DiscriminatorInfo discriminatorInfo;
            if (Discriminators.TryGetValue(value.GetType(), out discriminatorInfo))
            {
                discriminatorInfo.Property.SetValue(value, discriminatorInfo.Value);
            }
            return value;
        }
    }
}
