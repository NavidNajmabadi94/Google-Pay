using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class OfferObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<OfferObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
