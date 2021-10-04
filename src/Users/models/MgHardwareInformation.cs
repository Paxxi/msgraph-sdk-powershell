// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>Hardware information of a given device.</summary>
    public partial class MgHardwareInformation
    {

        /// <summary>Backing field for <see cref="BatteryChargeCycles" /> property.</summary>
        private int? _batteryChargeCycles;

        /// <summary>
        /// The number of charge cycles the device’s current battery has gone through. Valid values 0 to 2147483647
        /// </summary>
        public int? BatteryChargeCycles { get => this._batteryChargeCycles; set => this._batteryChargeCycles = value; }

        /// <summary>Backing field for <see cref="BatteryHealthPercentage" /> property.</summary>
        private int? _batteryHealthPercentage;

        /// <summary>The device’s current battery’s health percentage. Valid values 0 to 100</summary>
        public int? BatteryHealthPercentage { get => this._batteryHealthPercentage; set => this._batteryHealthPercentage = value; }

        /// <summary>Backing field for <see cref="BatterySerialNumber" /> property.</summary>
        private string _batterySerialNumber;

        /// <summary>The serial number of the device’s current battery</summary>
        public string BatterySerialNumber { get => this._batterySerialNumber; set => this._batterySerialNumber = value; }

        /// <summary>Backing field for <see cref="CellularTechnology" /> property.</summary>
        private string _cellularTechnology;

        /// <summary>Cellular technology of the device</summary>
        public string CellularTechnology { get => this._cellularTechnology; set => this._cellularTechnology = value; }

        /// <summary>Backing field for <see cref="DeviceFullQualifiedDomainName" /> property.</summary>
        private string _deviceFullQualifiedDomainName;

        /// <summary>
        /// Returns the fully qualified domain name of the device (if any). If the device is not domain-joined, it returns an empty
        /// string.
        /// </summary>
        public string DeviceFullQualifiedDomainName { get => this._deviceFullQualifiedDomainName; set => this._deviceFullQualifiedDomainName = value; }

        /// <summary>
        /// Backing field for <see cref="DeviceGuardLocalSystemAuthorityCredentialGuardState" /> property.
        /// </summary>
        private string _deviceGuardLocalSystemAuthorityCredentialGuardState;

        /// <summary>deviceGuardLocalSystemAuthorityCredentialGuardState</summary>
        public string DeviceGuardLocalSystemAuthorityCredentialGuardState { get => this._deviceGuardLocalSystemAuthorityCredentialGuardState; set => this._deviceGuardLocalSystemAuthorityCredentialGuardState = value; }

        /// <summary>
        /// Backing field for <see cref="DeviceGuardVirtualizationBasedSecurityHardwareRequirementState" /> property.
        /// </summary>
        private string _deviceGuardVirtualizationBasedSecurityHardwareRequirementState;

        /// <summary>deviceGuardVirtualizationBasedSecurityHardwareRequirementState</summary>
        public string DeviceGuardVirtualizationBasedSecurityHardwareRequirementState { get => this._deviceGuardVirtualizationBasedSecurityHardwareRequirementState; set => this._deviceGuardVirtualizationBasedSecurityHardwareRequirementState = value; }

        /// <summary>
        /// Backing field for <see cref="DeviceGuardVirtualizationBasedSecurityState" /> property.
        /// </summary>
        private string _deviceGuardVirtualizationBasedSecurityState;

        /// <summary>deviceGuardVirtualizationBasedSecurityState</summary>
        public string DeviceGuardVirtualizationBasedSecurityState { get => this._deviceGuardVirtualizationBasedSecurityState; set => this._deviceGuardVirtualizationBasedSecurityState = value; }

        /// <summary>Backing field for <see cref="EsimIdentifier" /> property.</summary>
        private string _esimIdentifier;

        /// <summary>eSIM identifier</summary>
        public string EsimIdentifier { get => this._esimIdentifier; set => this._esimIdentifier = value; }

        /// <summary>Backing field for <see cref="FreeStorageSpace" /> property.</summary>
        private long? _freeStorageSpace;

        /// <summary>Free storage space of the device.</summary>
        public long? FreeStorageSpace { get => this._freeStorageSpace; set => this._freeStorageSpace = value; }

        /// <summary>Backing field for <see cref="IPAddressV4" /> property.</summary>
        private string _iPAddressV4;

        /// <summary>IPAddressV4</summary>
        public string IPAddressV4 { get => this._iPAddressV4; set => this._iPAddressV4 = value; }

        /// <summary>Backing field for <see cref="Imei" /> property.</summary>
        private string _imei;

        /// <summary>IMEI</summary>
        public string Imei { get => this._imei; set => this._imei = value; }

        /// <summary>Backing field for <see cref="IsEncrypted" /> property.</summary>
        private bool? _isEncrypted;

        /// <summary>Encryption status of the device</summary>
        public bool? IsEncrypted { get => this._isEncrypted; set => this._isEncrypted = value; }

        /// <summary>Backing field for <see cref="IsSharedDevice" /> property.</summary>
        private bool? _isSharedDevice;

        /// <summary>Shared iPad</summary>
        public bool? IsSharedDevice { get => this._isSharedDevice; set => this._isSharedDevice = value; }

        /// <summary>Backing field for <see cref="IsSupervised" /> property.</summary>
        private bool? _isSupervised;

        /// <summary>Supervised mode of the device</summary>
        public bool? IsSupervised { get => this._isSupervised; set => this._isSupervised = value; }

        /// <summary>Backing field for <see cref="Manufacturer" /> property.</summary>
        private string _manufacturer;

        /// <summary>Manufacturer of the device</summary>
        public string Manufacturer { get => this._manufacturer; set => this._manufacturer = value; }

        /// <summary>Backing field for <see cref="Meid" /> property.</summary>
        private string _meid;

        /// <summary>MEID</summary>
        public string Meid { get => this._meid; set => this._meid = value; }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Model of the device</summary>
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="OSBuildNumber" /> property.</summary>
        private string _oSBuildNumber;

        /// <summary>Operating System Build Number on Android device</summary>
        public string OSBuildNumber { get => this._oSBuildNumber; set => this._oSBuildNumber = value; }

        /// <summary>Backing field for <see cref="OperatingSystemEdition" /> property.</summary>
        private string _operatingSystemEdition;

        /// <summary>String that specifies the OS edition.</summary>
        public string OperatingSystemEdition { get => this._operatingSystemEdition; set => this._operatingSystemEdition = value; }

        /// <summary>Backing field for <see cref="OperatingSystemLanguage" /> property.</summary>
        private string _operatingSystemLanguage;

        /// <summary>Operating system language of the device</summary>
        public string OperatingSystemLanguage { get => this._operatingSystemLanguage; set => this._operatingSystemLanguage = value; }

        /// <summary>Backing field for <see cref="OperatingSystemProductType" /> property.</summary>
        private int? _operatingSystemProductType;

        /// <summary>
        /// Int that specifies the Windows Operating System ProductType. More details here https://go.microsoft.com/fwlink/?linkid=2126950.
        /// Valid values 0 to 2147483647
        /// </summary>
        public int? OperatingSystemProductType { get => this._operatingSystemProductType; set => this._operatingSystemProductType = value; }

        /// <summary>Backing field for <see cref="PhoneNumber" /> property.</summary>
        private string _phoneNumber;

        /// <summary>Phone number of the device</summary>
        public string PhoneNumber { get => this._phoneNumber; set => this._phoneNumber = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Serial number.</summary>
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="SharedDeviceCachedUsers" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgSharedAppleDeviceUser[] _sharedDeviceCachedUsers;

        /// <summary>All users on the shared Apple device</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgSharedAppleDeviceUser[] SharedDeviceCachedUsers { get => this._sharedDeviceCachedUsers; set => this._sharedDeviceCachedUsers = value; }

        /// <summary>Backing field for <see cref="SubnetAddress" /> property.</summary>
        private string _subnetAddress;

        /// <summary>SubnetAddress</summary>
        public string SubnetAddress { get => this._subnetAddress; set => this._subnetAddress = value; }

        /// <summary>Backing field for <see cref="SubscriberCarrier" /> property.</summary>
        private string _subscriberCarrier;

        /// <summary>Subscriber carrier of the device</summary>
        public string SubscriberCarrier { get => this._subscriberCarrier; set => this._subscriberCarrier = value; }

        /// <summary>Backing field for <see cref="TotalStorageSpace" /> property.</summary>
        private long? _totalStorageSpace;

        /// <summary>Total storage space of the device.</summary>
        public long? TotalStorageSpace { get => this._totalStorageSpace; set => this._totalStorageSpace = value; }

        /// <summary>Backing field for <see cref="TpmSpecificationVersion" /> property.</summary>
        private string _tpmSpecificationVersion;

        /// <summary>String that specifies the specification version.</summary>
        public string TpmSpecificationVersion { get => this._tpmSpecificationVersion; set => this._tpmSpecificationVersion = value; }

        /// <summary>Backing field for <see cref="WifiMac" /> property.</summary>
        private string _wifiMac;

        /// <summary>WiFi MAC address of the device</summary>
        public string WifiMac { get => this._wifiMac; set => this._wifiMac = value; }

    }
}