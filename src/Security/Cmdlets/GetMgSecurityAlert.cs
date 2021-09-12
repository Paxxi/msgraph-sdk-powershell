using System;
using System.Management.Automation;
using Microsoft.Graph.PowerShell.Runtime;
using Microsoft.Graph.PowerShell.Security.Models;

namespace Microsoft.Graph.PowerShell.Security.Cmdlets
{
    /// <summary>Read-only. Nullable.</summary>
    /// <remarks>
    ///     [OpenAPI] security_GetAlerts=>GET:"/security/alerts/{alert-id}"
    /// </remarks>
    [Cmdlet(VerbsCommon.Get, @"MgSecurityAlert")]
    [OutputType(typeof(MgAlert))]
    public class GetMgSecurityAlert : GetCmdletBase<MgAlert>
    {
        /// <summary>key: id of alert</summary>
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = true, HelpMessage = "Id of alert")]
        [Alias("Id")]
        public string AlertId { get; set; }

        protected override bool IsSingle => !string.IsNullOrEmpty(AlertId) || InputObject != null;

        protected override string Url => IsSingle
            ? $"https://graph.microsoft.com/beta/security/alerts/{Uri.EscapeDataString(InputObject != null ? InputObject.Id : AlertId)}"
            : "https://graph.microsoft.com/beta/security/alerts/";
    }
}