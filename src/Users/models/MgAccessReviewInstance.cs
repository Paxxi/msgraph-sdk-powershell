// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>accessReviewInstance</summary>
    public partial class MgAccessReviewInstance
    {

        /// <summary>Backing field for <see cref="Decisions" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewInstanceDecisionItem[] _decisions;

        /// <summary>
        /// Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet
        /// reviewed.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewInstanceDecisionItem[] Decisions { get => this._decisions; set => this._decisions = value; }

        /// <summary>Backing field for <see cref="Definition" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewScheduleDefinition _definition;

        /// <summary>accessReviewScheduleDefinition</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewScheduleDefinition Definition { get => (this._definition = this._definition ?? new Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewScheduleDefinition()); set => this._definition = value; }

        /// <summary>Backing field for <see cref="EndDateTime" /> property.</summary>
        private global::System.DateTime? _endDateTime;

        /// <summary>
        /// DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO
        /// 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select.
        /// Read-only.
        /// </summary>
        public global::System.DateTime? EndDateTime { get => this._endDateTime; set => this._endDateTime = value; }

        /// <summary>Backing field for <see cref="FallbackReviewers" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewReviewerScope[] _fallbackReviewers;

        public Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewReviewerScope[] FallbackReviewers { get => this._fallbackReviewers; set => this._fallbackReviewers = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="Reviewers" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewReviewerScope[] _reviewers;

        public Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewReviewerScope[] Reviewers { get => this._reviewers; set => this._reviewers = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewScope _scope;

        /// <summary>accessReviewScope</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewScope Scope { get => (this._scope = this._scope ?? new Microsoft.Graph.PowerShell.Users.Models.MgAccessReviewScope()); set => this._scope = value; }

        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private global::System.DateTime? _startDateTime;

        /// <summary>
        /// DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and
        /// time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// Supports $select. Read-only.
        /// </summary>
        public global::System.DateTime? StartDateTime { get => this._startDateTime; set => this._startDateTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>
        /// Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing,
        /// Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.
        /// </summary>
        public string Status { get => this._status; set => this._status = value; }

    }
}