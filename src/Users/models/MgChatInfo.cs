// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>chatInfo</summary>
    public partial class MgChatInfo
    {

        /// <summary>Backing field for <see cref="MessageId" /> property.</summary>
        private string _messageId;

        /// <summary>The unique identifier for a message in a Microsoft Teams channel.</summary>
        public string MessageId { get => this._messageId; set => this._messageId = value; }

        /// <summary>Backing field for <see cref="ReplyChainMessageId" /> property.</summary>
        private string _replyChainMessageId;

        /// <summary>The ID of the reply message.</summary>
        public string ReplyChainMessageId { get => this._replyChainMessageId; set => this._replyChainMessageId = value; }

        /// <summary>Backing field for <see cref="ThreadId" /> property.</summary>
        private string _threadId;

        /// <summary>The unique identifier for a thread in Microsoft Teams.</summary>
        public string ThreadId { get => this._threadId; set => this._threadId = value; }

    }
}