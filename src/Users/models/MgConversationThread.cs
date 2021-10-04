// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>conversationThread</summary>
    public partial class MgConversationThread
    {

        /// <summary>Backing field for <see cref="CcRecipients" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgRecipient[] _ccRecipients;

        /// <summary>The Cc: recipients for the thread.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgRecipient[] CcRecipients { get => this._ccRecipients; set => this._ccRecipients = value; }

        /// <summary>Backing field for <see cref="HasAttachments" /> property.</summary>
        private bool? _hasAttachments;

        /// <summary>
        /// Indicates whether any of the posts within this thread has at least one attachment.
        /// </summary>
        public bool? HasAttachments { get => this._hasAttachments; set => this._hasAttachments = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="IsLocked" /> property.</summary>
        private bool? _isLocked;

        /// <summary>Indicates if the thread is locked.</summary>
        public bool? IsLocked { get => this._isLocked; set => this._isLocked = value; }

        /// <summary>Backing field for <see cref="LastDeliveredDateTime" /> property.</summary>
        private global::System.DateTime? _lastDeliveredDateTime;

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        public global::System.DateTime? LastDeliveredDateTime { get => this._lastDeliveredDateTime; set => this._lastDeliveredDateTime = value; }

        /// <summary>Backing field for <see cref="Posts" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgPost[] _posts;

        /// <summary>Read-only. Nullable.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgPost[] Posts { get => this._posts; set => this._posts = value; }

        /// <summary>Backing field for <see cref="Preview" /> property.</summary>
        private string _preview;

        /// <summary>A short summary from the body of the latest post in this conversation.</summary>
        public string Preview { get => this._preview; set => this._preview = value; }

        /// <summary>Backing field for <see cref="ToRecipients" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgRecipient[] _toRecipients;

        /// <summary>The To: recipients for the thread.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgRecipient[] ToRecipients { get => this._toRecipients; set => this._toRecipients = value; }

        /// <summary>Backing field for <see cref="Topic" /> property.</summary>
        private string _topic;

        /// <summary>
        /// The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.
        /// </summary>
        public string Topic { get => this._topic; set => this._topic = value; }

        /// <summary>Backing field for <see cref="UniqueSenders" /> property.</summary>
        private string[] _uniqueSenders;

        /// <summary>All the users that sent a message to this thread.</summary>
        public string[] UniqueSenders { get => this._uniqueSenders; set => this._uniqueSenders = value; }

    }
}