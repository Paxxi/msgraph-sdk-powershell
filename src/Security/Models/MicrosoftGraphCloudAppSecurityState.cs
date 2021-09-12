// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>cloudAppSecurityState</summary>
    public class MicrosoftGraphCloudAppSecurityState
    {
        /// <summary>Destination IP Address of the connection to the cloud application/service.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Destination IP Address of the connection to the cloud application/service.",
            SerializedName = @"destinationServiceIp",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string DestinationServiceIP { get; set; }

        /// <summary>Cloud application/service name (for example 'Salesforce', 'DropBox', etc.).</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Cloud application/service name (for example 'Salesforce', 'DropBox', etc.).",
            SerializedName = @"destinationServiceName",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string DestinationServiceName { get; set; }

        /// <summary>
        ///     Provider-generated/calculated risk score of the Cloud Application/Service. Recommended value range of 0-1, which
        ///     equates
        ///     to a percentage.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Provider-generated/calculated risk score of the Cloud Application/Service. Recommended value range of 0-1, which equates to a percentage.",
            SerializedName = @"riskScore",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string RiskScore { get; set; }
    }
}