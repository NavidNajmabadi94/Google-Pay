using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class CardRowOneItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to be displayed in the row. This item will be automatically centered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual TemplateItem Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
