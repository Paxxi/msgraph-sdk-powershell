// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell
{
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Common;
    using Microsoft.Graph.PowerShell.Authentication.Extensions;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq.Expressions;
    using System.Management.Automation;
    public static class PSCmdletExtensions
    {
        /// <summary>
        /// Overrides OnDefault method in the generated cmdlets.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/></param>
        /// <param name="responseMessage">The HTTP response message from the service.</param>
        /// <param name="returnNow">Determines whether the caller should return after OverrideOnDefault is called, or not. </param>
        public static void OverrideOnDefault(this PSCmdlet cmdlet, global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow)
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                if (cmdlet.MyInvocation?.BoundParameters?.ContainsKey("PassThru") == true)
                {
                    cmdlet.WriteObject(true);
                }
                returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);
            }
        }

        /// <summary>
        /// Executes a PowerShell script.
        /// </summary>
        /// <typeparam name="T">The output type to return.</typeparam>
        /// <param name="cmdlet">The executing cmdlet.</param>
        /// <param name="contents">The PowerShell script to execute.</param>
        /// <returns>The result for the executed script.</returns>
        internal static List<T> ExecuteScript<T>(this PSCmdlet cmdlet, string contents)
        {
            List<T> output = new List<T>();

            using (PowerShell powershell = PowerShell.Create(RunspaceMode.CurrentRunspace))
            {
                powershell.AddScript(contents);
                Collection<T> result = powershell.Invoke<T>();

                if (cmdlet.SessionState != null)
                {
                    powershell.Streams.Error.ForEach(e => cmdlet.WriteError(e));
                    powershell.Streams.Verbose.ForEach(r => cmdlet.WriteVerbose(r.Message));
                    powershell.Streams.Warning.ForEach(r => cmdlet.WriteWarning(r.Message));
                }

                if (result != null && result.Count > 0)
                {
                    output.AddRange(result);
                }
            }

            return output;
        }

        /// <summary>
        /// Determines is a parameter has been provided by the user.
        /// </summary>
        /// <param name="cmdlet">The executing cmdlet.</param>
        /// <param name="parameterName">The name of the parameter to check.</param>
        /// <returns>True is the parameter was set by the user, otherwise false.</returns>
        public static bool IsParameterBound(this PSCmdlet cmdlet, string parameterName)
        {
            return cmdlet.MyInvocation?.BoundParameters.ContainsKey(parameterName) ?? false;
        }

        /// <summary>
        /// Determines is a parameter has been provided by the user.
        /// </summary>
        /// <typeparam name="TPSCmdlet">Cmdlet type.</typeparam>
        /// <typeparam name="TProp">Property type.</typeparam>
        /// <param name="cmdlet">The executing cmdlet.</param>
        /// <param name="propertySelector">The parameter to check</param>
        /// <returns>True is the parameter was set by the user, otherwise false.</returns>
        internal static bool IsParameterBound<TPSCmdlet, TProp>(this TPSCmdlet cmdlet, Expression<Func<TPSCmdlet, TProp>> propertySelector) where TPSCmdlet : PSCmdlet
        {
            var propName = ((MemberExpression)propertySelector.Body).Member.Name;
            return cmdlet.IsParameterBound(propName);
        }

        internal static void ThrowParameterError(this PSCmdlet cmdlet, string message, params object[] parameters)
        {
            cmdlet.ThrowError(message.FormatCurrentCulture(parameters), ErrorCategory.InvalidArgument);
        }

        internal static void ThrowParameterError(this PSCmdlet cmdlet, string parameterName)
        {
            cmdlet.ThrowError($"Must specify '{parameterName}'.", ErrorCategory.InvalidArgument);
        }

        internal static void ThrowError(this PSCmdlet cmdlet, string message, ErrorCategory errorCategory)
        {
            cmdlet.ThrowTerminatingError(
                new ErrorRecord(
                    new ArgumentException(message),
                    Guid.NewGuid().ToString(),
                    errorCategory,
                    null)
                );
        }

        /// <summary>
        /// Creates a <see cref="GraphSettings"/> with shared read access to the data store.
        /// </summary>
        /// <param name="cmdlet">The calling cmdlet.</param>
        /// <returns>A new instance of <see cref="GraphSettings"/>.</returns>
        internal static GraphSettings GetContextSettings(this PSCmdlet cmdlet)
        {
            return new GraphSettings(ProtectedFileProvider.CreateFileProvider(Constants.SettingFilePath, FileProtection.SharedRead));
        }

        /// <summary>
        /// Gets a resolved or unresolved path from PSPath.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/>.</param>
        /// <param name="filePath">The file path to get a provider path for.</param>
        /// <param name="isResolvedPath">Determines whether get a resolved or unresolved provider path.</param>
        /// <returns>The provider path from PSPath.</returns>
        internal static string GetProviderPath(this PSCmdlet cmdlet, string filePath, bool isResolvedPath)
        {
            string providerPath = null;
            ProviderInfo provider;
            try
            {
                var paths = new Collection<string>();
                if (isResolvedPath)
                {
                    paths = cmdlet.SessionState.Path.GetResolvedProviderPathFromPSPath(filePath, out provider);
                }
                else
                {
                    paths.Add(cmdlet.SessionState.Path.GetUnresolvedProviderPathFromPSPath(filePath, out provider, out _));
                }

                if (provider.Name != "FileSystem" || paths.Count == 0)
                {
                    cmdlet.ThrowTerminatingError(new ErrorRecord(new Exception($"Invalid path {filePath}."), string.Empty, ErrorCategory.InvalidArgument, filePath));
                }
                if (paths.Count > 1)
                {
                    cmdlet.ThrowTerminatingError(new ErrorRecord(new Exception("Multiple paths not allowed."), string.Empty, ErrorCategory.InvalidArgument, filePath));
                }
                providerPath = paths[0];
            }
            catch (Exception ex)
            {
                cmdlet.ThrowTerminatingError(new ErrorRecord(ex, string.Empty, ErrorCategory.InvalidArgument, filePath));
            }

            return providerPath;
        }

        /// <summary>
        /// Saves a stream to a file on disk.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/>.</param>
        /// <param name="response">The HTTP response from the service.</param>
        /// <param name="inputStream">The stream to write to file.</param>
        /// <param name="filePath">The path to write the file to. This should include the file name and extension.</param>
        /// <param name="cancellationToken">A cancellation token that will be used to cancel the operation by the user.</param>
        internal static void WriteToFile(this PSCmdlet cmdlet, HttpResponseMessage response, Stream inputStream, string filePath, CancellationToken cancellationToken)
        {
            using (var fileProvider = ProtectedFileProvider.CreateFileProvider(filePath, FileProtection.ExclusiveWrite, new DiskDataStore()))
            {
                string downloadUrl = response?.RequestMessage?.RequestUri.ToString();
                cmdlet.WriteToStream(inputStream, fileProvider.Stream, downloadUrl, cancellationToken);
            }
        }

        /// <summary>
        /// Writes an input stream to an output stream.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/>.</param>
        /// <param name="inputStream">The stream to write to an output stream.</param>
        /// <param name="outputStream">The stream to write the input stream to.</param>
        /// <param name="cancellationToken">A cancellation token that will be used to cancel the operation by the user.</param>
        private static void WriteToStream(this PSCmdlet cmdlet, Stream inputStream, Stream outputStream, string downloadUrl, CancellationToken cancellationToken)
        {
            Task copyTask = inputStream.CopyToAsync(outputStream);
            ProgressRecord record = new ProgressRecord(
                activityId: 0,
                activity: $"Downloading {downloadUrl ?? "file"}",
                statusDescription: $"{outputStream.Position} of {outputStream.Length} bytes downloaded.");
            try
            {
                do
                {
                    cmdlet.WriteProgress(GetProgress(record, outputStream));

                    Task.Delay(1000, cancellationToken).Wait(cancellationToken);
                } while (!copyTask.IsCompleted && !cancellationToken.IsCancellationRequested);

                if (copyTask.IsCompleted)
                {
                    cmdlet.WriteProgress(GetProgress(record, outputStream));
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        /// <summary>
        /// Calculates and updates the progress record of the provided stream.
        /// </summary>
        /// <param name="currentProgressRecord">The <see cref="ProgressRecord"/> to update.</param>
        /// <param name="stream">The stream to calculate its progress.</param>
        /// <returns>An updated <see cref="ProgressRecord"/>.</returns>
        private static ProgressRecord GetProgress(ProgressRecord currentProgressRecord, Stream stream)
        {
            currentProgressRecord.StatusDescription = $"{stream.Position} of {stream.Length} bytes downloaded.";
            currentProgressRecord.PercentComplete = (int)Math.Round((double)(100 * stream.Position) / stream.Length);
            return currentProgressRecord;
        }
    }
}
