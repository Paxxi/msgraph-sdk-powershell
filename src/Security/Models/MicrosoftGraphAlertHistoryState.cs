// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>alertHistoryState</summary>
    public sealed class MicrosoftGraphAlertHistoryState
    {
        /// <summary>
        ///     The Application ID of the calling application that submitted an update (PATCH) to the alert. The appId should be
        ///     extracted
        ///     from the auth token and not entered manually by the calling application.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"The Application ID of the calling application that submitted an update (PATCH) to the alert. The appId should be extracted from the auth token and not entered manually by the calling application.",
            SerializedName = @"appId",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string AppId { get; set; }

        /// <summary>
        ///     UPN of user the alert was assigned to (note: alert.assignedTo only stores the last value/UPN).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"UPN of user the alert was assigned to (note: alert.assignedTo only stores the last value/UPN).",
            SerializedName = @"assignedTo",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string AssignedTo { get; set; }

        /// <summary>Comment entered by signed-in user.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Comment entered by signed-in user.",
            SerializedName = @"comments",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string[] Comments { get; set; }

        /// <summary>alertFeedback</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"alertFeedback",
            SerializedName = @"feedback",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Feedback { get; set; }

        /// <summary>alertStatus</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"alertStatus",
            SerializedName = @"status",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Status { get; set; }

        /// <summary>
        ///     Date and time of the alert update. The Timestamp type represents date and time information using ISO 8601 format
        ///     and is
        ///     always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Date and time of the alert update. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
            SerializedName = @"updatedDateTime",
            PossibleTypes = new[] {typeof(DateTime)})]
        [Origin(PropertyOrigin.Owned)]
        public DateTime? UpdatedDateTime { get; set; }

        /// <summary>
        ///     UPN of the signed-in user that updated the alert (taken from the bearer token - if in user/delegated auth mode).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"UPN of the signed-in user that updated the alert (taken from the bearer token - if in user/delegated auth mode).",
            SerializedName = @"user",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string User { get; set; }
    }
}