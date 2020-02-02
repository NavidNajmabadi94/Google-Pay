using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LinksModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of URIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<Uri> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
