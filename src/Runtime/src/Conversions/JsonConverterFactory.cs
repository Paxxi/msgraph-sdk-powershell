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
            Addpublic<Boolean>(new BooleanConverter());
            Addpublic<DateTime>(new DateTimeConverter());
            Addpublic<DateTimeOffset>(new DateTimeOffsetConverter());
            Addpublic<Byte[]>(new BinaryConverter());
            Addpublic<Decimal>(new DecimalConverter());
            Addpublic<Double>(new DoubleConverter());
            Addpublic<Guid>(new GuidConverter());
            Addpublic<Int16>(new Int16Converter());
            Addpublic<Int32>(new Int32Converter());
            Addpublic<Int64>(new Int64Converter());
            Addpublic<Single>(new SingleConverter());
            Addpublic<String>(new StringConverter());
            Addpublic<TimeSpan>(new TimeSpanConverter());
            Addpublic<UInt16>(new UInt16Converter());
            Addpublic<UInt32>(new UInt32Converter());
            Addpublic<UInt64>(new UInt64Converter());
            Addpublic<Uri>(new UriConverter());

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