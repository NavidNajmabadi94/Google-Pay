using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class GiftCardObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated GiftCardObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GiftCardObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
