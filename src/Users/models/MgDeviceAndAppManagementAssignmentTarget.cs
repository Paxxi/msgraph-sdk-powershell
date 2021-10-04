// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>Base type for assignment targets.</summary>
    public partial class MgDeviceAndAppManagementAssignmentTarget
    {

        /// <summary>
        /// Backing field for <see cref="DeviceAndAppManagementAssignmentFilterId" /> property.
        /// </summary>
        private string _deviceAndAppManagementAssignmentFilterId;

        /// <summary>The Id of the filter for the target assignment.</summary>
        public string DeviceAndAppManagementAssignmentFilterId { get => this._deviceAndAppManagementAssignmentFilterId; set => this._deviceAndAppManagementAssignmentFilterId = value; }

        /// <summary>
        /// Backing field for <see cref="DeviceAndAppManagementAssignmentFilterType" /> property.
        /// </summary>
        private string _deviceAndAppManagementAssignmentFilterType;

        /// <summary>deviceAndAppManagementAssignmentFilterType</summary>
        public string DeviceAndAppManagementAssignmentFilterType { get => this._deviceAndAppManagementAssignmentFilterType; set => this._deviceAndAppManagementAssignmentFilterType = value; }

    }
}