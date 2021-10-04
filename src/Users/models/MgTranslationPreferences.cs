// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.6.2, generator: @autorest/powershell@3.0.0)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Graph.PowerShell.Users.Models
{

    /// <summary>translationPreferences</summary>
    public partial class MgTranslationPreferences
    {

        /// <summary>Backing field for <see cref="LanguageOverrides" /> property.</summary>
        private Microsoft.Graph.PowerShell.Users.Models.MgTranslationLanguageOverride[] _languageOverrides;

        /// <summary>Translation override behavior for languages, if any.Returned by default.</summary>
        public Microsoft.Graph.PowerShell.Users.Models.MgTranslationLanguageOverride[] LanguageOverrides { get => this._languageOverrides; set => this._languageOverrides = value; }

        /// <summary>Backing field for <see cref="TranslationBehavior" /> property.</summary>
        private string _translationBehavior;

        /// <summary>translationBehavior</summary>
        public string TranslationBehavior { get => this._translationBehavior; set => this._translationBehavior = value; }

        /// <summary>Backing field for <see cref="UntranslatedLanguages" /> property.</summary>
        private string[] _untranslatedLanguages;

        /// <summary>
        /// The list of languages the user does not need translated. This is computed from the authoringLanguages collection in regionalAndLanguageSettings,
        /// and the languageOverrides collection in translationPreferences. The list specifies neutral culture values that include
        /// the language code without any country or region association. For example, it would specify 'fr' for the neutral French
        /// culture, but not 'fr-FR' for the French culture in France. Returned by default. Read only.
        /// </summary>
        public string[] UntranslatedLanguages { get => this._untranslatedLanguages; set => this._untranslatedLanguages = value; }

    }
}