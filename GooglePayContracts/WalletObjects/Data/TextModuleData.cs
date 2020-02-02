using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    /// <summary>Data for Text module. All fields are optional. Header will be displayed if available, different types
    /// of bodies will be concatenated if they are defined.</summary>
    public class TextModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The body of the Text Module, which is defined as an uninterrupted string. Recommended maximum
        /// length is 500 characters to ensure full string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>The header of the Text Module. Recommended maximum length is 35 characters to ensure full string is
        /// displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>The ID associated with a text module. This field is here to enable ease of management of text
        /// modules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Translated strings for the body. Recommended maximum length is 500 characters to ensure full string
        /// is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedBody")]
        public virtual LocalizedString LocalizedBody { get; set; }

        /// <summary>Translated strings for the header. Recommended maximum length is 35 characters to ensure full
        /// string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedHeader")]
        public virtual LocalizedString LocalizedHeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
