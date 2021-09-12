/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class UInt16Converter : JsonConverter<ushort>
    {
        public override JsonNode ToJson(ushort value) => new JsonNumber(value);

        public override ushort FromJson(JsonNode node) => (ushort)node;
    }
}