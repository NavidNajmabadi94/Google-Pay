using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class JwtInsertResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data that corresponds to the ids of the provided classes and objects in the JWT. resources will
        /// only include the non-empty arrays (i.e. if the JWT only includes eventTicketObjects, then that is the only
        /// field that will be present in resources).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual Resources Resources { get; set; }

        /// <summary>A URI that, when opened, will allow the end user to save the object(s) identified in the JWT to
        /// their Google account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveUri")]
        public virtual string SaveUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
