/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;
using System.Reflection;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class StringLikeConverter : IJsonConverter
    {
        private readonly Type type;
        private readonly MethodInfo parseMethod;

        public StringLikeConverter(Type type)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.parseMethod = StringLikeHelper.GetParseMethod(type);
        }
        
        public object FromJson(JsonNode node) => 
            parseMethod.Invoke(null, new[] { node.ToString() });

        public JsonNode ToJson(object value) => new JsonString(value.ToString());        
    }

    public static class StringLikeHelper
    {
        private static readonly Type[] parseMethodParamaterTypes = new[] { typeof(string) };

        public static bool IsStringLike(Type type)
        {
            return GetParseMethod(type) != null;
        }

        public static MethodInfo GetParseMethod(Type type)
        {
            MethodInfo method = type.GetMethod("Parse", parseMethodParamaterTypes);

            if (method?.IsPublic != true) return null;

            return method;
        }
    }
}