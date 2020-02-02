using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class IssuerListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Issuer> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

}
