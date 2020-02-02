using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class SmartTapMerchantData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Available only to Smart Tap enabled partners.  Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationKeys")]
        public virtual System.Collections.Generic.IList<AuthenticationKey> AuthenticationKeys { get; set; }

        /// <summary>Available only to Smart Tap enabled partners.  Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapMerchantId")]
        public virtual System.Nullable<long> SmartTapMerchantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
