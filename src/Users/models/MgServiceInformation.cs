// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>serviceInformation</summary>
    public partial class MgServiceInformation
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the cloud service (for example, Twitter, Instagram).</summary>
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="WebUrl" /> property.</summary>
        private string _webUrl;

        /// <summary>Contains the URL for the service being referenced.</summary>
        public string WebUrl { get => this._webUrl; set => this._webUrl = value; }

    }
}