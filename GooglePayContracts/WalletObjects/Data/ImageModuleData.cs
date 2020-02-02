using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class ImageModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID associated with an image module. This field is here to enable ease of management of image
        /// modules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A 100% width image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainImage")]
        public virtual Image MainImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
