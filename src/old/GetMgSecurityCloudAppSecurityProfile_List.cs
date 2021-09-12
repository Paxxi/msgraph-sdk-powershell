// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Cmdlets
{
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;

    /// <summary>Get cloudAppSecurityProfiles from security</summary>
    /// <remarks>
    /// [OpenAPI] security_ListCloudAppSecurityProfiles=>GET:"/security/cloudAppSecurityProfiles"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Get, @"MgSecurityCloudAppSecurityProfile_List")]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudAppSecurityProfile))]
    [global::Microsoft.Graph.PowerShell.Description(@"Get cloudAppSecurityProfiles from security")]
    [global::Microsoft.Graph.PowerShell.Generated]
    [global::Microsoft.Graph.PowerShell.Profile("v1.0-beta")]
    public partial class GetMgSecurityCloudAppSecurityProfile_List : Microsoft.Graph.PowerShell.Cmdlets.Custom.ListCmdlet,
        Microsoft.Graph.PowerShell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Graph.PowerShell.Security Client => Microsoft.Graph.PowerShell.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _count;

        /// <summary>Include count of items</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Include count of items")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Include count of items",
        SerializedName = @"$count",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        private global::System.Management.Automation.SwitchParameter Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="ExpandProperty" /> property.</summary>
        private string[] _expandProperty;

        /// <summary>Expand related entities</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Expand related entities")]
        [global::System.Management.Automation.AllowEmptyCollection]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expand related entities",
        SerializedName = @"$expand",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("Expand")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        public string[] ExpandProperty { get => this._expandProperty; set => this._expandProperty = value; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private string _filter;

        /// <summary>Filter items by property values</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Filter items by property values")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Filter items by property values",
        SerializedName = @"$filter",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        public string Filter { get => this._filter; set => this._filter = value; }

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

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Graph.PowerShell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Graph.PowerShell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Microsoft.Graph.PowerShell.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Graph.PowerShell.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private string[] _property;

        /// <summary>Select properties to be returned</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Select properties to be returned")]
        [global::System.Management.Automation.AllowEmptyCollection]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select properties to be returned",
        SerializedName = @"$select",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("Select")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        public string[] Property { get => this._property; set => this._property = value; }

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

        /// <summary>Backing field for <see cref="Search" /> property.</summary>
        private string _search;

        /// <summary>Search items by search phrases</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Search items by search phrases")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Search items by search phrases",
        SerializedName = @"$search",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        public string Search { get => this._search; set => this._search = value; }

        /// <summary>Backing field for <see cref="Skip" /> property.</summary>
        private int _skip;

        /// <summary>Skip the first n items</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Skip the first n items")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Skip the first n items",
        SerializedName = @"$skip",
        PossibleTypes = new [] { typeof(int) })]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        public int Skip { get => this._skip; set => this._skip = value; }

        /// <summary>Backing field for <see cref="Sort" /> property.</summary>
        private string[] _sort;

        /// <summary>Order items by property values</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Order items by property values")]
        [global::System.Management.Automation.AllowEmptyCollection]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Order items by property values",
        SerializedName = @"$orderby",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("OrderBy")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        public string[] Sort { get => this._sort; set => this._sort = value; }

        /// <summary>Backing field for <see cref="Top" /> property.</summary>
        private int _top;

        /// <summary>Show only the first n items</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Show only the first n items")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Show only the first n items",
        SerializedName = @"$top",
        PossibleTypes = new [] { typeof(int) })]
        [global::System.Management.Automation.Alias("Limit")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Query)]
        public int Top { get => this._top; set => this._top = value; }

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
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.PowerShell.Models.ICollectionOfCloudAppSecurityProfile"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.ICollectionOfCloudAppSecurityProfile> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
          if (this.InvocationInformation?.BoundParameters != null){ InitializeCmdlet(ref this.__invocationInfo, ref this._top, ref this._count); }
        
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

        /// <summary>
        /// Intializes a new instance of the <see cref="GetMgSecurityCloudAppSecurityProfile_List" /> cmdlet class.
        /// </summary>
        public GetMgSecurityCloudAppSecurityProfile_List()
        {

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
                using( var asyncCommandRuntime = new Microsoft.Graph.PowerShell.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token);
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
                    await this.Client.SecurityListCloudAppSecurityProfiles(this.InvocationInformation.BoundParameters.ContainsKey("Top") ? Top : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?), this.FormatSearchValue(this.InvocationInformation.BoundParameters, Search), this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, this.InvocationInformation.BoundParameters.ContainsKey("Count") ? Count : default(global::System.Management.Automation.SwitchParameter?), this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null /* arrayOf */, this.InvocationInformation.BoundParameters.ContainsKey("Property") ? Property : null /* arrayOf */, this.InvocationInformation.BoundParameters.ContainsKey("ExpandProperty") ? ExpandProperty : null /* arrayOf */, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Graph.PowerShell.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  Top=this.InvocationInformation.BoundParameters.ContainsKey("Top") ? Top : default(int?),Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?),Search=this.FormatSearchValue(this.InvocationInformation.BoundParameters, Search),Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null,Count=this.InvocationInformation.BoundParameters.ContainsKey("Count") ? Count : default(global::System.Management.Automation.SwitchParameter?),Sort=this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null /* arrayOf */,Property=this.InvocationInformation.BoundParameters.ContainsKey("Property") ? Property : null /* arrayOf */,ExpandProperty=this.InvocationInformation.BoundParameters.ContainsKey("ExpandProperty") ? ExpandProperty : null /* arrayOf */})
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
                WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { Top=this.InvocationInformation.BoundParameters.ContainsKey("Top") ? Top : default(int?), Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?), Search=this.FormatSearchValue(this.InvocationInformation.BoundParameters, Search), Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, Count=this.InvocationInformation.BoundParameters.ContainsKey("Count") ? Count : default(global::System.Management.Automation.SwitchParameter?), Sort=this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null /* arrayOf */, Property=this.InvocationInformation.BoundParameters.ContainsKey("Property") ? Property : null /* arrayOf */, ExpandProperty=this.InvocationInformation.BoundParameters.ContainsKey("ExpandProperty") ? ExpandProperty : null /* arrayOf */ })
                {
                  ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                });
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.PowerShell.Models.ICollectionOfCloudAppSecurityProfile"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.ICollectionOfCloudAppSecurityProfile> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // response should be returning an array of some kind. +Pageable
                // pageable / value / @odata.nextLink
                var result = await response;

                OnBeforeWriteObject(this.InvocationInformation.BoundParameters, result?.AdditionalProperties);
                WriteObject(result.Value,true);
                if (result.OdataNextLink != null && this.ShouldIteratePages(this.InvocationInformation.BoundParameters, result.Value.Length))
                
                {
                    if (responseMessage.RequestMessage is System.Net.Http.HttpRequestMessage requestMessage )
                    {
                        requestMessage = requestMessage.Clone(new global::System.Uri( result.OdataNextLink ),Microsoft.Graph.PowerShell.Runtime.Method.Get );
                        await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.FollowingNextLink); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                        await this.Client.SecurityListCloudAppSecurityProfiles_Call(requestMessage, onOk, onDefault, this, Pipeline);
                    }
                }
            }
        }
    }
}