// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>workbookChartAreaFormat</summary>
    public partial class MgWorkbookChartAreaFormat
    {

        /// <summary>Backing field for <see cref="Fill" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartFill _fill;

        /// <summary>workbookChartFill</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartFill Fill { get => (this._fill = this._fill ?? new Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartFill()); set => this._fill = value; }

        /// <summary>Backing field for <see cref="Font" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartFont _font;

        /// <summary>workbookChartFont</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartFont Font { get => (this._font = this._font ?? new Microsoft.Graph.PowerShell.Users.Models.MgWorkbookChartFont()); set => this._font = value; }

        /// <summary>Read-only.</summary>
        public string Id { get; set; }

    }
}