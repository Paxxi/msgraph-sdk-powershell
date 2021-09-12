/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public class PropertyTransformation
    {
        public PropertyTransformation(string name, Func<object, object> transformer)
        {
            Name        = name        ?? throw new ArgumentNullException(nameof(name));
            Transformer = transformer ?? throw new ArgumentNullException(nameof(transformer));
        }

        public string Name { get; }

        public Func<object, object> Transformer { get; }
    }
}