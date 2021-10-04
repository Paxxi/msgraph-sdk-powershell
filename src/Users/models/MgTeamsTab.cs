// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>teamsTab</summary>
    public partial class MgTeamsTab
    {

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgTeamsTabConfiguration _configuration;

        /// <summary>teamsTabConfiguration</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgTeamsTabConfiguration Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Graph.PowerShell.Users.Models.MgTeamsTabConfiguration()); set => this._configuration = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Name of the tab.</summary>
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="MessageId" /> property.</summary>
        private string _messageId;

        public string MessageId { get => this._messageId; set => this._messageId = value; }

        /// <summary>Backing field for <see cref="SortOrderIndex" /> property.</summary>
        private string _sortOrderIndex;

        /// <summary>Index of the order used for sorting tabs.</summary>
        public string SortOrderIndex { get => this._sortOrderIndex; set => this._sortOrderIndex = value; }

        /// <summary>Backing field for <see cref="TeamsApp" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgTeamsApp _teamsApp;

        /// <summary>teamsApp</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgTeamsApp TeamsApp { get => (this._teamsApp = this._teamsApp ?? new Microsoft.Graph.PowerShell.Users.Models.MgTeamsApp()); set => this._teamsApp = value; }

        /// <summary>Backing field for <see cref="TeamsAppId" /> property.</summary>
        private string _teamsAppId;

        public string TeamsAppId { get => this._teamsAppId; set => this._teamsAppId = value; }

        /// <summary>Backing field for <see cref="WebUrl" /> property.</summary>
        private string _webUrl;

        /// <summary>Deep link URL of the tab instance. Read only.</summary>
        public string WebUrl { get => this._webUrl; set => this._webUrl = value; }

    }
}