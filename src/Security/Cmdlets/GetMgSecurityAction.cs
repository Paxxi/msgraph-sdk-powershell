// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Management.Automation;
using Microsoft.Graph.PowerShell.Runtime;
using Microsoft.Graph.PowerShell.Runtime.Cmdlets;
using Microsoft.Graph.PowerShell.Security.Models;

namespace Microsoft.Graph.PowerShell.Security.Cmdlets
{
    /// <summary>Get securityActions from security</summary>
    /// <remarks>
    ///     [OpenAPI] security_GetSecurityActions=>GET:"/security/securityActions/{securityAction-id}"
    /// </remarks>
    [Cmdlet(VerbsCommon.Get, @"MgSecurityAction", DefaultParameterSetName = ListParameterSet)]
    [OutputType(typeof(MgAction))]
    [Description(@"Get securityActions from security")]
    public class GetMgSecurityAction : GetCmdletBase<MgAction>
    {
        /// <summary>key: id of securityAction</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = true, HelpMessage = "Id of the security action")]
        [Alias("Id")]
        public string SecurityActionId { get; set; }


        protected override bool IsSingle => !string.IsNullOrEmpty(SecurityActionId) || InputObject != null;

        protected override string Url => IsSingle
            ? $"https://graph.microsoft.com/beta/security/securityActions/{Uri.EscapeDataString(InputObject != null ? InputObject.Id : SecurityActionId)}"
            : "https://graph.microsoft.com/beta/security/securityActions/";
    }
}