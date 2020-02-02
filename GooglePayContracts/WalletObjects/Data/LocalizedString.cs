using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LocalizedString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains the string to be displayed if no appropriate translation is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual TranslatedString DefaultValue { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#localizedString"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Contains the translations for the string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedValues")]
        public virtual System.Collections.Generic.IList<TranslatedString> TranslatedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
