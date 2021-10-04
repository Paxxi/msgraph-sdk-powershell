using System;
using System.Management.Automation;
using Microsoft.Graph.PowerShell.Runtime;
using Microsoft.Graph.PowerShell.Runtime.Cmdlets;
using Microsoft.Graph.PowerShell.Security.Models;

namespace Microsoft.Graph.PowerShell.Security.Cmdlets
{
    /// <summary>Get securityActions from security</summary>
    /// <remarks>
    /// [OpenAPI] security_GetCloudAppSecurityProfiles=>GET:"/security/cloudAppSecurityProfiles/{cloudAppSecurityProfile-id}"
    /// </remarks>
    [Cmdlet(VerbsCommon.Get, "MgSecurityCloudAppSecurityProfile", DefaultParameterSetName = ListParameterSet)]
    [OutputType(typeof(MgAction))]
    [Description(@"Get cloudAppSecurityProfiles from security")]
    public class GetMgSecurityCloudAppSecurityProfile : GetCmdletBase<MicrosoftGraphCloudAppSecurityProfile>
    {
        [Parameter(ParameterSetName = IdParameterSet, Mandatory = true, HelpMessage = "Id of cloud app security profile")]
        [Alias("Id")]
        public string CloudAppSecurityProfileId { get; set; }

        protected override bool IsSingle => !string.IsNullOrEmpty(CloudAppSecurityProfileId) || InputObject != null;

        protected override string Url => IsSingle
            ? $"https://graph.microsoft.com/beta/security/cloudAppSecurityProfiles/{Uri.EscapeDataString(InputObject != null ? InputObject.Id : CloudAppSecurityProfileId)}"
            : "https://graph.microsoft.com/beta/security/cloudAppSecurityProfiles/";
    }
}