using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class ImageUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the image, which is unused and retained only for backward
        /// compatibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Translated strings for the description, which are unused and retained only for backward
        /// compatibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedDescription")]
        public virtual LocalizedString LocalizedDescription { get; set; }

        /// <summary>The location of the image. URIs must have a scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
