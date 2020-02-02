using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LoyaltyObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated LoyaltyObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual LoyaltyObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
