namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>userSecurityProfile</summary>
    public partial class MicrosoftGraphUserSecurityProfile
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "MicrosoftGraphEntity" />
        /// </summary>
        private MicrosoftGraphEntity __microsoftGraphEntity = new MicrosoftGraphEntity();

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"accounts",
        PossibleTypes = new [] { typeof(MicrosoftGraphUserAccount) })]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphUserAccount[] Accounts { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"azureSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string AzureSubscriptionId { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"azureTenantId",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string AzureTenantId { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"createdDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? CreatedDateTime { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string DisplayName { get; set; }

        /// <summary>Read-only.</summary>
        [Origin(PropertyOrigin.Inherited)]
        public string Id { get => __microsoftGraphEntity.Id; set => __microsoftGraphEntity.Id = value; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastModifiedDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"riskScore",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string RiskScore { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string[] Tags { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userPrincipalName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string UserPrincipalName { get; set; }

        /// <summary>Backing field for <see cref="VendorInformation" /> property.</summary>
        private MgSecurityVendorInformation _vendorInformation;

        /// <summary>securityVendorInformation</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"securityVendorInformation",
        SerializedName = @"vendorInformation",
        PossibleTypes = new [] { typeof(MgSecurityVendorInformation) })]
        [Origin(PropertyOrigin.Owned)]
        public MgSecurityVendorInformation VendorInformation { get => (this._vendorInformation = this._vendorInformation ?? new MgSecurityVendorInformation()); set => this._vendorInformation = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphUserSecurityProfile" /> instance.</summary>
        public MicrosoftGraphUserSecurityProfile()
        {

        }
    }
}