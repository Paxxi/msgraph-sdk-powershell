// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>sectionLinks</summary>
    public partial class MgSectionLinks
    {

        /// <summary>Backing field for <see cref="OneNoteClientUrl" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgExternalLink _oneNoteClientUrl;

        /// <summary>externalLink</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgExternalLink OneNoteClientUrl { get => (this._oneNoteClientUrl = this._oneNoteClientUrl ?? new Microsoft.Graph.PowerShell.Users.Models.MgExternalLink()); set => this._oneNoteClientUrl = value; }

        /// <summary>Backing field for <see cref="OneNoteWebUrl" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgExternalLink _oneNoteWebUrl;

        /// <summary>externalLink</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgExternalLink OneNoteWebUrl { get => (this._oneNoteWebUrl = this._oneNoteWebUrl ?? new Microsoft.Graph.PowerShell.Users.Models.MgExternalLink()); set => this._oneNoteWebUrl = value; }

    }
}