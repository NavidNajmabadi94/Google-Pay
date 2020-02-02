using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class GiftCardClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated GiftCardClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GiftCardClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
