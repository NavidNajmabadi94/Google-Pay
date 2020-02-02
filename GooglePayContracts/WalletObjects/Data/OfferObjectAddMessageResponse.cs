using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class OfferObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated OfferObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual OfferObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
