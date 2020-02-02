using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Issuer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Issuer contact information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactInfo")]
        public virtual IssuerContactInfo ContactInfo { get; set; }

        /// <summary>URL for the issuer's home page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUrl")]
        public virtual string HomepageUrl { get; set; }

        /// <summary>The unique identifier for an issuer account. This is automatically generated when the issuer is
        /// inserted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerId")]
        public virtual System.Nullable<long> IssuerId { get; set; }

        /// <summary>The account name of the issuer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Available only to Smart Tap enabled partners.  Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapMerchantData")]
        public virtual SmartTapMerchantData SmartTapMerchantData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
