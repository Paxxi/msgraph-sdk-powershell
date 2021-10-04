// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>userAccountInformation</summary>
    public partial class MgUserAccountInformation
    {

        /// <summary>Backing field for <see cref="AgeGroup" /> property.</summary>
        private string _ageGroup;

        /// <summary>
        /// Shows the age group of user. Allowed values null, minor, notAdult and adult are generated by the directory and cannot
        /// be changed.
        /// </summary>
        public string AgeGroup { get => this._ageGroup; set => this._ageGroup = value; }

        /// <summary>allowedAudiences</summary>
        public string AllowedAudiences { get; set; }

        /// <summary>Backing field for <see cref="CountryCode" /> property.</summary>
        private string _countryCode;

        /// <summary>Contains the two-character country code associated with the users account.</summary>
        public string CountryCode { get => this._countryCode; set => this._countryCode = value; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get; set; }

        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public global::System.DateTime? CreatedDateTime { get; set; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>inferenceData</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgInferenceData Inference { get; set; }

        public bool? IsSearchable { get; set; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet LastModifiedBy { get; set; }

        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public global::System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>Backing field for <see cref="PreferredLanguageTag" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgLocaleInfo _preferredLanguageTag;

        /// <summary>localeInfo</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgLocaleInfo PreferredLanguageTag { get => (this._preferredLanguageTag = this._preferredLanguageTag ?? new Microsoft.Graph.PowerShell.Users.Models.MgLocaleInfo()); set => this._preferredLanguageTag = value; }

        /// <summary>personDataSources</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPersonDataSources Source { get; set; }

        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>The user principal name (UPN) of the user associated with the account.</summary>
        public string UserPrincipalName { get => this._userPrincipalName; set => this._userPrincipalName = value; }

    }
}