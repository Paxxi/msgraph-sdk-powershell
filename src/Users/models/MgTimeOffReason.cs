// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>timeOffReason</summary>
    public partial class MgTimeOffReason
    {

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get; set; }

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? CreatedDateTime { get; set; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The name of the timeOffReason. Required.</summary>
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="IconType" /> property.</summary>
        private string _iconType;

        /// <summary>timeOffReasonIconType</summary>
        public string IconType { get => this._iconType; set => this._iconType = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="IsActive" /> property.</summary>
        private bool? _isActive;

        /// <summary>
        /// Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.
        /// </summary>
        public bool? IsActive { get => this._isActive; set => this._isActive = value; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet LastModifiedBy { get; set; }

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? LastModifiedDateTime { get; set; }

    }
}