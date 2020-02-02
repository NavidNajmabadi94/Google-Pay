using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class DetailsItemInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to be displayed in the details list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual TemplateItem Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
