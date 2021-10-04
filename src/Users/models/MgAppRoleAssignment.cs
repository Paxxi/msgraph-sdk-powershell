// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>appRoleAssignment</summary>
    public partial class MgAppRoleAssignment
    {

        /// <summary>Backing field for <see cref="AppRoleId" /> property.</summary>
        private string _appRoleId;

        /// <summary>
        /// The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles
        /// property on the resource application's service principal (resourceId). If the resource application has not declared any
        /// app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal
        /// is assigned to the resource app without any specific app roles. Required on create.
        /// </summary>
        public string AppRoleId { get => this._appRoleId; set => this._appRoleId = value; }

        /// <summary>Backing field for <see cref="CreationTimestamp" /> property.</summary>
        private global::System.DateTime? _creationTimestamp;

        /// <summary>
        /// The time when the app role assignment was created.The Timestamp type represents date and time information using ISO 8601
        /// format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        public global::System.DateTime? CreationTimestamp { get => this._creationTimestamp; set => this._creationTimestamp = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="PrincipalDisplayName" /> property.</summary>
        private string _principalDisplayName;

        /// <summary>
        /// The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports
        /// $filter (eq and startswith).
        /// </summary>
        public string PrincipalDisplayName { get => this._principalDisplayName; set => this._principalDisplayName = value; }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// The unique identifier (id) for the user, group or service principal being granted the app role. Required on create.
        /// </summary>
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="PrincipalType" /> property.</summary>
        private string _principalType;

        /// <summary>
        /// The type of the assigned principal. This can either be User, Group or ServicePrincipal. Read-only.
        /// </summary>
        public string PrincipalType { get => this._principalType; set => this._principalType = value; }

        /// <summary>Backing field for <see cref="ResourceDisplayName" /> property.</summary>
        private string _resourceDisplayName;

        /// <summary>
        /// The display name of the resource app's service principal to which the assignment is made.
        /// </summary>
        public string ResourceDisplayName { get => this._resourceDisplayName; set => this._resourceDisplayName = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports
        /// $filter (eq only).
        /// </summary>
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

    }
}