// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>resourceVisualization</summary>
    public partial class MgResourceVisualization
    {

        /// <summary>Backing field for <see cref="ContainerDisplayName" /> property.</summary>
        private string _containerDisplayName;

        /// <summary>
        /// A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying
        /// the owner of the OneDrive storing the item.
        /// </summary>
        public string ContainerDisplayName { get => this._containerDisplayName; set => this._containerDisplayName = value; }

        /// <summary>Backing field for <see cref="ContainerType" /> property.</summary>
        private string _containerType;

        /// <summary>
        /// Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
        /// </summary>
        public string ContainerType { get => this._containerType; set => this._containerType = value; }

        /// <summary>Backing field for <see cref="ContainerWebUrl" /> property.</summary>
        private string _containerWebUrl;

        /// <summary>A path leading to the folder in which the item is stored.</summary>
        public string ContainerWebUrl { get => this._containerWebUrl; set => this._containerWebUrl = value; }

        /// <summary>Backing field for <see cref="MediaType" /> property.</summary>
        private string _mediaType;

        /// <summary>
        /// The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types.
        /// Note that not all Media Mime Types are supported.
        /// </summary>
        public string MediaType { get => this._mediaType; set => this._mediaType = value; }

        /// <summary>Backing field for <see cref="PreviewImageUrl" /> property.</summary>
        private string _previewImageUrl;

        /// <summary>A URL leading to the preview image for the item.</summary>
        public string PreviewImageUrl { get => this._previewImageUrl; set => this._previewImageUrl = value; }

        /// <summary>Backing field for <see cref="PreviewText" /> property.</summary>
        private string _previewText;

        /// <summary>A preview text for the item.</summary>
        public string PreviewText { get => this._previewText; set => this._previewText = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>The item's title text.</summary>
        public string Title { get => this._title; set => this._title = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported
        /// types.
        /// </summary>
        public string Type { get => this._type; set => this._type = value; }

    }
}