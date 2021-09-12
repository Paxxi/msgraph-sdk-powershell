namespace Microsoft.Graph.PowerShell.Cmdlets
{

    /// <summary>Get ipSecurityProfiles from security</summary>
    /// <remarks>
    /// [OpenAPI] security_GetIpSecurityProfiles=>GET:"/security/ipSecurityProfiles/{ipSecurityProfileid}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Get, @"MgSecurityIPSecurityProfile_Get")]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIPSecurityProfile))]
    [global::Microsoft.Graph.PowerShell.Description(@"Get ipSecurityProfiles from security")]
    [global::Microsoft.Graph.PowerShell.Generated]
    [global::Microsoft.Graph.PowerShell.Profile("v1.0-beta")]
    public partial class GetMgSecurityIPSecurityProfile_Get : GetCmdletBase<Models.IMicrosoftGraphIPSecurityProfile>
    {
        /// <summary>Backing field for <see cref="IPSecurityProfileId" /> property.</summary>
        private string _iPSecurityProfileId;

        /// <summary>key: id of ipSecurityProfile</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "key: id of ipSecurityProfile")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"key: id of ipSecurityProfile",
        SerializedName = @"ipSecurityProfileid",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Path)]
        public string IPSecurityProfileId { get => this._iPSecurityProfileId; set => this._iPSecurityProfileId = value; }


        /// <summary>
        /// Intializes a new instance of the <see cref="GetMgSecurityIPSecurityProfile_Get" /> cmdlet class.
        /// </summary>
        public GetMgSecurityIPSecurityProfile_Get()
        {

        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected override async global::System.Threading.Tasks.Task ProcessRecordInternalAsync()
        {
            await this.Client.SecurityGetIPSecurityProfiles(IPSecurityProfileId, this.InvocationInformation.BoundParameters.ContainsKey("Property") ? Property : null /* arrayOf */, this.InvocationInformation.BoundParameters.ContainsKey("ExpandProperty") ? ExpandProperty : null /* arrayOf */, onOk, onDefault, this, Pipeline);
        }
    }
}