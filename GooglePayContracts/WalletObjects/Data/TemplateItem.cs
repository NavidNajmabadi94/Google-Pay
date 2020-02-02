using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class TemplateItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reference to a field to display. If both `firstValue` and `secondValue` are populated, they will
        /// both appear as one item with a slash between them. For example, values A and B would be shown as "A /
        /// B".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValue")]
        public virtual FieldSelector FirstValue { get; set; }

        /// <summary>A predefined item to display. Only one of `firstValue` or `predefinedItem` may be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedItem")]
        public virtual string PredefinedItem { get; set; }

        /// <summary>A reference to a field to display. This may only be populated if the `firstValue` field is
        /// populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondValue")]
        public virtual FieldSelector SecondValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
