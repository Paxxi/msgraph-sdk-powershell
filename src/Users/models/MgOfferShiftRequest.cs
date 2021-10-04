// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>offerShiftRequest</summary>
    public partial class MgOfferShiftRequest
    {

        /// <summary>scheduleChangeRequestActor</summary>
        public string AssignedTo { get; set; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get; set; }

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? CreatedDateTime { get; set; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet LastModifiedBy { get; set; }

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? LastModifiedDateTime { get; set; }

        public global::System.DateTime? ManagerActionDateTime { get; set; }

        public string ManagerActionMessage { get; set; }

        public string ManagerUserId { get; set; }

        /// <summary>Backing field for <see cref="RecipientActionDateTime" /> property.</summary>
        private global::System.DateTime? _recipientActionDateTime;

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? RecipientActionDateTime { get => this._recipientActionDateTime; set => this._recipientActionDateTime = value; }

        /// <summary>Backing field for <see cref="RecipientActionMessage" /> property.</summary>
        private string _recipientActionMessage;

        /// <summary>Custom message sent by recipient of the offer shift request.</summary>
        public string RecipientActionMessage { get => this._recipientActionMessage; set => this._recipientActionMessage = value; }

        /// <summary>Backing field for <see cref="RecipientUserId" /> property.</summary>
        private string _recipientUserId;

        /// <summary>User id of the recipient of the offer shift request.</summary>
        public string RecipientUserId { get => this._recipientUserId; set => this._recipientUserId = value; }

        public global::System.DateTime? SenderDateTime { get; set; }

        public string SenderMessage { get; set; }

        /// <summary>Backing field for <see cref="SenderShiftId" /> property.</summary>
        private string _senderShiftId;

        /// <summary>User id of the sender of the offer shift request.</summary>
        public string SenderShiftId { get => this._senderShiftId; set => this._senderShiftId = value; }

        public string SenderUserId { get; set; }

        /// <summary>scheduleChangeState</summary>
        public string State { get; set; }

    }
}