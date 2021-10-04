// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>shift</summary>
    public partial class MgShift
    {

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get; set; }

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? CreatedDateTime { get; set; }

        /// <summary>Backing field for <see cref="DraftShift" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgShiftItem _draftShift;

        /// <summary>shiftItem</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgShiftItem DraftShift { get => (this._draftShift = this._draftShift ?? new Microsoft.Graph.PowerShell.Users.Models.MgShiftItem()); set => this._draftShift = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="IsStagedForDeletion" /> property.</summary>
        private bool? _isStagedForDeletion;

        public bool? IsStagedForDeletion { get => this._isStagedForDeletion; set => this._isStagedForDeletion = value; }

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet LastModifiedBy { get; set; }

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>Backing field for <see cref="SchedulingGroupId" /> property.</summary>
        private string _schedulingGroupId;

        /// <summary>ID of the scheduling group the shift is part of. Required.</summary>
        public string SchedulingGroupId { get => this._schedulingGroupId; set => this._schedulingGroupId = value; }

        /// <summary>Backing field for <see cref="SharedShift" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgShiftItem _sharedShift;

        /// <summary>shiftItem</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgShiftItem SharedShift { get => (this._sharedShift = this._sharedShift ?? new Microsoft.Graph.PowerShell.Users.Models.MgShiftItem()); set => this._sharedShift = value; }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>ID of the user assigned to the shift. Required.</summary>
        public string UserId { get => this._userId; set => this._userId = value; }

    }
}