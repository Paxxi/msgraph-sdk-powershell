// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>listItemVersion</summary>
    public partial class MgListItemVersion
    {

        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgFieldValueSet _fields;

        /// <summary>fieldValueSet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgFieldValueSet Fields { get => (this._fields = this._fields ?? new Microsoft.Graph.PowerShell.Users.Models.MgFieldValueSet()); set => this._fields = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet LastModifiedBy { get; set; }

        /// <summary>Date and time the version was last modified. Read-only.</summary>
        public global::System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>publicationFacet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPublicationFacet Publication { get; set; }

    }
}