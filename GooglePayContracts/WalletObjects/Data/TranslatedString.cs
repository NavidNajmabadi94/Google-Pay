using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class TranslatedString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#translatedString"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Represents the BCP 47 language tag. Example values are "en-US", "en-GB", "de", or "de-
        /// AT".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The UTF-8 encoded translated string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
