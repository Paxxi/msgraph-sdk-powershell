// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>messageSecurityState</summary>
    public class MicrosoftGraphMessageSecurityState
    {
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"connectingIP",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string ConnectingIP { get; set; }

        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"deliveryAction",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string DeliveryAction { get; set; }

        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"deliveryLocation",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string DeliveryLocation { get; set; }

        [Origin(PropertyOrigin.Owned)]
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"directionality",
            PossibleTypes = new[] {typeof(string)})]
        public string Directionality { get; set; }

        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"internetMessageId",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string InternetMessageId { get; set; }

        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"messageFingerprint",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string MessageFingerprint { get; set; }

        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"messageReceivedDateTime",
            PossibleTypes = new[] {typeof(DateTime)})]
        [Origin(PropertyOrigin.Owned)]
        public DateTime? MessageReceivedDateTime { get; set; }

        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"messageSubject",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string MessageSubject { get; set; }

        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"networkMessageId",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkMessageId { get; set; }
    }
}