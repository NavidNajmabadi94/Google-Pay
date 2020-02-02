using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    /// <summary>A pair of text strings to be displayed in the details view. Note we no longer display
    /// LabelValue/LabelValueRow as a table, instead a list of items.</summary>
    public class LabelValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label for a specific row and column. Recommended maximum is 15 characters for a two-column
        /// layout and 30 characters for a one-column layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Translated strings for the label. Recommended maximum is 15 characters for a two-column layout and
        /// 30 characters for a one-column layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedLabel")]
        public virtual LocalizedString LocalizedLabel { get; set; }

        /// <summary>Translated strings for the value. Recommended maximum is 15 characters for a two-column layout and
        /// 30 characters for a one-column layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedValue")]
        public virtual LocalizedString LocalizedValue { get; set; }

        /// <summary>The value for a specific row and column. Recommended maximum is 15 characters for a two-column
        /// layout and 30 characters for a one-column layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
