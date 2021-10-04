// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>
    /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity
    /// types.
    /// </summary>
    public partial class MgDevice
    {

        /// <summary>Backing field for <see cref="AccountEnabled" /> property.</summary>
        private bool? _accountEnabled;

        /// <summary>
        /// true if the account is enabled; otherwise, false. Default is true. Supports $filter (eq, ne, NOT, in).
        /// </summary>
        public bool? AccountEnabled { get => this._accountEnabled; set => this._accountEnabled = value; }

        /// <summary>Backing field for <see cref="AlternativeSecurityIds" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgAlternativeSecurityId[] _alternativeSecurityIds;

        /// <summary>For internal use only. Not nullable. Supports $filter (eq, NOT, ge, le).</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgAlternativeSecurityId[] AlternativeSecurityIds { get => this._alternativeSecurityIds; set => this._alternativeSecurityIds = value; }

        /// <summary>Backing field for <see cref="ApproximateLastSignInDateTime" /> property.</summary>
        private global::System.DateTime? _approximateLastSignInDateTime;

        /// <summary>
        /// The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, NOT, ge, le) and $orderBy.
        /// </summary>
        public global::System.DateTime? ApproximateLastSignInDateTime { get => this._approximateLastSignInDateTime; set => this._approximateLastSignInDateTime = value; }

        /// <summary>Backing field for <see cref="Commands" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgCommand[] _commands;

        /// <summary>Set of commands sent to this device.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgCommand[] Commands { get => this._commands; set => this._commands = value; }

        /// <summary>Backing field for <see cref="ComplianceExpirationDateTime" /> property.</summary>
        private global::System.DateTime? _complianceExpirationDateTime;

        /// <summary>
        /// The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using
        /// ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        public global::System.DateTime? ComplianceExpirationDateTime { get => this._complianceExpirationDateTime; set => this._complianceExpirationDateTime = value; }

        public global::System.DateTime? DeletedDateTime { get; set; }

        /// <summary>Backing field for <see cref="DeviceCategory" /> property.</summary>
        private string _deviceCategory;

        /// <summary>
        /// User-defined property set by Intune to automatically add devices to groups and simplify managing devices.
        /// </summary>
        public string DeviceCategory { get => this._deviceCategory; set => this._deviceCategory = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        /// <summary>
        /// Identifier set by Azure Device Registration Service at the time of registration. Supports $filter (eq, ne, NOT, startsWith).
        /// </summary>
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="DeviceMetadata" /> property.</summary>
        private string _deviceMetadata;

        /// <summary>For internal use only. Set to null.</summary>
        public string DeviceMetadata { get => this._deviceMetadata; set => this._deviceMetadata = value; }

        /// <summary>Backing field for <see cref="DeviceOwnership" /> property.</summary>
        private string _deviceOwnership;

        /// <summary>
        /// Ownership of the device. This property is set by Intune. Possible values are: unknown, company, personal.
        /// </summary>
        public string DeviceOwnership { get => this._deviceOwnership; set => this._deviceOwnership = value; }

        /// <summary>Backing field for <see cref="DeviceVersion" /> property.</summary>
        private int? _deviceVersion;

        /// <summary>For internal use only.</summary>
        public int? DeviceVersion { get => this._deviceVersion; set => this._deviceVersion = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>
        /// The display name for the device. Required. Supports $filter (eq, ne, NOT, ge, le, in, startsWith), $search, and $orderBy.
        /// </summary>
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="DomainName" /> property.</summary>
        private string _domainName;

        /// <summary>
        /// The on-premises domain name of Hybrid Azure AD joined devices. This property is set by Intune.
        /// </summary>
        public string DomainName { get => this._domainName; set => this._domainName = value; }

        /// <summary>Backing field for <see cref="EnrollmentProfileName" /> property.</summary>
        private string _enrollmentProfileName;

        /// <summary>
        /// Enrollment profile applied to the device. For example, Apple Device Enrollment Profile, Device enrollment - Corporate
        /// device identifiers, or Windows Autopilot profile name. This property is set by Intune.
        /// </summary>
        public string EnrollmentProfileName { get => this._enrollmentProfileName; set => this._enrollmentProfileName = value; }

        /// <summary>Backing field for <see cref="EnrollmentType" /> property.</summary>
        private string _enrollmentType;

        /// <summary>
        /// Enrollment type of the device. This property is set by Intune. Possible values are: unknown, userEnrollment, deviceEnrollmentManager,
        /// appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin,
        /// windowsCoManagement.
        /// </summary>
        public string EnrollmentType { get => this._enrollmentType; set => this._enrollmentType = value; }

        /// <summary>Backing field for <see cref="ExtensionAttributes" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgOnPremisesExtensionAttributes _extensionAttributes;

        /// <summary>onPremisesExtensionAttributes</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgOnPremisesExtensionAttributes ExtensionAttributes { get => (this._extensionAttributes = this._extensionAttributes ?? new Microsoft.Graph.PowerShell.Users.Models.MgOnPremisesExtensionAttributes()); set => this._extensionAttributes = value; }

        /// <summary>Backing field for <see cref="Extensions" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgExtension[] _extensions;

        /// <summary>The collection of open extensions defined for the device. Read-only. Nullable.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgExtension[] Extensions { get => this._extensions; set => this._extensions = value; }

        /// <summary>Backing field for <see cref="Hostnames" /> property.</summary>
        private string[] _hostnames;

        /// <summary>List of hostNames for the device.</summary>
        public string[] Hostnames { get => this._hostnames; set => this._hostnames = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="IsCompliant" /> property.</summary>
        private bool? _isCompliant;

        /// <summary>
        /// true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be
        /// updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, NOT).
        /// </summary>
        public bool? IsCompliant { get => this._isCompliant; set => this._isCompliant = value; }

        /// <summary>Backing field for <see cref="IsManaged" /> property.</summary>
        private bool? _isManaged;

        /// <summary>
        /// true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune
        /// for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, NOT).
        /// </summary>
        public bool? IsManaged { get => this._isManaged; set => this._isManaged = value; }

        /// <summary>Backing field for <see cref="IsRooted" /> property.</summary>
        private bool? _isRooted;

        /// <summary>
        /// true if device is rooted; false if device is jail-broken. This can only be updated by Intune.
        /// </summary>
        public bool? IsRooted { get => this._isRooted; set => this._isRooted = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>
        /// Form factor of device. Only returned if user signs in with a Microsoft account as part of Project Rome.
        /// </summary>
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Backing field for <see cref="ManagementType" /> property.</summary>
        private string _managementType;

        /// <summary>
        /// Management channel of the device. This property is set by Intune. Possible values are: eas, mdm, easMdm, intuneClient,
        /// easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown,
        /// jamf, googleCloudDevicePolicyController.
        /// </summary>
        public string ManagementType { get => this._managementType; set => this._managementType = value; }

        /// <summary>Backing field for <see cref="Manufacturer" /> property.</summary>
        private string _manufacturer;

        /// <summary>Manufacturer of the device. Read-only.</summary>
        public string Manufacturer { get => this._manufacturer; set => this._manufacturer = value; }

        /// <summary>Backing field for <see cref="MemberOf" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] _memberOf;

        /// <summary>Groups that this device is a member of. Read-only. Nullable. Supports $expand.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] MemberOf { get => this._memberOf; set => this._memberOf = value; }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Model of the device. Read-only.</summary>
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// Friendly name of a device. Only returned if user signs in with a Microsoft account as part of Project Rome.
        /// </summary>
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="OnPremisesLastSyncDateTime" /> property.</summary>
        private global::System.DateTime? _onPremisesLastSyncDateTime;

        /// <summary>
        /// The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time
        /// information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// Read-only. Supports $filter (eq, ne, NOT, ge, le, in).
        /// </summary>
        public global::System.DateTime? OnPremisesLastSyncDateTime { get => this._onPremisesLastSyncDateTime; set => this._onPremisesLastSyncDateTime = value; }

        /// <summary>Backing field for <see cref="OnPremisesSyncEnabled" /> property.</summary>
        private bool? _onPremisesSyncEnabled;

        /// <summary>
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises
        /// directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).
        /// Read-only. Supports $filter (eq, ne, NOT, in).
        /// </summary>
        public bool? OnPremisesSyncEnabled { get => this._onPremisesSyncEnabled; set => this._onPremisesSyncEnabled = value; }

        /// <summary>Backing field for <see cref="OperatingSystem" /> property.</summary>
        private string _operatingSystem;

        /// <summary>
        /// The type of operating system on the device. Required. Supports $filter (eq, ne, NOT, ge, le, startsWith).
        /// </summary>
        public string OperatingSystem { get => this._operatingSystem; set => this._operatingSystem = value; }

        /// <summary>Backing field for <see cref="OperatingSystemVersion" /> property.</summary>
        private string _operatingSystemVersion;

        /// <summary>
        /// Operating system version of the device. Required. Supports $filter (eq, ne, NOT, ge, le, startsWith).
        /// </summary>
        public string OperatingSystemVersion { get => this._operatingSystemVersion; set => this._operatingSystemVersion = value; }

        /// <summary>Backing field for <see cref="PhysicalIds" /> property.</summary>
        private string[] _physicalIds;

        /// <summary>
        /// For internal use only. Not nullable. Supports $filter (eq, NOT, ge, le, startsWith).
        /// </summary>
        public string[] PhysicalIds { get => this._physicalIds; set => this._physicalIds = value; }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private string _platform;

        /// <summary>
        /// Platform of device. Only returned if user signs in with a Microsoft account as part of Project Rome. Only returned if
        /// user signs in with a Microsoft account as part of Project Rome.
        /// </summary>
        public string Platform { get => this._platform; set => this._platform = value; }

        /// <summary>Backing field for <see cref="ProfileType" /> property.</summary>
        private string _profileType;

        /// <summary>
        /// The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.
        /// </summary>
        public string ProfileType { get => this._profileType; set => this._profileType = value; }

        /// <summary>Backing field for <see cref="RegisteredOwners" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] _registeredOwners;

        /// <summary>
        /// The user that cloud joined the device or registered their personal device. The registered owner is set at the time of
        /// registration. Currently, there can be only one owner. Read-only. Nullable. Supports $expand.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] RegisteredOwners { get => this._registeredOwners; set => this._registeredOwners = value; }

        /// <summary>Backing field for <see cref="RegisteredUsers" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] _registeredUsers;

        /// <summary>
        /// Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users
        /// are set to the same value as registered owners at the time of registration. Read-only. Nullable. Supports $expand.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] RegisteredUsers { get => this._registeredUsers; set => this._registeredUsers = value; }

        /// <summary>Backing field for <see cref="RegistrationDateTime" /> property.</summary>
        private global::System.DateTime? _registrationDateTime;

        /// <summary>
        /// Date and time of when the device was registered. The timestamp type represents date and time information using ISO 8601
        /// format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        public global::System.DateTime? RegistrationDateTime { get => this._registrationDateTime; set => this._registrationDateTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>
        /// Device is online or offline. Only returned if user signs in with a Microsoft account as part of Project Rome.
        /// </summary>
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="SystemLabels" /> property.</summary>
        private string[] _systemLabels;

        /// <summary>List of labels applied to the device by the system.</summary>
        public string[] SystemLabels { get => this._systemLabels; set => this._systemLabels = value; }

        /// <summary>Backing field for <see cref="TransitiveMemberOf" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] _transitiveMemberOf;

        /// <summary>
        /// Groups that this device is a member of. This operation is transitive. Supports $expand.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgDirectoryObject[] TransitiveMemberOf { get => this._transitiveMemberOf; set => this._transitiveMemberOf = value; }

        /// <summary>Backing field for <see cref="TrustType" /> property.</summary>
        private string _trustType;

        /// <summary>
        /// Type of trust for the joined device. Read-only. Possible values: Workplace (indicates bring your own personal devices),
        /// AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details,
        /// see Introduction to device management in Azure Active Directory
        /// </summary>
        public string TrustType { get => this._trustType; set => this._trustType = value; }

        /// <summary>Backing field for <see cref="UsageRights" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgUsageRight[] _usageRights;

        /// <summary>Represents the usage rights a device has been granted.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgUsageRight[] UsageRights { get => this._usageRights; set => this._usageRights = value; }

    }
}