/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;
using System.Linq;

namespace Microsoft.Graph.PowerShell.Runtime.PowerShell
{
    public static class StringExtensions
    {
        public static string NullIfEmpty(this string text) => string.IsNullOrEmpty(text) ? null : text;
        public static string NullIfWhiteSpace(this string text) => string.IsNullOrWhiteSpace(text) ? null : text;
        public static string EmptyIfNull(this string text) => text ?? string.Empty;

        public static bool? ToNullableBool(this string text) => string.IsNullOrEmpty(text) ? (bool?)null : Convert.ToBoolean(text.ToLowerInvariant());

        public static string ToUpperFirstCharacter(this string text) => string.IsNullOrEmpty(text) ? text : $"{text[0].ToString().ToUpperInvariant()}{text.Remove(0, 1)}";

        public static string ReplaceNewLines(this string value, string replacer = " ", string[] newLineSymbols = null)
            => (newLineSymbols ?? new []{ "\r\n", "\n" }).Aggregate(value.EmptyIfNull(), (current, symbol) => current.Replace(symbol, replacer));
        public static string NormalizeNewLines(this string value) => value.ReplaceNewLines("\u00A0").Replace("\u00A0", Environment.NewLine);
    }
}
