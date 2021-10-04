// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>rankedEmailAddress</summary>
    public partial class MgRankedEmailAddress
    {

        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private string _address;

        /// <summary>The email address.</summary>
        public string Address { get => this._address; set => this._address = value; }

        /// <summary>Backing field for <see cref="Rank" /> property.</summary>
        private double? _rank;

        /// <summary>
        /// The rank of the email address. A rank is used as a sort key, in relation to the other returned results. A higher rank
        /// value corresponds to a more relevant result. Relevance is determined by communication, collaboration, and business relationship
        /// signals.
        /// </summary>
        public double? Rank { get => this._rank; set => this._rank = value; }

    }
}