/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public class ParserException : Exception
    {
        public ParserException(string message)
            : base(message)
        { }

        public ParserException(string message, SourceLocation location)
            : base(message)
        {

            Location = location;
        }

        public SourceLocation Location { get; }
    }
}