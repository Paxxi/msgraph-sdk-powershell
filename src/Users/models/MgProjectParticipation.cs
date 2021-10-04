// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>projectParticipation</summary>
    public partial class MgProjectParticipation
    {

        /// <summary>allowedAudiences</summary>
        public string AllowedAudiences { get; set; }

        /// <summary>Backing field for <see cref="Categories" /> property.</summary>
        private string[] _categories;

        /// <summary>
        /// Contains categories a user has associated with the project (for example, digital transformation, oil rig).
        /// </summary>
        public string[] Categories { get => this._categories; set => this._categories = value; }

        /// <summary>Backing field for <see cref="Client" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgCompanyDetail _client;

        /// <summary>companyDetail</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgCompanyDetail Client { get => (this._client = this._client ?? new Microsoft.Graph.PowerShell.Users.Models.MgCompanyDetail()); set => this._client = value; }

        /// <summary>Backing field for <see cref="CollaborationTags" /> property.</summary>
        private string[] _collaborationTags;

        /// <summary>
        /// Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout,
        /// ableToMentor, wantsToLearn, wantsToImprove.
        /// </summary>
        public string[] CollaborationTags { get => this._collaborationTags; set => this._collaborationTags = value; }

        /// <summary>Backing field for <see cref="Colleagues" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgRelatedPerson[] _colleagues;

        /// <summary>Lists people that also worked on the project.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgRelatedPerson[] Colleagues { get => this._colleagues; set => this._colleagues = value; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get; set; }

        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public global::System.DateTime? CreatedDateTime { get; set; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPositionDetail _detail;

        /// <summary>positionDetail</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPositionDetail Detail { get => (this._detail = this._detail ?? new Microsoft.Graph.PowerShell.Users.Models.MgPositionDetail()); set => this._detail = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Contains a friendly name for the project.</summary>
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

        /// <summary>Backing field for <see cref="Sponsors" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgRelatedPerson[] _sponsors;

        /// <summary>The Person or people who sponsored the project.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgRelatedPerson[] Sponsors { get => this._sponsors; set => this._sponsors = value; }

        /// <summary>Backing field for <see cref="ThumbnailUrl" /> property.</summary>
        private string _thumbnailUrl;

        public string ThumbnailUrl { get => this._thumbnailUrl; set => this._thumbnailUrl = value; }

    }
}