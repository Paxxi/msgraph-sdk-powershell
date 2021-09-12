// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell.Security.Models
{

    /// <summary>alert</summary>
    public class MicrosoftGraphAlert
    {
        /// <summary>
        ///     Backing field for Inherited model <see cref="MicrosoftGraphEntity" />
        /// </summary>
        private MicrosoftGraphEntity _microsoftGraphEntity = new MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="Triggers" /> property.</summary>
        private MicrosoftGraphAlertTrigger[] _triggers;

        private MicrosoftGraphSecurityVendorInformation _vendorInformation;

        /// <summary>Name or alias of the activity group (attacker) this alert is attributed to.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Name or alias of the activity group (attacker) this alert is attributed to.",
            SerializedName = @"activityGroupName",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string ActivityGroupName { get; set; }

        /// <summary>Backing field for <see cref="AlertDetections" /> property.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"alertDetections",
            PossibleTypes = new[] {typeof(MicrosoftGraphAlertDetection)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphAlertDetection[] AlertDetections { get; set; }

        /// <summary>
        ///     Name of the analyst the alert is assigned to for triage, investigation, or remediation (supports update).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Name of the analyst the alert is assigned to for triage, investigation, or remediation (supports update).",
            SerializedName = @"assignedTo",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string AssignedTo { get; set; }

        /// <summary>Azure subscription ID, present if this alert is related to an Azure resource.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Azure subscription ID, present if this alert is related to an Azure resource.",
            SerializedName = @"azureSubscriptionId",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string AzureSubscriptionId { get; set; }

        /// <summary>Azure Active Directory tenant ID. Required.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Azure Active Directory tenant ID. Required.",
            SerializedName = @"azureTenantId",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string AzureTenantId { get; set; }

        /// <summary>Category of the alert (for example, credentialTheft, ransomware, etc.).</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Category of the alert (for example, credentialTheft, ransomware, etc.).",
            SerializedName = @"category",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Category { get; set; }

        /// <summary>
        ///     Time at which the alert was closed. The Timestamp type represents date and time information using ISO 8601 format
        ///     and
        ///     is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z (supports update).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Time at which the alert was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z (supports update).",
            SerializedName = @"closedDateTime",
            PossibleTypes = new[] {typeof(DateTime)})]
        [Origin(PropertyOrigin.Owned)]
        public DateTime? ClosedDateTime { get; set; }

        /// <summary>
        ///     Security-related stateful information generated by the provider about the cloud application/s related to this
        ///     alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related stateful information generated by the provider about the cloud application/s related to this alert.",
            SerializedName = @"cloudAppStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphCloudAppSecurityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphCloudAppSecurityState[] CloudAppStates { get; set; }

        /// <summary>
        ///     Customer-provided comments on alert (for customer alert management) (supports update).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Customer-provided comments on alert (for customer alert management) (supports update).",
            SerializedName = @"comments",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string[] Comments { get; set; }

        /// <summary>Confidence of the detection logic (percentage between 1-100).</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Confidence of the detection logic (percentage between 1-100).",
            SerializedName = @"confidence",
            PossibleTypes = new[] {typeof(int)})]
        [Origin(PropertyOrigin.Owned)]
        public int? Confidence { get; set; }

        /// <summary>
        ///     Time at which the alert was created by the alert provider. The Timestamp type represents date and time information
        ///     using
        ///     ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        ///     Required.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Time at which the alert was created by the alert provider. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.",
            SerializedName = @"createdDateTime",
            PossibleTypes = new[] {typeof(DateTime)})]
        [Origin(PropertyOrigin.Owned)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>Alert description.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Alert description.",
            SerializedName = @"description",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Description { get; set; }

        /// <summary>
        ///     Set of alerts related to this alert entity (each alert is pushed to the SIEM as a separate record).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Set of alerts related to this alert entity (each alert is pushed to the SIEM as a separate record).",
            SerializedName = @"detectionIds",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string[] DetectionIds { get; set; }

        /// <summary>
        ///     Time at which the event(s) that served as the trigger(s) to generate the alert occurred. The Timestamp type
        ///     represents
        ///     date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014
        ///     is
        ///     2014-01-01T00:00:00Z. Required.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Time at which the event(s) that served as the trigger(s) to generate the alert occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.",
            SerializedName = @"eventDateTime",
            PossibleTypes = new[] {typeof(DateTime)})]
        [Origin(PropertyOrigin.Owned)]
        public DateTime? EventDateTime { get; set; }

        /// <summary>alertFeedback</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"alertFeedback",
            SerializedName = @"feedback",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Feedback { get; set; }

        /// <summary>
        ///     Security-related stateful information generated by the provider about the file(s) related to this alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related stateful information generated by the provider about the file(s) related to this alert.",
            SerializedName = @"fileStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphFileSecurityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphFileSecurityState[] FileStates { get; set; }

        /// <summary>
        ///     A collection of alertHistoryStates comprising an audit log of all updates made to an alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"A collection of alertHistoryStates comprising an audit log of all updates made to an alert.",
            SerializedName = @"historyStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphAlertHistoryState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphAlertHistoryState[] HistoryStates { get; set; }

        /// <summary>
        ///     Security-related stateful information generated by the provider about the host(s) related to this alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related stateful information generated by the provider about the host(s) related to this alert.",
            SerializedName = @"hostStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphHostSecurityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphHostSecurityState[] HostStates { get; set; }

        /// <summary>Read-only.</summary>
        [Origin(PropertyOrigin.Inherited)]
        public string Id
        {
            get => _microsoftGraphEntity.Id;
            set => _microsoftGraphEntity.Id = value;
        }

        /// <summary>IDs of incidents related to current alert.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"IDs of incidents related to current alert.",
            SerializedName = @"incidentIds",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string[] IncidentIds { get; set; }

        /// <summary>Backing field for <see cref="InvestigationSecurityStates" /> property.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"investigationSecurityStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphInvestigationSecurityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphInvestigationSecurityState[] InvestigationSecurityStates { get; set; }

        /// <summary>Backing field for <see cref="LastEventDateTime" /> property.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"lastEventDateTime",
            PossibleTypes = new[] {typeof(DateTime)})]
        [Origin(PropertyOrigin.Owned)]
        public DateTime? LastEventDateTime { get; set; }

        /// <summary>
        ///     Time at which the alert entity was last modified. The Timestamp type represents date and time information using ISO
        ///     8601
        ///     format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Time at which the alert entity was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.",
            SerializedName = @"lastModifiedDateTime",
            PossibleTypes = new[] {typeof(DateTime)})]
        [Origin(PropertyOrigin.Owned)]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>Threat Intelligence pertaining to malware related to this alert.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Threat Intelligence pertaining to malware related to this alert.",
            SerializedName = @"malwareStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphMalwareState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphMalwareState[] MalwareStates { get; set; }

        /// <summary>Backing field for <see cref="MessageSecurityStates" /> property.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"messageSecurityStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphMessageSecurityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphMessageSecurityState[] MessageSecurityStates { get; set; }

        /// <summary>
        ///     Security-related stateful information generated by the provider about the network connection(s) related to this
        ///     alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related stateful information generated by the provider about the network connection(s) related to this alert.",
            SerializedName = @"networkConnections",
            PossibleTypes = new[] {typeof(MicrosoftGraphNetworkConnection)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphNetworkConnection[] NetworkConnections { get; set; }

        /// <summary>
        ///     Security-related stateful information generated by the provider about the process or processes related to this
        ///     alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related stateful information generated by the provider about the process or processes related to this alert.",
            SerializedName = @"processes",
            PossibleTypes = new[] {typeof(MicrosoftGraphProcess)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphProcess[] Processes { get; set; }

        /// <summary>
        ///     Vendor/provider recommended action(s) to take as a result of the alert (for example, isolate machine, enforce2FA,
        ///     reimage
        ///     host).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Vendor/provider recommended action(s) to take as a result of the alert (for example, isolate machine, enforce2FA, reimage host).",
            SerializedName = @"recommendedActions",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string[] RecommendedActions { get; set; }

        /// <summary>
        ///     Security-related stateful information generated by the provider about the registry keys related to this alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related stateful information generated by the provider about the registry keys related to this alert.",
            SerializedName = @"registryKeyStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphRegistryKeyState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphRegistryKeyState[] RegistryKeyStates { get; set; }

        /// <summary>
        ///     Resources related to current alert. For example, for some alerts this can have the Azure Resource value.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Resources related to current alert. For example, for some alerts this can have the Azure Resource value.",
            SerializedName = @"securityResources",
            PossibleTypes = new[] {typeof(MicrosoftGraphSecurityResource)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphSecurityResource[] SecurityResources { get; set; }

        /// <summary>alertSeverity</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"alertSeverity",
            SerializedName = @"severity",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Severity { get; set; }

        /// <summary>
        ///     Hyperlinks (URIs) to the source material related to the alert, for example, provider's user interface for alerts or
        ///     log
        ///     search, etc.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Hyperlinks (URIs) to the source material related to the alert, for example, provider's user interface for alerts or log search, etc.",
            SerializedName = @"sourceMaterials",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string[] SourceMaterials { get; set; }

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
        ///     User-definable labels that can be applied to an alert and can serve as filter conditions (for example 'HVA', 'SAW',
        ///     etc.)
        ///     (supports update).
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"User-definable labels that can be applied to an alert and can serve as filter conditions (for example 'HVA', 'SAW', etc.) (supports update).",
            SerializedName = @"tags",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string[] Tags { get; set; }

        /// <summary>Alert title. Required.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Alert title. Required.",
            SerializedName = @"title",
            PossibleTypes = new[] {typeof(string)})]
        [Origin(PropertyOrigin.Owned)]
        public string Title { get; set; }

        /// <summary>
        ///     Security-related information about the specific properties that triggered the alert (properties appearing in the
        ///     alert).
        ///     Alerts might contain information about multiple users, hosts, files, ip addresses. This field indicates which
        ///     properties
        ///     triggered the alert generation.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related information about the specific properties that triggered the alert (properties appearing in the alert). Alerts might contain information about multiple users, hosts, files, ip addresses. This field indicates which properties triggered the alert generation.",
            SerializedName = @"triggers",
            PossibleTypes = new[] {typeof(MicrosoftGraphAlertTrigger)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphAlertTrigger[] Triggers
        {
            get => _triggers;
            set => _triggers = value;
        }

        /// <summary>Backing field for <see cref="UriClickSecurityStates" /> property.</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"",
            SerializedName = @"uriClickSecurityStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphUriClickSecurityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphUriClickSecurityState[] UriClickSecurityStates { get; set; }

        /// <summary>
        ///     Security-related stateful information generated by the provider about the user accounts related to this alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description =
                @"Security-related stateful information generated by the provider about the user accounts related to this alert.",
            SerializedName = @"userStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphUserSecurityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphUserSecurityState[] UserStates { get; set; }

        /// <summary>securityVendorInformation</summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"securityVendorInformation",
            SerializedName = @"vendorInformation",
            PossibleTypes = new[] {typeof(MicrosoftGraphSecurityVendorInformation)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphSecurityVendorInformation VendorInformation
        {
            get => _vendorInformation = _vendorInformation ?? new MicrosoftGraphSecurityVendorInformation();
            set => _vendorInformation = value;
        }

        /// <summary>
        ///     Threat intelligence pertaining to one or more vulnerabilities related to this alert.
        /// </summary>
        [Info(
            Required = false,
            ReadOnly = false,
            Description = @"Threat intelligence pertaining to one or more vulnerabilities related to this alert.",
            SerializedName = @"vulnerabilityStates",
            PossibleTypes = new[] {typeof(MicrosoftGraphVulnerabilityState)})]
        [Origin(PropertyOrigin.Owned)]
        public MicrosoftGraphVulnerabilityState[] VulnerabilityStates { get; set; }
    }
}