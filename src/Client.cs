// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6306, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Graph.PowerShell.Runtime;
using Microsoft.Graph.PowerShell.Security.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Microsoft.Graph.PowerShell
{
    using static Extensions;

    /// <summary>
    ///     Low-level API implementation for the Security service.
    /// </summary>
    public class Client : IClient
    {
        private static JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
        };
        public async Task Get<T>(string url,
            string[] select, string[] expand,
            Func<HttpResponseMessage,
                    Task<ODataResponse<T>>,
                    Task>
                onOk,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                var queryParameters = new List<string>();
                // construct URL
                var builder = new UriBuilder( url );

                if (null != select && select.Length > 0)
                {
                    queryParameters.Add("Select=" + Uri.EscapeDataString(string.Join(",", select)));
                }

                if (null != expand && expand.Length > 0)
                {
                    queryParameters.Add("expand=" + Uri.EscapeDataString(string.Join(",", expand)));
                }

                if (queryParameters.Count > 0)
                    builder.Query = string.Join("&", queryParameters);

                var uri = builder.Uri;

                await eventListener.Signal(Events.URLCreated, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                // generate request object
                var request =
                    new HttpRequestMessage(Method.Get, uri);
                await eventListener.Signal(Events.RequestCreated, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                await eventListener.Signal(Events.HeaderParametersAdded, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                // make the call
                HttpResponseMessage response = null;
                try
                {
                    await eventListener.Signal(Events.BeforeCall, request);
                    if (eventListener.Token.IsCancellationRequested) return;

                    response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Events.ResponseCreated, response);
                    if (eventListener.Token.IsCancellationRequested) return;

                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Events.BeforeResponseDispatch,
                                response);
                            if (eventListener.Token.IsCancellationRequested) return;

                            await onOk(response,
                                response.Content.ReadAsync<T>());
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Events.BeforeResponseDispatch,
                                response);
                            if (eventListener.Token.IsCancellationRequested) return;

                            await onDefault(response,
                                response.Content.ReadErrorAsync());
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Events.Finally, request, response);
                    response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        public async Task Get<T>(string url,
            string objectId,
            string[] select, string[] expand,
            Func<HttpResponseMessage,
                    Task<ODataResponse<T>>,
                    Task>
                onOk,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                var queryParameters = new List<string>();
                // construct URL
                var builder = new UriBuilder(
                    url
                    + Uri.EscapeDataString(objectId));

                if (null != select && select.Length > 0)
                {
                    queryParameters.Add("$select=" + Uri.EscapeDataString(string.Join(",", select)));
                }

                if (null != expand && expand.Length > 0)
                {
                    queryParameters.Add("$expand=" + Uri.EscapeDataString(string.Join(",", expand)));
                }

                if (queryParameters.Count > 0)
                    builder.Query = string.Join("&", queryParameters);

                var uri = builder.Uri;

                await eventListener.Signal(Events.URLCreated, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                // generate request object
                var request =
                    new HttpRequestMessage(Method.Get, uri);
                await eventListener.Signal(Events.RequestCreated, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                await eventListener.Signal(Events.HeaderParametersAdded, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                // make the call
                HttpResponseMessage response = null;
                try
                {
                    await eventListener.Signal(Events.BeforeCall, request);
                    if (eventListener.Token.IsCancellationRequested) return;

                    response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Events.ResponseCreated, response);
                    if (eventListener.Token.IsCancellationRequested) return;

                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Events.BeforeResponseDispatch,
                                response);
                            if (eventListener.Token.IsCancellationRequested) return;

                            await onOk(response,
                                response.Content.ReadAsync<T>());
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Events.BeforeResponseDispatch,
                                response);
                            if (eventListener.Token.IsCancellationRequested) return;

                            await onDefault(response,
                                response.Content.ReadErrorAsync());
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Events.Finally, request, response);
                    response?.Dispose();
                    request?.Dispose();
                }
            }
        }


        /// <summary>Get securityActions from security</summary>
        /// <param name="url">Full url to the endpoint to call</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
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
        public async Task List<T>(string url, int? top, int? skip, string search,
        string filter, bool? count, string[] orderby, string[] select, string[] expand,
        Func<HttpResponseMessage,
            Task<ODataCollection<T>>,
            Task> onOk,
        Func<HttpResponseMessage,
            Task<OdataError>, Task> onDefault,
        IEventListener eventListener,
        ISendAsync sender)
    {
        // Constant Parameters
        using (NoSynchronizationContext)
        {
            // construct URL
            var queryParameters = new List<string>();
            var builder = new UriBuilder(url);
            if (top.HasValue)
               queryParameters.Add("$top=" + Uri.EscapeDataString(top.ToString())); 
            if (skip.HasValue)
                queryParameters.Add("$skip=" + Uri.EscapeDataString(skip.ToString()));
            if (!string.IsNullOrEmpty(filter))
                queryParameters.Add("$filter=" + Uri.EscapeDataString(filter));
            if (count.HasValue)
                queryParameters.Add("$count=" + count.Value.ToString().ToLower());
            if (orderby != null && orderby.Length > 0)
                queryParameters.Add("$order=" + Uri.EscapeDataString(string.Join(",", orderby)));
            if (select != null && select.Length > 0)
                queryParameters.Add("$select=" + Uri.EscapeDataString(string.Join(",", select)));
            if (expand != null && expand.Length > 0)
                queryParameters.Add("$expand=" + Uri.EscapeDataString(string.Join(",", expand)));
            if (queryParameters.Count > 0)
                builder.Query = string.Join("&", queryParameters);

            var uri = builder.Uri;
            await eventListener.Signal(Events.URLCreated, uri);
            if (eventListener.Token.IsCancellationRequested) return;

            // generate request object
            var request =
                new HttpRequestMessage(Method.Get, uri);
            await eventListener.Signal(Events.RequestCreated, uri);
            if (eventListener.Token.IsCancellationRequested) return;

            await eventListener.Signal(Events.HeaderParametersAdded, uri);
            if (eventListener.Token.IsCancellationRequested) return;

            // make the call
            await ListCall(request, onOk, onDefault, eventListener, sender);
        }
    }
        //    /// <summary>Actual wire call for <see cref="SecurityListSecurityActions" /> method.</summary>
        //    /// <param name="request">the prepared HttpRequestMessage to send.</param>
        //    /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        //    /// <param name="onDefault">
        //    ///     a delegate that is called when the remote service returns default (any response code not handled
        //    ///     elsewhere).
        //    /// </param>
        //    /// <param name="eventListener">
        //    ///     an <see cref="Microsoft.Graph.PowerShell.Runtime.IEventListener" /> instance that will
        //    ///     receive events.
        //    /// </param>
        //    /// <param name="sender">
        //    ///     an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the
        //    ///     request.
        //    /// </param>
        //    /// <returns>
        //    ///     A <see cref="Task" /> that will be complete when handling of the response is
        //    ///     completed.
        //    /// </returns>
        public async Task ListCall<T>(
            HttpRequestMessage request,
            Func<HttpResponseMessage,
                Task<ODataCollection<T>>,
                Task> onOk,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender)
        {
            using (NoSynchronizationContext)
            {
                HttpResponseMessage response = null;
                try
                {
                    await eventListener.Signal(Events.BeforeCall, request);
                    if (eventListener.Token.IsCancellationRequested) return;

                    response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Events.ResponseCreated, response);
                    if (eventListener.Token.IsCancellationRequested) return;

                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            {
                                await eventListener.Signal(Events.BeforeResponseDispatch,
                                    response);
                                if (eventListener.Token.IsCancellationRequested) return;

                                await onOk(response,
                                    response.Content.ReadCollectionAsync<T>());
                                break;
                            }
                        default:
                            {
                                await eventListener.Signal(Events.BeforeResponseDispatch,
                                    response);
                                if (eventListener.Token.IsCancellationRequested) return;

                                await onDefault(response,
                                    response.Content.ReadErrorAsync());
                                break;
                            }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Events.Finally, request, response);
                    response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        //    /// <summary>Create new navigation property to securityActions for security</summary>
        //    /// <param name="body">New navigation property</param>
        //    /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        //    /// <param name="onDefault">
        //    ///     a delegate that is called when the remote service returns default (any response code not handled
        //    ///     elsewhere).
        //    /// </param>
        //    /// <param name="eventListener">
        //    ///     an <see cref="Microsoft.Graph.PowerShell.Runtime.IEventListener" /> instance that will
        //    ///     receive events.
        //    /// </param>
        //    /// <param name="sender">
        //    ///     an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the
        //    ///     request.
        //    /// </param>
        //    /// <returns>
        //    ///     A <see cref="Task" /> that will be complete when handling of the response is
        //    ///     completed.
        //    /// </returns>
        public async Task Create<T>(string url,
            T body,
            Func<HttpResponseMessage,
                    Task<ODataResponse<T>>,
                    Task>
                onCreated,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                // construct URL
                var uri = new Uri(url);

                await eventListener.Signal(Events.URLCreated, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                // generate request object
                var request =
                    new HttpRequestMessage(Method.Post,
                        uri);
                await eventListener.Signal(Events.RequestCreated, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                await eventListener.Signal(Events.HeaderParametersAdded, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                // set body content
                request.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _serializerSettings));
                request.Content.Headers.ContentType =
                    MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Events.BodyContentSet, uri);
                if (eventListener.Token.IsCancellationRequested) return;

                // make the call
                await CreateCall(request, onCreated, onDefault, eventListener, sender);
            }
        }

        //    /// <summary>Actual wire call for <see cref="SecurityCreateSecurityActions" /> method.</summary>
        //    /// <param name="request">the prepared HttpRequestMessage to send.</param>
        //    /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        //    /// <param name="onDefault">
        //    ///     a delegate that is called when the remote service returns default (any response code not handled
        //    ///     elsewhere).
        //    /// </param>
        //    /// <param name="eventListener">
        //    ///     an <see cref="Microsoft.Graph.PowerShell.Runtime.IEventListener" /> instance that will
        //    ///     receive events.
        //    /// </param>
        //    /// <param name="sender">
        //    ///     an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the
        //    ///     request.
        //    /// </param>
        //    /// <returns>
        //    ///     A <see cref="Task" /> that will be complete when handling of the response is
        //    ///     completed.
        //    /// </returns>
        internal async Task CreateCall<T>(
            HttpRequestMessage request,
            Func<HttpResponseMessage,
                    Task<ODataResponse<T>>,
                    Task>
                onCreated,
            Func<HttpResponseMessage,
                Task<OdataError>, Task> onDefault,
            IEventListener eventListener,
            ISendAsync sender)
        {
            using (NoSynchronizationContext)
            {
                HttpResponseMessage response = null;
                try
                {
                    await eventListener.Signal(Events.BeforeCall, request);
                    if (eventListener.Token.IsCancellationRequested) return;

                    response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Events.ResponseCreated, response);
                    if (eventListener.Token.IsCancellationRequested) return;

                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.Created:
                            {
                                await eventListener.Signal(Events.BeforeResponseDispatch,
                                    response);
                                if (eventListener.Token.IsCancellationRequested) return;

                                await onCreated(response,
                                    response.Content.ReadAsync<T>());
                                break;
                            }
                        default:
                            {
                                await eventListener.Signal(Events.BeforeResponseDispatch,
                                    response);
                                if (eventListener.Token.IsCancellationRequested) return;

                                await onDefault(response,
                                    response.Content.ReadErrorAsync());
                                break;
                            }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Events.Finally, request, response);
                    response?.Dispose();
                    request?.Dispose();
                }
            }
        }
    }
}