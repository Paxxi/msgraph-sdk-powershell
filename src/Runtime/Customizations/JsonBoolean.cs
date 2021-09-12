/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public partial class JsonBoolean
    {
        public static JsonBoolean Create(bool? value) => value is bool b ? new JsonBoolean(b) : null;
        public bool ToBoolean() => Value;

        public override object ToValue() => Value;
    }


}