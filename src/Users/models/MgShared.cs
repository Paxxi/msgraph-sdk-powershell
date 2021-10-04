// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>shared</summary>
    public partial class MgShared
    {

        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet _owner;

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet Owner { get => (this._owner = this._owner ?? new Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet()); set => this._owner = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>
        /// Indicates the scope of how the item is shared: anonymous, organization, or users. Read-only.
        /// </summary>
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Backing field for <see cref="SharedBy" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet _sharedBy;

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet SharedBy { get => (this._sharedBy = this._sharedBy ?? new Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet()); set => this._sharedBy = value; }

        /// <summary>Backing field for <see cref="SharedDateTime" /> property.</summary>
        private global::System.DateTime? _sharedDateTime;

        /// <summary>The UTC date and time when the item was shared. Read-only.</summary>
        public global::System.DateTime? SharedDateTime { get => this._sharedDateTime; set => this._sharedDateTime = value; }

    }
}