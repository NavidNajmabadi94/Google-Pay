using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Barcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional text that will override the default text that shows under the barcode. This field is
        /// intended for a human readable equivalent of the barcode value, used when the barcode cannot be
        /// scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateText")]
        public virtual string AlternateText { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#barcode"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The render encoding for the barcode. When specified, barcode is rendered in the given encoding.
        /// Otherwise best known encoding is chosen by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderEncoding")]
        public virtual string RenderEncoding { get; set; }

        /// <summary>Optional text that will be shown when the barcode is hidden behind a click action. This happens in
        /// cases where a pass has Smart Tap enabled. If not specified, a default is chosen by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showCodeText")]
        public virtual LocalizedString ShowCodeText { get; set; }

        /// <summary>The type of barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The value encoded in the barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
