// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>recurrenceRange</summary>
    public partial class MgRecurrenceRange
    {

        /// <summary>Backing field for <see cref="EndDate" /> property.</summary>
        private global::System.DateTime? _endDate;

        /// <summary>
        /// The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence
        /// of the meeting may not be this date. Required if type is endDate.
        /// </summary>
        public global::System.DateTime? EndDate { get => this._endDate; set => this._endDate = value; }

        /// <summary>Backing field for <see cref="NumberOfOccurrences" /> property.</summary>
        private int? _numberOfOccurrences;

        /// <summary>
        /// The number of times to repeat the event. Required and must be positive if type is numbered.
        /// </summary>
        public int? NumberOfOccurrences { get => this._numberOfOccurrences; set => this._numberOfOccurrences = value; }

        /// <summary>Backing field for <see cref="RecurrenceTimeZone" /> property.</summary>
        private string _recurrenceTimeZone;

        /// <summary>
        /// Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
        /// </summary>
        public string RecurrenceTimeZone { get => this._recurrenceTimeZone; set => this._recurrenceTimeZone = value; }

        /// <summary>Backing field for <see cref="StartDate" /> property.</summary>
        private global::System.DateTime? _startDate;

        /// <summary>
        /// The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending
        /// on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
        /// </summary>
        public global::System.DateTime? StartDate { get => this._startDate; set => this._startDate = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>recurrenceRangeType</summary>
        public string Type { get => this._type; set => this._type = value; }

    }
}