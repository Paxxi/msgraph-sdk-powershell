// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>todo</summary>
    public partial class MgTodo
    {

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="Lists" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgTodoTaskList[] _lists;

        /// <summary>The task lists in the users mailbox.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgTodoTaskList[] Lists { get => this._lists; set => this._lists = value; }

    }
}