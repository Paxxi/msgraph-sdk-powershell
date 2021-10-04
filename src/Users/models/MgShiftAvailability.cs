// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>shiftAvailability</summary>
    public partial class MgShiftAvailability
    {

        /// <summary>Backing field for <see cref="Recurrence" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPatternedRecurrence _recurrence;

        /// <summary>patternedRecurrence</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPatternedRecurrence Recurrence { get => (this._recurrence = this._recurrence ?? new Microsoft.Graph.PowerShell.Users.Models.MgPatternedRecurrence()); set => this._recurrence = value; }

        /// <summary>Backing field for <see cref="TimeSlots" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgTimeRange[] _timeSlots;

        /// <summary>The time slot(s) preferred by the user.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgTimeRange[] TimeSlots { get => this._timeSlots; set => this._timeSlots = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>Specifies the time zone for the indicated time.</summary>
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

    }
}