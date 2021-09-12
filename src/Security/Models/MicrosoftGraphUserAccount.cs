namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>userAccount</summary>
    public partial class MicrosoftGraphUserAccount
    {
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string DisplayName { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastSeenDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? LastSeenDateTime { get; set; }

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
        SerializedName = @"service",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string Service { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"signinName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string SigninName { get; set; }

        /// <summary>accountStatus</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"accountStatus",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string Status { get; set; }

        /// <summary>Creates an new <see cref="MicrosoftGraphUserAccount" /> instance.</summary>
        public MicrosoftGraphUserAccount()
        {

        }
    }
}