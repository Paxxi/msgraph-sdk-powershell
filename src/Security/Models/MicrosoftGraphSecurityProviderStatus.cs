// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>securityProviderStatus</summary>
    public class MicrosoftGraphSecurityProviderStatus
    {
        [Origin(PropertyOrigin.Owned)] public bool? Enabled { get; set; }

        [Origin(PropertyOrigin.Owned)] public string Endpoint { get; set; }

        [Origin(PropertyOrigin.Owned)] public string Provider { get; set; }

        [Origin(PropertyOrigin.Owned)] public string Region { get; set; }

        [Origin(PropertyOrigin.Owned)] public string Vendor { get; set; }
    }
}