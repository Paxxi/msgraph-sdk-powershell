/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override JsonNode ToJson(DateTimeOffset value) => new JsonDate(value);

        public override DateTimeOffset FromJson(JsonNode node) => (DateTimeOffset)node;
    }
}