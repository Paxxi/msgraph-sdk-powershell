namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>uriClickSecurityState</summary>
    public sealed class MicrosoftGraphUriClickSecurityState
    {
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clickAction",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string ClickAction { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clickDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? ClickDateTime { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string Id { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sourceId",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string SourceId { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"uriDomain",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string UriDomain { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"verdict",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string Verdict { get; set; }

        /// <summary>Creates an new <see cref="MicrosoftGraphUriClickSecurityState" /> instance.</summary>
        public MicrosoftGraphUriClickSecurityState()
        {

        }
    }
}