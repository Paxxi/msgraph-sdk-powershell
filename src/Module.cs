
using System;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell
{
    using static Extensions;
    using SignalDelegate = Func<string, CancellationToken, Func<EventArgs>, Task>;
    using EventListenerDelegate =
        Func<string, CancellationToken, Func<EventArgs>, Func<string, CancellationToken, Func<EventArgs>, Task>,
            InvocationInfo, string, Exception, Task>;

    /// <summary>A class that contains the module-common code and data.</summary>
    public partial class Module : IModule
    {
        private static Module _instance;

        public HttpClientHandler Handler = new HttpClientHandler();

        private readonly HttpPipeline _pipeline;

        private readonly HttpPipeline _pipelineWithProxy;

        public WebProxy WebProxy = new WebProxy();

        /// <summary>Creates the module instance.</summary>
        private Module()
        {
            GraphClient = new GraphClient();
            Handler.Proxy = WebProxy;
            _pipeline = new HttpPipeline(new HttpClientFactory(new HttpClient()));
            _pipelineWithProxy = new HttpPipeline(new HttpClientFactory(new HttpClient(Handler)));
        }

        /// <summary>The instance of the GraphClient API</summary>
        public GraphClient GraphClient { get; set; }

        /// <summary>the singleton of this module class</summary>
        public static Module Instance => _instance ?? (_instance = new Module());

        /// <summary>A delegate that gets called for each signalled event</summary>
        public EventListenerDelegate EventListener { get; set; }

        /// <summary>The Name of this module</summary>
        public string Name => @"Unofficial.Microsoft.Graph";

        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="parameterSetName">the cmdlet's parameterset name.</param>
        /// <returns>An instance of Microsoft.Graph.PowerShell.Runtime.HttpPipeline for the remote call.</returns>
        public HttpPipeline CreatePipeline(InvocationInfo invocationInfo, string parameterSetName = null)
        {
            HttpPipeline pipeline = null;
            BeforeCreatePipeline(invocationInfo, ref pipeline);
            pipeline = (pipeline ?? (Handler.UseProxy ? _pipelineWithProxy : _pipeline)).Clone();
            AfterCreatePipeline(invocationInfo, ref pipeline);
            return pipeline;
        }

        /// <summary>Initialization steps performed after the module is loaded.</summary>
        public void Init()
        {
            // called at module init time...
            CustomInit();
        }

        /// <param name="proxy">The HTTP Proxy to use.</param>
        /// <param name="proxyCredential">The HTTP Proxy Credentials</param>
        /// <param name="proxyUseDefaultCredentials">True if the proxy should use default credentials</param>
        public void SetProxyConfiguration(Uri proxy, PSCredential proxyCredential, bool proxyUseDefaultCredentials)
        {
            // set the proxy configuration
            WebProxy.Address = proxy;
            WebProxy.BypassProxyOnLocal = false;
            WebProxy.Credentials = proxyCredential?.GetNetworkCredential();
            WebProxy.UseDefaultCredentials = proxyUseDefaultCredentials;
            Handler.UseProxy = proxy != null;
        }

        /// <summary>Called to dispatch events to the common module listener</summary>
        /// <param name="id">The ID of the event </param>
        /// <param name="token">The cancellation token for the event </param>
        /// <param name="getEventData">A delegate to get the detailed event data</param>
        /// <param name="signal">The callback for the event dispatcher </param>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="parameterSetName">the cmdlet's parameterset name.</param>
        /// <param name="exception">the exception that is being thrown (if available)</param>
        /// <returns>
        ///     A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the event is completed.
        /// </returns>
        public async Task Signal(string id, CancellationToken token, Func<EventArgs> getEventData,
            SignalDelegate signal, InvocationInfo invocationInfo, string parameterSetName, Exception exception)
        {
            using (NoSynchronizationContext)
            {
                if (EventListener != null)
                    await EventListener.Invoke(id, token, getEventData, signal, invocationInfo, parameterSetName,
                        exception);
            }
        }

        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>
        partial void AfterCreatePipeline(InvocationInfo invocationInfo, ref HttpPipeline pipeline);

        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>
        partial void BeforeCreatePipeline(InvocationInfo invocationInfo, ref HttpPipeline pipeline);

        partial void CustomInit();
    }
}