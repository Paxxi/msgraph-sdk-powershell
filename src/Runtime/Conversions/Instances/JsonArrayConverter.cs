/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class JsonArrayConverter : JsonConverter<JsonArray>
    {
        public override JsonNode ToJson(JsonArray value) => value;

        public override JsonArray FromJson(JsonNode node) => (JsonArray)node;
    }
}