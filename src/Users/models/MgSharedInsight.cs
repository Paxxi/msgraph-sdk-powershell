// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>sharedInsight</summary>
    public partial class MgSharedInsight
    {

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="LastShared" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgSharingDetail _lastShared;

        /// <summary>sharingDetail</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgSharingDetail LastShared { get => (this._lastShared = this._lastShared ?? new Microsoft.Graph.PowerShell.Users.Models.MgSharingDetail()); set => this._lastShared = value; }

        /// <summary>Backing field for <see cref="LastSharedMethod" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgEntity _lastSharedMethod;

        /// <summary>entity</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgEntity LastSharedMethod { get => (this._lastSharedMethod = this._lastSharedMethod ?? new Microsoft.Graph.PowerShell.Users.Models.MgEntity()); set => this._lastSharedMethod = value; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgEntity _resource;

        /// <summary>entity</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgEntity Resource { get => (this._resource = this._resource ?? new Microsoft.Graph.PowerShell.Users.Models.MgEntity()); set => this._resource = value; }

        /// <summary>Backing field for <see cref="ResourceReference" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgResourceReference _resourceReference;

        /// <summary>resourceReference</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgResourceReference ResourceReference { get => (this._resourceReference = this._resourceReference ?? new Microsoft.Graph.PowerShell.Users.Models.MgResourceReference()); set => this._resourceReference = value; }

        /// <summary>Backing field for <see cref="ResourceVisualization" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgResourceVisualization _resourceVisualization;

        /// <summary>resourceVisualization</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgResourceVisualization ResourceVisualization { get => (this._resourceVisualization = this._resourceVisualization ?? new Microsoft.Graph.PowerShell.Users.Models.MgResourceVisualization()); set => this._resourceVisualization = value; }

        /// <summary>Backing field for <see cref="SharingHistory" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgSharingDetail[] _sharingHistory;

        public Microsoft.Graph.PowerShell.Users.Models.MgSharingDetail[] SharingHistory { get => this._sharingHistory; set => this._sharingHistory = value; }

    }
}