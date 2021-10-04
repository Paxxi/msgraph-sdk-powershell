// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>threatAssessmentRequest</summary>
    public partial class MgThreatAssessmentRequest
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>threatCategory</summary>
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        /// <summary>threatAssessmentContentType</summary>
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet _createdBy;

        /// <summary>identitySet</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet CreatedBy { get => (this._createdBy = this._createdBy ?? new Microsoft.Graph.PowerShell.Users.Models.MgIdentitySet()); set => this._createdBy = value; }

        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private global::System.DateTime? _createdDateTime;

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        public global::System.DateTime? CreatedDateTime { get => this._createdDateTime; set => this._createdDateTime = value; }

        /// <summary>Backing field for <see cref="ExpectedAssessment" /> property.</summary>
        private string _expectedAssessment;

        /// <summary>threatExpectedAssessment</summary>
        public string ExpectedAssessment { get => this._expectedAssessment; set => this._expectedAssessment = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="RequestSource" /> property.</summary>
        private string _requestSource;

        /// <summary>threatAssessmentRequestSource</summary>
        public string RequestSource { get => this._requestSource; set => this._requestSource = value; }

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgThreatAssessmentResult[] _results;

        /// <summary>
        /// A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return
        /// this property unless you apply $expand on it.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgThreatAssessmentResult[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>threatAssessmentStatus</summary>
        public string Status { get => this._status; set => this._status = value; }

    }
}