// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>meetingParticipants</summary>
    public partial class MgMeetingParticipants
    {

        /// <summary>Backing field for <see cref="Attendees" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo[] _attendees;

        /// <summary>Information of the meeting attendees.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo[] Attendees { get => this._attendees; set => this._attendees = value; }

        /// <summary>Backing field for <see cref="Contributors" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo[] _contributors;

        public Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo[] Contributors { get => this._contributors; set => this._contributors = value; }

        /// <summary>Backing field for <see cref="Organizer" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo _organizer;

        /// <summary>meetingParticipantInfo</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo Organizer { get => (this._organizer = this._organizer ?? new Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo()); set => this._organizer = value; }

        /// <summary>Backing field for <see cref="Producers" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo[] _producers;

        public Microsoft.Graph.PowerShell.Users.Models.MgMeetingParticipantInfo[] Producers { get => this._producers; set => this._producers = value; }

    }
}