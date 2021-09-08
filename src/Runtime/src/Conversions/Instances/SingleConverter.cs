/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class SingleConverter : JsonConverter<float>
    {
        public override JsonNode ToJson(float value) => new JsonNumber(value.ToString());

        public override float FromJson(JsonNode node) => (float)node;
    }
}