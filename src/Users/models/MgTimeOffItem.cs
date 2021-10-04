// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>timeOffItem</summary>
    public partial class MgTimeOffItem
    {

        public global::System.DateTime? EndDateTime { get; set; }

        public global::System.DateTime? StartDateTime { get; set; }

        /// <summary>scheduleEntityTheme</summary>
        public string Theme { get; set; }

        /// <summary>Backing field for <see cref="TimeOffReasonId" /> property.</summary>
        private string _timeOffReasonId;

        /// <summary>ID of the timeOffReason for this timeOffItem. Required.</summary>
        public string TimeOffReasonId { get => this._timeOffReasonId; set => this._timeOffReasonId = value; }

    }
}