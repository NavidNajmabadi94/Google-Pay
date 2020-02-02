using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Uri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI's title appearing in the app as text. Recommended maximum is 20 characters to ensure full
        /// string is displayed on smaller screens.
        ///
        /// Note that in some contexts this text is not used, such as when `description` is part of an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ID associated with a uri. This field is here to enable ease of management of uris.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string `"walletobjects#uri"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Translated strings for the description. Recommended maximum is 20 characters to ensure full string
        /// is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedDescription")]
        public virtual LocalizedString LocalizedDescription { get; set; }

        /// <summary>The location of a web page, image, or other resource. URIs in the `LinksModuleData` module can have
        /// different prefixes indicating the type of URI (a link to a web page, a link to a map, a telephone number, or
        /// an email address). URIs must have a scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string UriValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
