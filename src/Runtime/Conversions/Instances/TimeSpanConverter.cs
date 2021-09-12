/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override JsonNode ToJson(TimeSpan value) => new JsonString(value.ToString());

        public override TimeSpan FromJson(JsonNode node) => (TimeSpan)node;
    }
}