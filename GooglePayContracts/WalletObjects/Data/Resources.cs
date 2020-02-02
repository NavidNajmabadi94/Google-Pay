using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Resources : Google.Apis.Requests.IDirectResponseSchema
    {

        [Newtonsoft.Json.JsonPropertyAttribute("giftCardClasses")]
        public virtual System.Collections.Generic.IList<GiftCardClass> GiftCardClasses { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("giftCardObjects")]
        public virtual System.Collections.Generic.IList<GiftCardObject> GiftCardObjects { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyClasses")]
        public virtual System.Collections.Generic.IList<LoyaltyClass> LoyaltyClasses { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyObjects")]
        public virtual System.Collections.Generic.IList<LoyaltyObject> LoyaltyObjects { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("offerClasses")]
        public virtual System.Collections.Generic.IList<OfferClass> OfferClasses { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("offerObjects")]
        public virtual System.Collections.Generic.IList<OfferObject> OfferObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
