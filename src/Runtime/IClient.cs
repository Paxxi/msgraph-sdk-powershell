using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell.Runtime
{
    public interface IClient
    {
        Task Get<T>(string url,
            string[] select, string[] expand,
            Func<HttpResponseMessage,
                    Task<T>,
                    Task>
                onOk,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender);

        Task Get<T>(string url,
            string objectId,
            string[] select, string[] expand,
            Func<HttpResponseMessage,
                    Task<T>,
                    Task>
                onOk,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender);

        /// <summary>Get securityActions from security</summary>
        /// <param name="url">Full url to the endpoint to call</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderBy">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">expand related entities</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">
        ///     a delegate that is called when the remote service returns default (any response code not handled
        ///     elsewhere).
        /// </param>
        /// <param name="eventListener">
        ///     an <see cref="IEventListener" /> instance that will
        ///     receive events.
        /// </param>
        /// <param name="sender">
        ///     an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the
        ///     request.
        /// </param>
        /// <returns>
        ///     A <see cref="Task" /> that will be complete when handling of the response is
        ///     completed.
        /// </returns>
        Task List<T>(string url, int? top, int? skip, string search,
            string filter, bool? count, string[] orderBy, string[] select, string[] expand,
            Func<HttpResponseMessage,
                Task<ODataCollection<T>>,
                Task> onOk,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender);

        Task ListCall<T>(
            HttpRequestMessage request,
            Func<HttpResponseMessage,
                Task<ODataCollection<T>>,
                Task> onOk,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender);
    }
}