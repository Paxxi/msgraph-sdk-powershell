/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class XSet<T> : JsonArray, IEnumerable<JsonNode>
    {
        private readonly HashSet<T> values;
        private readonly JsonType elementType;
        private readonly TypeCode elementCode;

        public XSet(IEnumerable<T> values)
            : this(new HashSet<T>(values))
        { }

        public XSet(HashSet<T> values)
        {
            this.values = values ?? throw new ArgumentNullException(nameof(values));
            elementCode = System.Type.GetTypeCode(typeof(T));
            elementType = XHelper.GetElementType(elementCode);
        }

        public override JsonType Type => JsonType.Array;

        public override JsonType? ElementType => elementType;

        public bool IsReadOnly => true;

        public override int Count => values.Count;

        public override bool IsSet => true;

        #region IEnumerable Members

        IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator()
        {
            foreach (var value in values)
            {
                yield return XHelper.Create(elementType, elementCode, value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var value in values)
            {
                yield return XHelper.Create(elementType, elementCode, value);
            }
        }

        #endregion

        public HashSet<T> AsHashSet() => values;
    }
}