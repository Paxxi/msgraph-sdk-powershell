// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>calendarPermission</summary>
    public partial class MgCalendarPermission
    {

        /// <summary>Backing field for <see cref="AllowedRoles" /> property.</summary>
        private string[] _allowedRoles;

        /// <summary>
        /// List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead,
        /// read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
        /// </summary>
        public string[] AllowedRoles { get => this._allowedRoles; set => this._allowedRoles = value; }

        /// <summary>Backing field for <see cref="EmailAddress" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgEmailAddress _emailAddress;

        /// <summary>emailAddress</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgEmailAddress EmailAddress { get => (this._emailAddress = this._emailAddress ?? new Microsoft.Graph.PowerShell.Users.Models.MgEmailAddress()); set => this._emailAddress = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="IsInsideOrganization" /> property.</summary>
        private bool? _isInsideOrganization;

        /// <summary>
        /// True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
        /// </summary>
        public bool? IsInsideOrganization { get => this._isInsideOrganization; set => this._isInsideOrganization = value; }

        /// <summary>Backing field for <see cref="IsRemovable" /> property.</summary>
        private bool? _isRemovable;

        /// <summary>
        /// True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The
        /// 'My organization' user determines the permissions other people within your organization have to the given calendar. You
        /// cannot remove 'My organization' as a sharee to a calendar.
        /// </summary>
        public bool? IsRemovable { get => this._isRemovable; set => this._isRemovable = value; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private string _role;

        /// <summary>calendarRoleType</summary>
        public string Role { get => this._role; set => this._role = value; }

    }
}