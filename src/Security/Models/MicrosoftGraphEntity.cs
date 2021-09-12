using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>entity</summary>
    public sealed class MicrosoftGraphEntity
    {
        /// <summary>Read-only.</summary>
        /// <summary>Read-only.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Read-only.",
            SerializedName = @"id",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Id { get; set; }
    }
}