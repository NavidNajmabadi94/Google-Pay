using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LoyaltyPoints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account holder's loyalty point balance, such as "500" or "$10.00". Recommended maximum length
        /// is 7 characters. This is a required field of `loyaltyPoints` and `secondaryLoyaltyPoints`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("balance")]
        public virtual LoyaltyPointsBalance Balance { get; set; }

        /// <summary>The loyalty points label, such as "Points". Recommended maximum length is 9 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Translated strings for the label. Recommended maximum length is 9 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedLabel")]
        public virtual LocalizedString LocalizedLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
