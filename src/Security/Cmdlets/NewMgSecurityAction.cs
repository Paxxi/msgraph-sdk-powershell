using System.Management.Automation;
using Microsoft.Graph.PowerShell.Runtime.Cmdlets;
using Microsoft.Graph.PowerShell.Security.Models;

namespace Microsoft.Graph.PowerShell.Security.Cmdlets
{
    /// <summary>Create new navigation property to securityActions for security</summary>
    /// <remarks>
    ///     [OpenAPI] security_CreateSecurityActions=>POST:"/security/securityActions"
    /// </remarks>
    [Cmdlet(VerbsCommon.New, @"MgSecurityAction", SupportsShouldProcess = true)]
    [OutputType(typeof(MgAction))]
    [Description(@"Create new navigation property to securityActions for security")]
    public class NewMgSecurityAction : NewCmdletBase<MgAction>
    {
        protected override string Url => "https://graph.microsoft.com/beta/security/securityActions";
    }
}