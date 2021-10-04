// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Cmdlets
{
    using System;
    using System.Management.Automation;

    /// <summary>Read-only. Nullable.</summary>
    /// <remarks>
    /// [OpenAPI] GetSettings=>GET:"/users/{user-id}/settings"
    /// </remarks>
    [Cmdlet(VerbsCommon.Get, "MgUserSetting", DefaultParameterSetName = ListParameterSet)]
    public partial class GetMgUserSetting : Microsoft.Graph.PowerShell.Runtime.Cmdlets.GetCmdletBase<Microsoft.Graph.PowerShell.Users.Models.MgUserSettings>
    {

        /// <summary>Expand related entities</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = InputObjectParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Expand related entities", ValueFromPipeline = false)]
        [AllowEmptyCollection]
        [Alias("Expand")]
        public override string[] ExpandProperty { get; set; }

        protected override bool IsSingle { get => !string.IsNullOrEmpty(UserId) || InputObject != null; }

        /// <summary>Select properties to be returned</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = InputObjectParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = ListParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = FilterParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [Parameter(ParameterSetName = SearchParameterSet, Mandatory = false, HelpMessage = "Select properties to be returned", ValueFromPipeline = false)]
        [AllowEmptyCollection]
        [Alias("Select")]
        public override string[] Property { get; set; }

        protected override string Url { get => IsSingle ? $"/users/{Uri.EscapeDataString(InputObject != null ? InputObject.Id : UserId)}/settings" : $"/users/{Uri.EscapeDataString(InputObject != null ? InputObject.Id : UserId)}/settings"; }

        /// <summary>key: id of user</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = true, HelpMessage = "key: id of user", ValueFromPipeline = false)]
        public string UserId { get; set; }

    }
}