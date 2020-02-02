using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{

    public class ModifyLinkedOfferObjectsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The linked offer object ids to add or remove from the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedOfferObjectIds")]
        public virtual ModifyLinkedOfferObjects LinkedOfferObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
