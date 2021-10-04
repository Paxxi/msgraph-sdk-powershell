// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>columnValidation</summary>
    public partial class MgColumnValidation
    {

        /// <summary>Backing field for <see cref="DefaultLanguage" /> property.</summary>
        private string _defaultLanguage;

        /// <summary>Default BCP 47 language tag for the description.</summary>
        public string DefaultLanguage { get => this._defaultLanguage; set => this._defaultLanguage = value; }

        /// <summary>Backing field for <see cref="Descriptions" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgDisplayNameLocalization[] _descriptions;

        /// <summary>
        /// Localized messages that explain what is needed for this column's value to be considered valid. User will be prompted with
        /// this message if validation fails.
        /// </summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgDisplayNameLocalization[] Descriptions { get => this._descriptions; set => this._descriptions = value; }

        /// <summary>Backing field for <see cref="Formula" /> property.</summary>
        private string _formula;

        /// <summary>
        /// The formula to validate column value. For examples, see Examples of common formulas in lists
        /// </summary>
        public string Formula { get => this._formula; set => this._formula = value; }

    }
}