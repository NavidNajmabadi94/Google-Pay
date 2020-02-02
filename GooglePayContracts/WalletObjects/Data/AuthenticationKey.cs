using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class AuthenticationKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Available only to Smart Tap enabled partners.  Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>Available only to Smart Tap enabled partners.  Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyPem")]
        public virtual string PublicKeyPem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
