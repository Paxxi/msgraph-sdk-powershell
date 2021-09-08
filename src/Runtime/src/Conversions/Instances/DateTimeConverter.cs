/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿using System;

namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public sealed class DateTimeConverter : JsonConverter<DateTime>
    {
        public override JsonNode ToJson(DateTime value)
        {
            return new JsonDate(value);
        }

        public override DateTime FromJson(JsonNode node) => (DateTime)node;
    }
}