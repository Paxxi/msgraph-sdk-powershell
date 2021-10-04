// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>plannerBucketTaskBoardTaskFormat</summary>
    public partial class MgPlannerBucketTaskBoardTaskFormat
    {

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="OrderHint" /> property.</summary>
        private string _orderHint;

        /// <summary>
        /// Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
        /// </summary>
        public string OrderHint { get => this._orderHint; set => this._orderHint = value; }

    }
}