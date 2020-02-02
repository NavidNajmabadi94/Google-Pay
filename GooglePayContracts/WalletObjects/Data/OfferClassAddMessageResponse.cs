using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class OfferClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated OfferClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual OfferClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
