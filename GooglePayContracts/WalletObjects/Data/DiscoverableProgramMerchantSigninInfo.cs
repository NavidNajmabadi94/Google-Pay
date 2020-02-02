using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    /// <summary>Information about the merchant hosted signin flow for a program.</summary>
    public class DiscoverableProgramMerchantSigninInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to direct the user to for the merchant's signin site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signinWebsite")]
        public virtual Uri SigninWebsite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
