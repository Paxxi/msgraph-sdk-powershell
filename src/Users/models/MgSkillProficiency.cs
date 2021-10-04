// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>skillProficiency</summary>
    public partial class MgSkillProficiency
    {

        /// <summary>allowedAudiences</summary>
        public string AllowedAudiences { get; set; }

        /// <summary>Backing field for <see cref="Categories" /> property.</summary>
        private string[] _categories;

        /// <summary>
        /// Contains categories a user has associated with the skill (for example, personal, professional, hobby).
        /// </summary>
        public string[] Categories { get => this._categories; set => this._categories = value; }

        /// <summary>Backing field for <see cref="CollaborationTags" /> property.</summary>
        private string[] _collaborationTags;

        /// <summary>
        /// Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout,
        /// ableToMentor, wantsToLearn, wantsToImprove.
        /// </summary>
        public string[] CollaborationTags { get => this._collaborationTags; set => this._collaborationTags = value; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get; set; }

        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public global::System.DateTime? CreatedDateTime { get; set; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Contains a friendly name for the skill.</summary>
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

        /// <summary>Backing field for <see cref="Proficiency" /> property.</summary>
        private string _proficiency;

        /// <summary>skillProficiencyLevel</summary>
        public string Proficiency { get => this._proficiency; set => this._proficiency = value; }

        /// <summary>personDataSources</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPersonDataSources Source { get; set; }

        /// <summary>Backing field for <see cref="ThumbnailUrl" /> property.</summary>
        private string _thumbnailUrl;

        public string ThumbnailUrl { get => this._thumbnailUrl; set => this._thumbnailUrl = value; }

        /// <summary>Backing field for <see cref="WebUrl" /> property.</summary>
        private string _webUrl;

        /// <summary>Contains a link to an information source about the skill.</summary>
        public string WebUrl { get => this._webUrl; set => this._webUrl = value; }

    }
}