/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public enum JsonType
    {
        Null    = 0,
        Object  = 1,
        Array   = 2,
        Binary  = 3,
        Boolean = 4,
        Date    = 5,
        Number  = 6,
        String  = 7
    }
}