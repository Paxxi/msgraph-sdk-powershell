// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>assignedLicense</summary>
    public partial class MgAssignedLicense
    {

        /// <summary>Backing field for <see cref="DisabledPlans" /> property.</summary>
        private string[] _disabledPlans;

        /// <summary>A collection of the unique identifiers for plans that have been disabled.</summary>
        public string[] DisabledPlans { get => this._disabledPlans; set => this._disabledPlans = value; }

        /// <summary>Backing field for <see cref="SkuId" /> property.</summary>
        private string _skuId;

        /// <summary>The unique identifier for the SKU.</summary>
        public string SkuId { get => this._skuId; set => this._skuId = value; }

    }
}