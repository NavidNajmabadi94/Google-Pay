using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class ClassTemplateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies extra information to be displayed above and below the barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardBarcodeSectionDetails")]
        public virtual CardBarcodeSectionDetails CardBarcodeSectionDetails { get; set; }

        /// <summary>Override for the card view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardTemplateOverride")]
        public virtual CardTemplateOverride CardTemplateOverride { get; set; }

        /// <summary>Override for the details view (beneath the card view).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailsTemplateOverride")]
        public virtual DetailsTemplateOverride DetailsTemplateOverride { get; set; }

        /// <summary>Override for the passes list view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listTemplateOverride")]
        public virtual ListTemplateOverride ListTemplateOverride { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
