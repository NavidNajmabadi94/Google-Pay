using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class IssuerToUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signUpInfo")]
        public virtual SignUpInfo SignUpInfo { get; set; }

        /// <summary>Currently not used, consider deprecating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>JSON web token for action S2AP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
