// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>phone</summary>
    public partial class MgPhone
    {

        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private string _number;

        /// <summary>The phone number.</summary>
        public string Number { get => this._number; set => this._number = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>phoneType</summary>
        public string Type { get => this._type; set => this._type = value; }

    }
}