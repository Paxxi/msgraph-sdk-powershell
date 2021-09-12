// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Management.Automation;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell.Security.Cmdlets
{
    /// <summary>Get securityActions from security</summary>
    /// <remarks>
    /// [OpenAPI] security_GetSecurityActions=>GET:"/security/securityActions/{securityAction-id}"
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Get, @"MgSecurityAction")]
    [System.Management.Automation.OutputType(typeof(Models.Action))]
    [Description(@"Get securityActions from security")]
    public class GetMgSecurityAction : GetCmdletBase<Models.Action>
    {
        /// <summary>key: id of securityAction</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "key: id of securityAction")]
        [Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"key: id of securityAction",
        SerializedName = @"securityAction-id",
        PossibleTypes = new[] { typeof(string) })]
        [Category(ParameterCategory.Path)]
        public string SecurityActionId { get; set; }

        /// <summary>Identity Parameter</summary>
        [Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [Category(ParameterCategory.Path)]
        public Models.SecurityIdentity InputObject { get; set; }

        protected override bool IsSingle => !string.IsNullOrEmpty(SecurityActionId) || InputObject != null;

        protected override string Url => IsSingle ?
            $"https://graph.microsoft.com/beta/security/securityActions/{Uri.EscapeDataString(InputObject != null ? InputObject.SecurityActionId : SecurityActionId)}"
            : "https://graph.microsoft.com/beta/security/securityActions/";

    }
}