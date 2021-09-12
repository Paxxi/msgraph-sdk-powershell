namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>userSecurityState</summary>
    public sealed class MicrosoftGraphUserSecurityState
    {
        /// <summary>
        /// AAD User object identifier (GUID) - represents the physical/multi-account user entity.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"AAD User object identifier (GUID) - represents the physical/multi-account user entity.",
        SerializedName = @"aadUserId",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string AadUserId { get; set; }

        /// <summary>
        /// Account name of user account (without Active Directory domain or DNS domain) - (also called mailNickName).
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Account name of user account (without Active Directory domain or DNS domain) - (also called mailNickName).",
        SerializedName = @"accountName",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string AccountName { get; set; }

        /// <summary>
        /// NetBIOS/Active Directory domain of user account (that is, domain/account format).
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"NetBIOS/Active Directory domain of user account (that is, domain/account format).",
        SerializedName = @"domainName",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string DomainName { get; set; }

        /// <summary>emailRole</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"emailRole",
        SerializedName = @"emailRole",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailRole { get; set; }

        /// <summary>Indicates whether the user logged on through a VPN.</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the user logged on through a VPN.",
        SerializedName = @"isVpn",
        PossibleTypes = new[] { typeof(bool) })]
        [Origin(PropertyOrigin.Owned)]
        public bool? IsVpn { get; set; }

        /// <summary>
        /// Time at which the sign-in occurred. The Timestamp type represents date and time information using ISO 8601 format and
        /// is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time at which the sign-in occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.",
        SerializedName = @"logonDateTime",
        PossibleTypes = new[] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? LogonDateTime { get; set; }

        /// <summary>IP Address the sign-in request originated from.</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP Address the sign-in request originated from.",
        SerializedName = @"logonIp",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string LogonIP { get; set; }

        /// <summary>User sign-in ID.</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User sign-in ID.",
        SerializedName = @"logonId",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string LogonId { get; set; }

        /// <summary>
        /// Location (by IP address mapping) associated with a user sign-in event by this user.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location (by IP address mapping) associated with a user sign-in event by this user.",
        SerializedName = @"logonLocation",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string LogonLocation { get; set; }

        /// <summary>logonType</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"logonType",
        SerializedName = @"logonType",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string LogonType { get; set; }

        /// <summary>Active Directory (on-premises) Security Identifier (SID) of the user.</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Active Directory (on-premises) Security Identifier (SID) of the user.",
        SerializedName = @"onPremisesSecurityIdentifier",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string OnPremisesSecurityIdentifier { get; set; }

        /// <summary>
        /// Provider-generated/calculated risk score of the user account. Recommended value range of 0-1, which equates to a percentage.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider-generated/calculated risk score of the user account. Recommended value range of 0-1, which equates to a percentage.",
        SerializedName = @"riskScore",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string RiskScore { get; set; }

        /// <summary>userAccountSecurityType</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"userAccountSecurityType",
        SerializedName = @"userAccountType",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string UserAccountType { get; set; }

        /// <summary>
        /// User sign-in name - internet format: (user account name)@(user account DNS domain name).
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User sign-in name - internet format: (user account name)@(user account DNS domain name).",
        SerializedName = @"userPrincipalName",
        PossibleTypes = new[] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string UserPrincipalName { get; set; }

        /// <summary>Creates an new <see cref="MicrosoftGraphUserSecurityState" /> instance.</summary>
        public MicrosoftGraphUserSecurityState()
        {

        }
    }
}