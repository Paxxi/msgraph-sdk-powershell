using System;

namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>secureScore</summary>
    public class MgSecureScore
    {
        private MgSecurityVendorInformation _vendorInformation;

        /// <summary>Active user count of the given tenant.</summary>
        [Origin(PropertyOrigin.Owned)]
        public int? ActiveUserCount { get; set; }

        /// <summary>
        ///     Average score by different scopes (for example, average by industry, average by seating) and control category
        ///     (Identity,
        ///     Data, Device, Apps, Infrastructure) within the scope.
        /// </summary>
        [Origin(PropertyOrigin.Owned)]
        public MgAverageComparativeScore[] AverageComparativeScores { get; set; }

        /// <summary>GUID string for tenant ID.</summary>
        [Origin(PropertyOrigin.Owned)]
        public string AzureTenantId { get; set; }

        /// <summary>Contains tenant scores for a set of controls.</summary>
        [Origin(PropertyOrigin.Owned)]
        public MgControlScore[] ControlScores { get; set; }

        /// <summary>The date when the entity is created.</summary>
        [Origin(PropertyOrigin.Owned)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>Tenant current attained score on specified date.</summary>
        [Origin(PropertyOrigin.Owned)]
        public double? CurrentScore { get; set; }

        /// <summary>
        ///     Microsoft-provided services for the tenant (for example, Exchange online, Skype, Sharepoint).
        /// </summary>
        [Origin(PropertyOrigin.Owned)]
        public string[] EnabledServices { get; set; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Licensed user count of the given tenant.</summary>
        [Origin(PropertyOrigin.Owned)]
        public int? LicensedUserCount { get; set; }

        /// <summary>Tenant maximum possible score on specified date.</summary>
        [Origin(PropertyOrigin.Owned)]
        public double? MaxScore { get; set; }

        /// <summary>securityVendorInformation</summary>
        [Origin(PropertyOrigin.Owned)]
        public MgSecurityVendorInformation VendorInformation
        {
            get => _vendorInformation = _vendorInformation ?? new MgSecurityVendorInformation();
            set => _vendorInformation = value;
        }
    }
}