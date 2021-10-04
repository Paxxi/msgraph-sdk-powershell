// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>threatAssessmentResult</summary>
    public partial class MgThreatAssessmentResult
    {

        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private global::System.DateTime? _createdDateTime;

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        public global::System.DateTime? CreatedDateTime { get => this._createdDateTime; set => this._createdDateTime = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The result message for each threat assessment.</summary>
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="ResultType" /> property.</summary>
        private string _resultType;

        /// <summary>threatAssessmentResultType</summary>
        public string ResultType { get => this._resultType; set => this._resultType = value; }

    }
}