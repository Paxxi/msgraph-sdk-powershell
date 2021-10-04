// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>plannerPlan</summary>
    public partial class MgPlannerPlan
    {

        /// <summary>Backing field for <see cref="Buckets" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPlannerBucket[] _buckets;

        /// <summary>Collection of buckets in the plan. Read-only. Nullable.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPlannerBucket[] Buckets { get => this._buckets; set => this._buckets = value; }

        /// <summary>Backing field for <see cref="Container" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanContainer _container;

        /// <summary>plannerPlanContainer</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanContainer Container { get => (this._container = this._container ?? new Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanContainer()); set => this._container = value; }

        /// <summary>Backing field for <see cref="Contexts" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanContextCollection _contexts;

        /// <summary>plannerPlanContextCollection</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanContextCollection Contexts { get => (this._contexts = this._contexts ?? new Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanContextCollection()); set => this._contexts = value; }

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet _createdBy;

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get => (this._createdBy = this._createdBy ?? new Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet()); set => this._createdBy = value; }

        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private global::System.DateTime? _createdDateTime;

        /// <summary>
        /// Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO
        /// 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? CreatedDateTime { get => this._createdDateTime; set => this._createdDateTime = value; }

        /// <summary>Backing field for <see cref="Details" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanDetails _details;

        /// <summary>plannerPlanDetails</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanDetails Details { get => (this._details = this._details ?? new Microsoft.Graph.PowerShell.Users.Models.MgPlannerPlanDetails()); set => this._details = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private string _owner;

        /// <summary>
        /// ID of the Group that owns the plan. A valid group must exist before this field can be set. After it is set, this property
        /// can’t be updated.
        /// </summary>
        public string Owner { get => this._owner; set => this._owner = value; }

        /// <summary>Backing field for <see cref="Tasks" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPlannerTask[] _tasks;

        /// <summary>Collection of tasks in the plan. Read-only. Nullable.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPlannerTask[] Tasks { get => this._tasks; set => this._tasks = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>Required. Title of the plan.</summary>
        public string Title { get => this._title; set => this._title = value; }

    }
}