using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class AppLinkData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional information about the partner app link. If included, the app link link module will be
        /// rendered on the valuable details on the android client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppLinkInfo")]
        public virtual AppLinkDataAppLinkInfo AndroidAppLinkInfo { get; set; }

        /// <summary>Optional information about the partner app link. If included, the app link link module will be
        /// rendered on the valuable details on the ios client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppLinkInfo")]
        public virtual AppLinkDataAppLinkInfo IosAppLinkInfo { get; set; }

        /// <summary>Optional information about the partner app link. If included, the app link link module will be
        /// rendered on the valuable details on the web client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webAppLinkInfo")]
        public virtual AppLinkDataAppLinkInfo WebAppLinkInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
