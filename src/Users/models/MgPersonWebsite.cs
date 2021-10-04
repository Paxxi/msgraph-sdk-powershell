// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>personWebsite</summary>
    public partial class MgPersonWebsite
    {

        /// <summary>allowedAudiences</summary>
        public string AllowedAudiences { get; set; }

        /// <summary>Backing field for <see cref="Categories" /> property.</summary>
        private string[] _categories;

        /// <summary>
        /// Contains categories a user has associated with the website (for example, personal, recipes).
        /// </summary>
        public string[] Categories { get => this._categories; set => this._categories = value; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get; set; }

        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public global::System.DateTime? CreatedDateTime { get; set; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Contains a description of the website.</summary>
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Contains a friendly name for the website.</summary>
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>inferenceData</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgInferenceData Inference { get; set; }

        public bool? IsSearchable { get; set; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet LastModifiedBy { get; set; }

        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public global::System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>personDataSources</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPersonDataSources Source { get; set; }

        /// <summary>Backing field for <see cref="ThumbnailUrl" /> property.</summary>
        private string _thumbnailUrl;

        public string ThumbnailUrl { get => this._thumbnailUrl; set => this._thumbnailUrl = value; }

        /// <summary>Backing field for <see cref="WebUrl" /> property.</summary>
        private string _webUrl;

        /// <summary>Contains a link to the website itself.</summary>
        public string WebUrl { get => this._webUrl; set => this._webUrl = value; }

    }
}