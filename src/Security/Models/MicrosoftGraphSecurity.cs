// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>security</summary>
    public class MicrosoftGraphSecurity
    {
        private readonly MicrosoftGraphEntity __microsoftGraphEntity = new MicrosoftGraphEntity();

        /// <summary>Read-only. Nullable.</summary>
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphAlert[] Alerts { get; set; }

        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphCloudAppSecurityProfile[] CloudAppSecurityProfiles { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphDomainSecurityProfile[] DomainSecurityProfiles { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphFileSecurityProfile[] FileSecurityProfiles { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphHostSecurityProfile[] HostSecurityProfiles { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphIPSecurityProfile[] IPSecurityProfiles { get; set; }

        /// <summary>Read-only.</summary>
        [Origin(PropertyOrigin.Inherited)]
        public string Id
        {
            get => __microsoftGraphEntity.Id;
            set => __microsoftGraphEntity.Id = value;
        }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphSecurityProviderStatus[] ProviderStatus { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphProviderTenantSetting[] ProviderTenantSettings { get; set; }

        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphSecureScoreControlProfile[] SecureScoreControlProfiles { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphSecureScore[] SecureScores { get; set; }

        [Origin(PropertyOrigin.Owned)] public Action[] SecurityActions { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphTiIndicator[] TiIndicators { get; set; }

        [Origin(PropertyOrigin.Owned)] public MicrosoftGraphUserSecurityProfile[] UserSecurityProfiles { get; set; }
    }
}