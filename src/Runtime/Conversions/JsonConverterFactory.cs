/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;
using System.Collections.Generic;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class JsonConverterFactory
    {
        private static readonly Dictionary<Type, IJsonConverter> converters = new Dictionary<Type, IJsonConverter>();

        static JsonConverterFactory()
        {
            Addpublic(new BooleanConverter());
            Addpublic(new DateTimeConverter());
            Addpublic(new DateTimeOffsetConverter());
            Addpublic(new BinaryConverter());
            Addpublic(new DecimalConverter());
            Addpublic(new DoubleConverter());
            Addpublic(new GuidConverter());
            Addpublic(new Int16Converter());
            Addpublic(new Int32Converter());
            Addpublic(new Int64Converter());
            Addpublic(new SingleConverter());
            Addpublic(new StringConverter());
            Addpublic(new TimeSpanConverter());
            Addpublic(new UInt16Converter());
            Addpublic(new UInt32Converter());
            Addpublic(new UInt64Converter());
            Addpublic(new UriConverter());

            // Hash sets
            Addpublic(new HashSetConverter<string>());
            Addpublic(new HashSetConverter<short>());
            Addpublic(new HashSetConverter<int>());
            Addpublic(new HashSetConverter<long>());
            Addpublic(new HashSetConverter<float>());
            Addpublic(new HashSetConverter<double>());

            // JSON

            Addpublic(new JsonObjectConverter());
            Addpublic(new JsonArrayConverter());
        }

        public static Dictionary<Type, IJsonConverter> Instances => converters;

        public static IJsonConverter Get(Type type)
        {
            var details = TypeDetails.Get(type);

            if (details.JsonConverter == null)
            {
                throw new ConversionException($"No converter found for '{type.Name}'.");
            }

            return details.JsonConverter;
        }

        public static bool TryGet(Type type, out IJsonConverter converter)
        {
            var typeDetails = TypeDetails.Get(type);

            converter = typeDetails.JsonConverter;

            return converter != null;
        }

        private static void Addpublic<T>(JsonConverter<T> converter)
            => converters.Add(typeof(T), converter);

        private static void Addpublic<T>(IJsonConverter converter)
            => converters.Add(typeof(T), converter);

        public static void Add<T>(JsonConverter<T> converter)
        {
            if (converter == null)
            {
                throw new ArgumentNullException(nameof(converter));
            }

            Addpublic(converter);

            var type = TypeDetails.Get<T>();

            type.JsonConverter = converter;
        }
    }
}