// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Cmdlets
{
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;

    /// <summary>Update the navigation property securityActions in security</summary>
    /// <remarks>
    /// [OpenAPI] security_UpdateSecurityActions=>PATCH:"/security/securityActions/{securityAction-id}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"MgSecurityAction_UpdateViaIdentityExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(bool))]
    [global::Microsoft.Graph.PowerShell.Description(@"Update the navigation property securityActions in security")]
    [global::Microsoft.Graph.PowerShell.Generated]
    [global::Microsoft.Graph.PowerShell.Profile("v1.0-beta")]
    public partial class UpdateMgSecurityAction_UpdateViaIdentityExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Graph.PowerShell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Reason for invoking this action.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Reason for invoking this action.")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reason for invoking this action.",
        SerializedName = @"actionReason",
        PossibleTypes = new [] { typeof(string) })]
        public string ActionReason { get => BodyParameterBody.ActionReason ?? null; set => BodyParameterBody.ActionReason = value; }

        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Additional Parameters")]
        public global::System.Collections.Hashtable AdditionalProperties { get; set; } = new System.Collections.Hashtable();

        /// <summary>
        /// The Application ID of the calling application that submitted (POST) the action. The appId should be extracted from the
        /// auth token and not entered manually by the calling application.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Application ID of the calling application that submitted (POST) the action. The appId should be extracted from the auth token and not entered manually by the calling application.")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Application ID of the calling application that submitted (POST) the action. The appId should be extracted from the auth token and not entered manually by the calling application.",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        public string AppId { get => BodyParameterBody.AppId ?? null; set => BodyParameterBody.AppId = value; }

        /// <summary>
        /// Azure tenant ID of the entity to determine which tenant the entity belongs to (multi-tenancy support). The azureTenantId
        /// should be extracted from the auth token and not entered manually by the calling application.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Azure tenant ID of the entity to determine which tenant the entity belongs to (multi-tenancy support). The azureTenantId should be extracted from the auth token and not entered manually by the calling application.")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure tenant ID of the entity to determine which tenant the entity belongs to (multi-tenancy support). The azureTenantId should be extracted from the auth token and not entered manually by the calling application.",
        SerializedName = @"azureTenantId",
        PossibleTypes = new [] { typeof(string) })]
        public string AzureTenantId { get => BodyParameterBody.AzureTenantId ?? null; set => BodyParameterBody.AzureTenantId = value; }

        /// <summary>Backing field for <see cref="BodyParameterBody" /> property.</summary>
        private Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAction _bodyParameterBody= new Microsoft.Graph.PowerShell.Models.MicrosoftGraphSecurityAction();

        /// <summary>securityAction</summary>
        private Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAction BodyParameterBody { get => this._bodyParameterBody; set => this._bodyParameterBody = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Graph.PowerShell.Security Client => Microsoft.Graph.PowerShell.Module.Instance.ClientAPI;

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"clientContext",
        PossibleTypes = new [] { typeof(string) })]
        public string ClientContext { get => BodyParameterBody.ClientContext ?? null; set => BodyParameterBody.ClientContext = value; }

        /// <summary>
        /// Timestamp when the action was completed. The Timestamp type represents date and time information using ISO 8601 format
        /// and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Timestamp when the action was completed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp when the action was completed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
        SerializedName = @"completedDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime CompletedDateTime { get => BodyParameterBody.CompletedDateTime ?? default(global::System.DateTime); set => BodyParameterBody.CompletedDateTime = value; }

        /// <summary>
        /// Timestamp when the action is created. The Timestamp type represents date and time information using ISO 8601 format and
        /// is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Timestamp when the action is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp when the action is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
        SerializedName = @"createdDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime CreatedDateTime { get => BodyParameterBody.CreatedDateTime ?? default(global::System.DateTime); set => BodyParameterBody.CreatedDateTime = value; }

        /// <summary>resultInfo</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "resultInfo")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"resultInfo",
        SerializedName = @"errorInfo",
        PossibleTypes = new [] { typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphResultInfo) })]
        public Microsoft.Graph.PowerShell.Models.IMicrosoftGraphResultInfo ErrorInfo { get => BodyParameterBody.ErrorInfo ?? null /* object */; set => BodyParameterBody.ErrorInfo = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public Microsoft.Graph.PowerShell.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public Microsoft.Graph.PowerShell.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Read-only.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Read-only.")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Read-only.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        public string Id { get => BodyParameterBody.Id ?? null; set => BodyParameterBody.Id = value; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Microsoft.Graph.PowerShell.Models.ISecurityIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Path)]
        public Microsoft.Graph.PowerShell.Models.ISecurityIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// Timestamp when this action was last updated. The Timestamp type represents date and time information using ISO 8601 format
        /// and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Timestamp when this action was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp when this action was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
        SerializedName = @"lastActionDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime LastActionDateTime { get => BodyParameterBody.LastActionDateTime ?? default(global::System.DateTime); set => BodyParameterBody.LastActionDateTime = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Graph.PowerShell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Graph.PowerShell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Action name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Action name.")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Action name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string Name { get => BodyParameterBody.Name ?? null; set => BodyParameterBody.Name = value; }

        /// <summary>
        /// Collection of parameters (key-value pairs) necessary to invoke the action, e.g. URL or fileHash to block, etc.). Required
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Collection of parameters (key-value pairs) necessary to invoke the action, e.g. URL or fileHash to block, etc.). Required")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of parameters (key-value pairs) necessary to invoke the action, e.g. URL or fileHash to block, etc.). Required",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair) })]
        public Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[] Parameters { get => BodyParameterBody.Parameters ?? null /* arrayOf */; set => BodyParameterBody.Parameters = value; }

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Graph.PowerShell.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Graph.PowerShell.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Collection of securityActionState to keep the history of an action.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Collection of securityActionState to keep the history of an action.")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of securityActionState to keep the history of an action.",
        SerializedName = @"states",
        PossibleTypes = new [] { typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityActionState) })]
        public Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityActionState[] States { get => BodyParameterBody.States ?? null /* arrayOf */; set => BodyParameterBody.States = value; }

        /// <summary>operationStatus</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "operationStatus")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"operationStatus",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        public string Status { get => BodyParameterBody.Status ?? null; set => BodyParameterBody.Status = value; }

        /// <summary>
        /// The user principal name of the signed-in user that submitted (POST) the action. The user should be extracted from the
        /// auth token and not entered manually by the calling application.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The user principal name of the signed-in user that submitted (POST) the action. The user should be extracted from the auth token and not entered manually by the calling application.")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user principal name of the signed-in user that submitted (POST) the action. The user should be extracted from the auth token and not entered manually by the calling application.",
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        public string User { get => BodyParameterBody.User ?? null; set => BodyParameterBody.User = value; }

        /// <summary>securityVendorInformation</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "securityVendorInformation")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"securityVendorInformation",
        SerializedName = @"vendorInformation",
        PossibleTypes = new [] { typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityVendorInformation) })]
        public Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityVendorInformation VendorInformation { get => BodyParameterBody.VendorInformation ?? null /* object */; set => BodyParameterBody.VendorInformation = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="IOdataError" /> from the remote
        /// call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<IOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow) => this.OverrideOnDefault(responseMessage,ref returnNow);

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<IOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnNoContent</c> will be called before the regular onNoContent has been processed, allowing customization of
        /// what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onNoContent method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnNoContent(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Graph.PowerShell.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Graph.PowerShell.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Graph.PowerShell.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Graph.PowerShell.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Graph.PowerShell.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Graph.PowerShell.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Graph.PowerShell.Runtime.EventData ), InvocationInformation, this.ParameterSetName, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'SecurityUpdateSecurityActions' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Graph.PowerShell.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                Microsoft.Graph.PowerShell.Runtime.DictionaryExtensions.HashTableToDictionary<global::System.Object>(AdditionalProperties,BodyParameterBody.AdditionalProperties);
                await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Graph.PowerShell.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Graph.PowerShell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Graph.PowerShell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // try to call with PATH parameters from Input Object
                    if (null == InputObject.SecurityActionId)
                    {
                        ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.SecurityActionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                    }
                    await this.Client.SecurityUpdateSecurityActions(InputObject.SecurityActionId ?? null, BodyParameterBody, onNoContent, onDefault, this, Pipeline);
                    await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Graph.PowerShell.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  body=BodyParameterBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="UpdateMgSecurityAction_UpdateViaIdentityExpanded" /> cmdlet class.
        /// </summary>
        public UpdateMgSecurityAction_UpdateViaIdentityExpanded()
        {

        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="IOdataError" /> from the remote
        /// call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<IOdataError> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                // Unrecognized Response. Create an error record based on what we have.
                var ex = new Microsoft.Graph.PowerShell.Runtime.RestException<IOdataError>(responseMessage, await response);
                WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { body=BodyParameterBody })
                {
                  ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                });
            }
        }

        /// <summary>a delegate that is called when the remote service returns 204 (NoContent).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onNoContent(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnNoContent(responseMessage, ref _returnNow);
                // if overrideOnNoContent has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onNoContent - response for 204 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}