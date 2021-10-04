// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>termColumn</summary>
    public partial class MgTermColumn
    {

        /// <summary>Backing field for <see cref="AllowMultipleValues" /> property.</summary>
        private bool? _allowMultipleValues;

        /// <summary>Specifies whether the column will allow more than one value</summary>
        public bool? AllowMultipleValues { get => this._allowMultipleValues; set => this._allowMultipleValues = value; }

        /// <summary>Backing field for <see cref="ShowFullyQualifiedName" /> property.</summary>
        private bool? _showFullyQualifiedName;

        /// <summary>Specifies whether to display the entire term path or only the term label.</summary>
        public bool? ShowFullyQualifiedName { get => this._showFullyQualifiedName; set => this._showFullyQualifiedName = value; }

    }
}