using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class BarcodeSectionDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reference to an existing text-based or image field to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldSelector")]
        public virtual FieldSelector FieldSelector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
