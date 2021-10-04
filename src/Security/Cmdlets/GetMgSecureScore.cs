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
    [Cmdlet(VerbsCommon.Get, "MgSecuritySecureScore", DefaultParameterSetName = ListParameterSet)]
    [OutputType(typeof(MgAction))]
    [Description(@"Get securityActions from security")]
    public class GetMgSecuritySecureScore : GetCmdletBase<MgSecureScore>
    {
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = true, HelpMessage = "Id of secure score")]
        [Alias("Id")]
        public string SecureScoreId { get; set; }

        protected override bool IsSingle => !string.IsNullOrEmpty(SecureScoreId) || InputObject != null;

        protected override string Url => IsSingle
            ? $"https://graph.microsoft.com/beta/security/secureScores/{Uri.EscapeDataString(InputObject != null ? InputObject.Id : SecureScoreId)}"
            : "https://graph.microsoft.com/beta/security/secureScores/";
    }
}