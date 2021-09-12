/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;

namespace Microsoft.Graph.PowerShell.Runtime
{
    public interface IHeaderSerializable
    {
        void ReadHeaders(System.Net.Http.Headers.HttpResponseHeaders headers);
    }
}