/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class BooleanConverter : JsonConverter<bool>
    {
        public override JsonNode ToJson(bool value) => new JsonBoolean(value);

        public override bool FromJson(JsonNode node) => (bool)node;
    }
}