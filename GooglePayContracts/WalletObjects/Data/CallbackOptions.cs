using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class CallbackOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL for the merchant endpoint that would be called to request updates. The URL should be hosted on
        /// HTTPS and robots.txt should allow the URL path to be accessible by UserAgent:Google-Valuables.
        ///
        /// Please contact Google support before using this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateRequestUrl")]
        public virtual string UpdateRequestUrl { get; set; }

        /// <summary>The HTTPS url configured by the merchant. The URL should be hosted on HTTPS and robots.txt should
        /// allow the URL path to be accessible by UserAgent:Google-Valuables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
