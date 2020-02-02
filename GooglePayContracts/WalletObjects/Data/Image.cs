using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#image"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The URI for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual ImageUri SourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
