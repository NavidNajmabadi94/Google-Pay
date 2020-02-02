using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Review : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual string Comments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
