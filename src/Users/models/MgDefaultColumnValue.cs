// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>defaultColumnValue</summary>
    public partial class MgDefaultColumnValue
    {

        /// <summary>Backing field for <see cref="Formula" /> property.</summary>
        private string _formula;

        /// <summary>The formula used to compute the default value for this column.</summary>
        public string Formula { get => this._formula; set => this._formula = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The direct value to use as the default value for this column.</summary>
        public string Value { get => this._value; set => this._value = value; }

    }
}