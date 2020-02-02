using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LoyaltyClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated LoyaltyClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual LoyaltyClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
