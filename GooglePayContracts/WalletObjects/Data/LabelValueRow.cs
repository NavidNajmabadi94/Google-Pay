using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LabelValueRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of labels and values. These will be displayed in a singular column, one after the other, not
        /// in multiple columns, despite the field name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<LabelValue> Columns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
