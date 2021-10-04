// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>plannerTaskDetails</summary>
    public partial class MgPlannerTaskDetails
    {

        /// <summary>Backing field for <see cref="Checklist" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPlannerChecklistItems _checklist;

        /// <summary>plannerChecklistItems</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPlannerChecklistItems Checklist { get => (this._checklist = this._checklist ?? new Microsoft.Graph.PowerShell.Users.Models.MgPlannerChecklistItems()); set => this._checklist = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the task</summary>
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="PreviewType" /> property.</summary>
        private string _previewType;

        /// <summary>plannerPreviewType</summary>
        public string PreviewType { get => this._previewType; set => this._previewType = value; }

        /// <summary>Backing field for <see cref="References" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPlannerExternalReferences _references;

        /// <summary>plannerExternalReferences</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPlannerExternalReferences References { get => (this._references = this._references ?? new Microsoft.Graph.PowerShell.Users.Models.MgPlannerExternalReferences()); set => this._references = value; }

    }
}