/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace Microsoft.Graph.PowerShell.Runtime.Json
{
    public struct SourceLocation
    {
        private int line;
        private int column;
        private int position;

        public SourceLocation(int line = 0, int column = 0, int position = 0)
        {
            this.line = line;
            this.column = column;
            this.position = position;
        }

        public int Line => line;

        public int Column => column;

        public int Position => position;

        public void Advance()
        {
            column++;
            position++;
        }

        public void MarkNewLine()
        {
            line++;
            column = 0;
        }

        public SourceLocation Clone()
        {
            return new SourceLocation(line, column, position);
        }
    }
}