// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>outlookTaskFolder</summary>
    public partial class MgOutlookTaskFolder
    {

        /// <summary>Backing field for <see cref="ChangeKey" /> property.</summary>
        private string _changeKey;

        /// <summary>The version of the task folder.</summary>
        public string ChangeKey { get => this._changeKey; set => this._changeKey = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="IsDefaultFolder" /> property.</summary>
        private bool? _isDefaultFolder;

        /// <summary>True if the folder is the default task folder.</summary>
        public bool? IsDefaultFolder { get => this._isDefaultFolder; set => this._isDefaultFolder = value; }

        /// <summary>Backing field for <see cref="MultiValueExtendedProperties" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgMultiValueLegacyExtendedProperty[] _multiValueExtendedProperties;

        /// <summary>
        /// The collection of multi-value extended properties defined for the task folder. Read-only. Nullable.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties { get => this._multiValueExtendedProperties; set => this._multiValueExtendedProperties = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the task folder.</summary>
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ParentGroupKey" /> property.</summary>
        private string _parentGroupKey;

        /// <summary>The unique GUID identifier for the task folder's parent group.</summary>
        public string ParentGroupKey { get => this._parentGroupKey; set => this._parentGroupKey = value; }

        /// <summary>Backing field for <see cref="SingleValueExtendedProperties" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgSingleValueLegacyExtendedProperty[] _singleValueExtendedProperties;

        /// <summary>
        /// The collection of single-value extended properties defined for the task folder. Read-only. Nullable.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties { get => this._singleValueExtendedProperties; set => this._singleValueExtendedProperties = value; }

        /// <summary>Backing field for <see cref="Tasks" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgOutlookTask[] _tasks;

        /// <summary>The tasks in this task folder. Read-only. Nullable.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgOutlookTask[] Tasks { get => this._tasks; set => this._tasks = value; }

    }
}