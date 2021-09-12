namespace Microsoft.Graph.PowerShell.Security.Models
{
    public sealed class SecurityIdentity
    {

        /// <summary>key: id of alert</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of alert",
        SerializedName = @"alert-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string AlertId { get; set; }

        /// <summary>key: id of cloudAppSecurityProfile</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of cloudAppSecurityProfile",
        SerializedName = @"cloudAppSecurityProfile-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string CloudAppSecurityProfileId { get; set; }

        /// <summary>key: id of domainSecurityProfile</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of domainSecurityProfile",
        SerializedName = @"domainSecurityProfile-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string DomainSecurityProfileId { get; set; }

        /// <summary>key: id of fileSecurityProfile</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of fileSecurityProfile",
        SerializedName = @"fileSecurityProfile-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string FileSecurityProfileId { get; set; }

        /// <summary>key: id of hostSecurityProfile</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of hostSecurityProfile",
        SerializedName = @"hostSecurityProfile-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string HostSecurityProfileId { get; set; }

        /// <summary>key: id of ipSecurityProfile</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of ipSecurityProfile",
        SerializedName = @"ipSecurityProfileid",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string IPSecurityProfileId { get; set; }

        /// <summary>key: id of providerTenantSetting</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of providerTenantSetting",
        SerializedName = @"providerTenantSetting-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string ProviderTenantSettingId { get; set; }

        /// <summary>key: id of secureScoreControlProfile</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of secureScoreControlProfile",
        SerializedName = @"secureScoreControlProfile-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string SecureScoreControlProfileId { get; set; }

        /// <summary>key: id of secureScore</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of secureScore",
        SerializedName = @"secureScore-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string SecureScoreId { get; set; }

        /// <summary>key: id of securityAction</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of securityAction",
        SerializedName = @"securityAction-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string SecurityActionId { get; set; }

        /// <summary>key: id of tiIndicator</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of tiIndicator",
        SerializedName = @"tiIndicator-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string TiIndicatorId { get; set; }

        /// <summary>key: id of userSecurityProfile</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key: id of userSecurityProfile",
        SerializedName = @"userSecurityProfile-id",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string UserSecurityProfileId { get; set; }

        /// <summary>Creates an new <see cref="SecurityIdentity" /> instance.</summary>
        public SecurityIdentity()
        {

        }
    }
}