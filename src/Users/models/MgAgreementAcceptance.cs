// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>agreementAcceptance</summary>
    public partial class MgAgreementAcceptance
    {

        /// <summary>Backing field for <see cref="AgreementFileId" /> property.</summary>
        private string _agreementFileId;

        /// <summary>ID of the agreement file accepted by the user.</summary>
        public string AgreementFileId { get => this._agreementFileId; set => this._agreementFileId = value; }

        /// <summary>Backing field for <see cref="AgreementId" /> property.</summary>
        private string _agreementId;

        /// <summary>ID of the agreement.</summary>
        public string AgreementId { get => this._agreementId; set => this._agreementId = value; }

        /// <summary>Backing field for <see cref="DeviceDisplayName" /> property.</summary>
        private string _deviceDisplayName;

        /// <summary>The display name of the device used for accepting the agreement.</summary>
        public string DeviceDisplayName { get => this._deviceDisplayName; set => this._deviceDisplayName = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        /// <summary>The unique identifier of the device used for accepting the agreement.</summary>
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="DeviceOSType" /> property.</summary>
        private string _deviceOSType;

        /// <summary>The operating system used for accepting the agreement.</summary>
        public string DeviceOSType { get => this._deviceOSType; set => this._deviceOSType = value; }

        /// <summary>Backing field for <see cref="DeviceOSVersion" /> property.</summary>
        private string _deviceOSVersion;

        /// <summary>The operating system version of the device used for accepting the agreement.</summary>
        public string DeviceOSVersion { get => this._deviceOSVersion; set => this._deviceOSVersion = value; }

        /// <summary>Backing field for <see cref="ExpirationDateTime" /> property.</summary>
        private global::System.DateTime? _expirationDateTime;

        /// <summary>
        /// The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format
        /// and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? ExpirationDateTime { get => this._expirationDateTime; set => this._expirationDateTime = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="RecordedDateTime" /> property.</summary>
        private global::System.DateTime? _recordedDateTime;

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? RecordedDateTime { get => this._recordedDateTime; set => this._recordedDateTime = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>agreementAcceptanceState</summary>
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="UserDisplayName" /> property.</summary>
        private string _userDisplayName;

        /// <summary>Display name of the user when the acceptance was recorded.</summary>
        public string UserDisplayName { get => this._userDisplayName; set => this._userDisplayName = value; }

        /// <summary>Backing field for <see cref="UserEmail" /> property.</summary>
        private string _userEmail;

        /// <summary>Email of the user when the acceptance was recorded.</summary>
        public string UserEmail { get => this._userEmail; set => this._userEmail = value; }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>ID of the user who accepted the agreement.</summary>
        public string UserId { get => this._userId; set => this._userId = value; }

        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>UPN of the user when the acceptance was recorded.</summary>
        public string UserPrincipalName { get => this._userPrincipalName; set => this._userPrincipalName = value; }

    }
}