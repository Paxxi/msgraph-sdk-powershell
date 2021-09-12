namespace Microsoft.Graph.PowerShell.Security.Models
{
    /// <summary>tiIndicator</summary>
    public sealed class MicrosoftGraphTiIndicator
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Models.IMicrosoftGraphEntity" />
        /// </summary>
        private MicrosoftGraphEntity __microsoftGraphEntity = new MicrosoftGraphEntity();

        /// <summary>tiAction</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"tiAction",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string Action { get; set; }

        /// <summary>
        /// The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.",
        SerializedName = @"activityGroupNames",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string[] ActivityGroupNames { get; set; }

        /// <summary>
        /// A catchall area into which extra data from the indicator not covered by the other tiIndicator properties may be placed.
        /// Data placed into additionalInformation will typically not be utilized by the targetProduct security tool.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A catchall area into which extra data from the indicator not covered by the other tiIndicator properties may be placed. Data placed into additionalInformation will typically not be utilized by the targetProduct security tool.",
        SerializedName = @"additionalInformation",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Stamped by the system when the indicator is ingested. The Azure Active Directory tenant id of submitting client. Required.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Stamped by the system when the indicator is ingested. The Azure Active Directory tenant id of submitting client. Required.",
        SerializedName = @"azureTenantId",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string AzureTenantId { get; set; }

        /// <summary>
        /// An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable
        /// values are 0 – 100 with 100 being the highest.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable values are 0 – 100 with 100 being the highest.",
        SerializedName = @"confidence",
        PossibleTypes = new [] { typeof(int) })]
        [Origin(PropertyOrigin.Owned)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Brief description (100 characters or less) of the threat represented by the indicator. Required.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Brief description (100 characters or less) of the threat represented by the indicator. Required.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string Description { get; set; }

        /// <summary>diamondModel</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"diamondModel",
        SerializedName = @"diamondModel",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string DiamondModel { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string DomainName { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailEncoding",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailEncoding { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailLanguage",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailLanguage { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailRecipient",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailRecipient { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailSenderAddress",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailSenderAddress { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailSenderName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailSenderName { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailSourceDomain",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailSourceDomain { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailSourceIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailSourceIPAddress { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailSubject",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailSubject { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailXMailer",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string EmailXMailer { get; set; }

        /// <summary>
        /// DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators
        /// persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always
        /// in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.",
        SerializedName = @"expirationDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? ExpirationDateTime { get; set; }

        /// <summary>
        /// An identification number that ties the indicator back to the indicator provider’s system (e.g. a foreign key).
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An identification number that ties the indicator back to the indicator provider’s system (e.g. a foreign key).",
        SerializedName = @"externalId",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string ExternalId { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileCompileDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? FileCompileDateTime { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileCreatedDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? FileCreatedDateTime { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"fileHashType",
        SerializedName = @"fileHashType",
        PossibleTypes = new [] { typeof(string) })]
        /// <summary>fileHashType</summary>
        [Origin(PropertyOrigin.Owned)]
        public string FileHashType { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileHashValue",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string FileHashValue { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileMutexName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string FileMutexName { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileName",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string FileName { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"filePacker",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string FilePacker { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"filePath",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string FilePath { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileSize",
        PossibleTypes = new [] { typeof(long) })]
        [Origin(PropertyOrigin.Owned)]
        public long? FileSize { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileType",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string FileType { get; set; }

        /// <summary>Read-only.</summary>
        [Origin(PropertyOrigin.Inherited)]
        public string Id { get => __microsoftGraphEntity.Id; set => __microsoftGraphEntity.Id = value; }

        /// <summary>
        /// Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO
        /// 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
        SerializedName = @"ingestedDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? IngestedDateTime { get; set; }

        /// <summary>
        /// Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers
        /// may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.",
        SerializedName = @"isActive",
        PossibleTypes = new [] { typeof(bool) })]
        [Origin(PropertyOrigin.Owned)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain
        /// values’ below for exact values.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain values’ below for exact values.",
        SerializedName = @"killChain",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string[] KillChain { get; set; }

        /// <summary>
        /// Scenarios in which the indicator may cause false positives. This should be human-readable text.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scenarios in which the indicator may cause false positives. This should be human-readable text.",
        SerializedName = @"knownFalsePositives",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string KnownFalsePositives { get; set; }

        /// <summary>
        /// The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and
        /// is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
        SerializedName = @"lastReportedDateTime",
        PossibleTypes = new [] { typeof(System.DateTime) })]
        [Origin(PropertyOrigin.Owned)]
        public System.DateTime? LastReportedDateTime { get; set; }

        /// <summary>
        /// The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name
        /// if at all possible which can be found via the Windows Defender Security Intelligence threat encyclopedia.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible which can be found via the Windows Defender Security Intelligence threat encyclopedia.",
        SerializedName = @"malwareFamilyNames",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string[] MalwareFamilyNames { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkDestinationAsn",
        PossibleTypes = new [] { typeof(long) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkCidrBlock { get; set; }

        [Origin(PropertyOrigin.Owned)]
        public long? NetworkDestinationAsn { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkDestinationCidrBlock",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkDestinationCidrBlock { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkDestinationIPv4",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkDestinationIPv4 { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkDestinationIPv6",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkDestinationIPv6 { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkDestinationPort",
        PossibleTypes = new [] { typeof(int) })]
        [Origin(PropertyOrigin.Owned)]
        public int? NetworkDestinationPort { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkIPv4",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkIPv4 { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkIPv6",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkIPv6 { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkPort",
        PossibleTypes = new [] { typeof(int) })]
        [Origin(PropertyOrigin.Owned)]
        public int? NetworkPort { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkProtocol",
        PossibleTypes = new [] { typeof(int) })]
        [Origin(PropertyOrigin.Owned)]
        public int? NetworkProtocol { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkSourceAsn",
        PossibleTypes = new [] { typeof(long) })]
        [Origin(PropertyOrigin.Owned)]
        public long? NetworkSourceAsn { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkSourceCidrBlock",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkSourceCidrBlock { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkSourceIPv4",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkSourceIPv4 { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkSourceIPv6",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string NetworkSourceIPv6 { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkSourcePort",
        PossibleTypes = new [] { typeof(int) })]
        [Origin(PropertyOrigin.Owned)]
        public int? NetworkSourcePort { get; set; }

        /// <summary>
        /// Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools
        /// will not notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security
        /// products where they will simply log that a match occurred but will not perform the action. Default value is false.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools will not notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they will simply log that a match occurred but will not perform the action. Default value is false.",
        SerializedName = @"passiveOnly",
        PossibleTypes = new [] { typeof(bool) })]
        [Origin(PropertyOrigin.Owned)]
        public bool? PassiveOnly { get; set; }

        /// <summary>
        /// An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable
        /// values are 0 – 5 where 5 is the most severe and zero is not severe at all. Default value is 3.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero is not severe at all. Default value is 3.",
        SerializedName = @"severity",
        PossibleTypes = new [] { typeof(int) })]
        [Origin(PropertyOrigin.Owned)]
        public int? Severity { get; set; }

        /// <summary>A JSON array of strings that stores arbitrary tags/keywords.</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A JSON array of strings that stores arbitrary tags/keywords.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string[] Tags { get; set; }

        /// <summary>
        /// A string value representing a single security product to which the indicator should be applied. Acceptable values are:
        /// Azure Sentinel, Microsoft Defender ATP. Required
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required",
        SerializedName = @"targetProduct",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string TargetProduct { get; set; }

        /// <summary>
        /// Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS,
        /// MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.
        /// </summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.",
        SerializedName = @"threatType",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string ThreatType { get; set; }

        /// <summary>tlpLevel</summary>
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"tlpLevel",
        SerializedName = @"tlpLevel",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string TlpLevel { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string Url { get; set; }

        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userAgent",
        PossibleTypes = new [] { typeof(string) })]
        [Origin(PropertyOrigin.Owned)]
        public string UserAgent { get; set; }

        /// <summary>Creates an new <see cref="MicrosoftGraphTiIndicator" /> instance.</summary>
        public MicrosoftGraphTiIndicator()
        {

        }
    }
}