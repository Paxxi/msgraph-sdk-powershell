// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>scheduleEntity</summary>
    public partial class MgScheduleEntity
    {

        /// <summary>Backing field for <see cref="EndDateTime" /> property.</summary>
        private global::System.DateTime? _endDateTime;

        public global::System.DateTime? EndDateTime { get => this._endDateTime; set => this._endDateTime = value; }

        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private global::System.DateTime? _startDateTime;

        public global::System.DateTime? StartDateTime { get => this._startDateTime; set => this._startDateTime = value; }

        /// <summary>Backing field for <see cref="Theme" /> property.</summary>
        private string _theme;

        /// <summary>scheduleEntityTheme</summary>
        public string Theme { get => this._theme; set => this._theme = value; }

    }
}