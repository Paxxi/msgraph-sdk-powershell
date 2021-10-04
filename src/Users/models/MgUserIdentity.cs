// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>userIdentity</summary>
    public partial class MgUserIdentity
    {

        /// <summary>
        /// The identity's display name. Note that this may not always be available or up to date. For example, if a user changes
        /// their display name, the API may show the new value in a future response, but the items associated with the user won't
        /// show up as having changed when using delta.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>
        /// Indicates the client IP address used by user performing the activity (audit log only).
        /// </summary>
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Unique identifier for the identity.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>The userPrincipalName attribute of the user.</summary>
        public string UserPrincipalName { get => this._userPrincipalName; set => this._userPrincipalName = value; }

    }
}