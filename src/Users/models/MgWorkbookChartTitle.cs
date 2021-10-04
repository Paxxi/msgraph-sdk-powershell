// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>workbookChartTitle</summary>
    public partial class MgWorkbookChartTitle
    {

        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartTitleFormat _format;

        /// <summary>workbookChartTitleFormat</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartTitleFormat Format { get => (this._format = this._format ?? new Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartTitleFormat()); set => this._format = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

        /// <summary>Backing field for <see cref="Overlay" /> property.</summary>
        private bool? _overlay;

        /// <summary>Boolean value representing if the chart title will overlay the chart or not.</summary>
        public bool? Overlay { get => this._overlay; set => this._overlay = value; }

        /// <summary>Backing field for <see cref="Text" /> property.</summary>
        private string _text;

        /// <summary>Represents the title text of a chart.</summary>
        public string Text { get => this._text; set => this._text = value; }

        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private bool? _visible;

        /// <summary>A boolean value the represents the visibility of a chart title object.</summary>
        public bool? Visible { get => this._visible; set => this._visible = value; }

    }
}