// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>userAnalytics</summary>
    public partial class MgUserAnalytics
    {

        /// <summary>Backing field for <see cref="ActivityStatistics" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgActivityStatistics[] _activityStatistics;

        /// <summary>
        /// The collection of work activities that a user spent time on during and outside of working hours. Read-only. Nullable.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgActivityStatistics[] ActivityStatistics { get => this._activityStatistics; set => this._activityStatistics = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="Settings" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgSettings _settings;

        /// <summary>settings</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgSettings Settings { get => (this._settings = this._settings ?? new Microsoft.Graph.PowerShell.Users.Models.MgSettings()); set => this._settings = value; }

    }
}