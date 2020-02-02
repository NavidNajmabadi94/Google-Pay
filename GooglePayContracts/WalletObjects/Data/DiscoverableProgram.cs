using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{    /// <summary>Information about how a class may be discovered and instantiated from within the Android Pay app. This
     /// is done by searching for a loyalty or gift card program and scanning or manually entering.</summary>
    public class DiscoverableProgram : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the ability to signin and add a valuable for this program through a merchant
        /// site. Used when MERCHANT_HOSTED_SIGNIN is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantSigninInfo")]
        public virtual DiscoverableProgramMerchantSigninInfo MerchantSigninInfo { get; set; }

        /// <summary>Information about the ability to signup and add a valuable for this program through a merchant
        /// site. Used when MERCHANT_HOSTED_SIGNUP is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantSignupInfo")]
        public virtual DiscoverableProgramMerchantSignupInfo MerchantSignupInfo { get; set; }

        /// <summary>Visibility state of the discoverable program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
