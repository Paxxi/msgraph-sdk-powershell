// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>teamsTabConfiguration</summary>
    public partial class MgTeamsTabConfiguration
    {

        /// <summary>Backing field for <see cref="ContentUrl" /> property.</summary>
        private string _contentUrl;

        /// <summary>Url used for rendering tab contents in Teams. Required.</summary>
        public string ContentUrl { get => this._contentUrl; set => this._contentUrl = value; }

        /// <summary>Backing field for <see cref="EntityId" /> property.</summary>
        private string _entityId;

        /// <summary>Identifier for the entity hosted by the tab provider.</summary>
        public string EntityId { get => this._entityId; set => this._entityId = value; }

        /// <summary>Backing field for <see cref="RemoveUrl" /> property.</summary>
        private string _removeUrl;

        /// <summary>Url called by Teams client when a Tab is removed using the Teams Client.</summary>
        public string RemoveUrl { get => this._removeUrl; set => this._removeUrl = value; }

        /// <summary>Backing field for <see cref="WebsiteUrl" /> property.</summary>
        private string _websiteUrl;

        /// <summary>Url for showing tab contents outside of Teams.</summary>
        public string WebsiteUrl { get => this._websiteUrl; set => this._websiteUrl = value; }

    }
}