// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Cmdlets
{
    using System;
    using System.Management.Automation;

    /// <summary>A collection of this user's license details. Read-only.</summary>
    /// <remarks>
    /// [OpenAPI] GetLicenseDetails=>GET:"/users/{user-id}/licenseDetails/{licenseDetails-id}"
    /// </remarks>
    [Cmdlet(VerbsCommon.Get, "MgUserLicenseDetail", DefaultParameterSetName = ListParameterSet)]
    public partial class GetMgUserLicenseDetail : Microsoft.Graph.PowerShell.Runtime.Cmdlets.GetCmdletBase<Microsoft.Graph.PowerShell.Users.Models.MgLicenseDetails>
    {

        /// <summary>Include count of items</summary>
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Include count of items", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Include count of items", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Include count of items", ValueFromPipeline = false)]
        public override global::System.Management.Automation.SwitchParameter Count { get; set; }

        /// <summary>Expand related entities</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = InputObjectParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [AllowEmptyCollection]
        [Alias("Expand")]
        public override string[] ExpandProperty { get; set; }

        /// <summary>Filter items by property values</summary>
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = true, HelpMessage = "Filter items by property values", ValueFromPipeline = false)]
        public override string Filter { get; set; }

        protected override bool IsSingle { get => !string.IsNullOrEmpty(LicenseDetailsId) || InputObject != null; }

        /// <summary>key: id of licenseDetails</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = true, HelpMessage = "key: id of licenseDetails", ValueFromPipeline = false)]
        public string LicenseDetailsId { get; set; }

        /// <summary>Select properties to be returned</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = InputObjectParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [AllowEmptyCollection]
        [Alias("Select")]
        public override string[] Property { get; set; }

        /// <summary>Search items by search phrases</summary>
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = true, HelpMessage = "Search items by search phrases", ValueFromPipeline = false)]
        public override string Search { get; set; }

        /// <summary>Skip the first n items</summary>
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Skip the first n items", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Skip the first n items", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Skip the first n items", ValueFromPipeline = false)]
        public override int Skip { get; set; }

        /// <summary>Order items by property values</summary>
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Order items by property values", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Order items by property values", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Order items by property values", ValueFromPipeline = false)]
        [AllowEmptyCollection]
        [Alias("OrderBy")]
        public override string[] Sort { get; set; }

        /// <summary>Show only the first n items</summary>
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Show only the first n items", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Show only the first n items", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Show only the first n items", ValueFromPipeline = false)]
        [Alias("Limit")]
        public override int Top { get; set; }

        protected override string Url { get => IsSingle ? $"/users/{Uri.EscapeDataString(UserId)}/licenseDetails/{Uri.EscapeDataString(InputObject != null ? InputObject.Id : LicenseDetailsId)}" : $"/users/{Uri.EscapeDataString(UserId)}/licenseDetails"; }

        /// <summary>key: id of user</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = true, HelpMessage = "key: id of user", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = InputObjectParameterSet, Mandatory = true, HelpMessage = "key: id of user", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = true, HelpMessage = "key: id of user", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = true, HelpMessage = "key: id of user", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = true, HelpMessage = "key: id of user", ValueFromPipeline = false)]
        public string UserId { get; set; }

    }
}