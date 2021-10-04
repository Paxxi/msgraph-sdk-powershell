// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>Mobile App Intent and Install State for a given device.</summary>
    public partial class MgMobileAppIntentAndStateDetail
    {

        /// <summary>Backing field for <see cref="ApplicationId" /> property.</summary>
        private string _applicationId;

        /// <summary>MobieApp identifier.</summary>
        public string ApplicationId { get => this._applicationId; set => this._applicationId = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="DisplayVersion" /> property.</summary>
        private string _displayVersion;

        /// <summary>Human readable version of the application</summary>
        public string DisplayVersion { get => this._displayVersion; set => this._displayVersion = value; }

        /// <summary>Backing field for <see cref="InstallState" /> property.</summary>
        private string _installState;

        /// <summary>resultantAppState</summary>
        public string InstallState { get => this._installState; set => this._installState = value; }

        /// <summary>Backing field for <see cref="MobileAppIntent" /> property.</summary>
        private string _mobileAppIntent;

        /// <summary>mobileAppIntent</summary>
        public string MobileAppIntent { get => this._mobileAppIntent; set => this._mobileAppIntent = value; }

        /// <summary>Backing field for <see cref="SupportedDeviceTypes" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgMobileAppSupportedDeviceType[] _supportedDeviceTypes;

        /// <summary>The supported platforms for the app.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgMobileAppSupportedDeviceType[] SupportedDeviceTypes { get => this._supportedDeviceTypes; set => this._supportedDeviceTypes = value; }

    }
}