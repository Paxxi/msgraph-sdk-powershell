// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>attendanceInterval</summary>
    public partial class MgAttendanceInterval
    {

        /// <summary>Backing field for <see cref="DurationInSeconds" /> property.</summary>
        private int? _durationInSeconds;

        /// <summary>
        /// Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.
        /// </summary>
        public int? DurationInSeconds { get => this._durationInSeconds; set => this._durationInSeconds = value; }

        /// <summary>Backing field for <see cref="JoinDateTime" /> property.</summary>
        private global::System.DateTime? _joinDateTime;

        /// <summary>Time attendee joined in UTC.</summary>
        public global::System.DateTime? JoinDateTime { get => this._joinDateTime; set => this._joinDateTime = value; }

        /// <summary>Backing field for <see cref="LeaveDateTime" /> property.</summary>
        private global::System.DateTime? _leaveDateTime;

        /// <summary>Time attendee left in UTC.</summary>
        public global::System.DateTime? LeaveDateTime { get => this._leaveDateTime; set => this._leaveDateTime = value; }

    }
}