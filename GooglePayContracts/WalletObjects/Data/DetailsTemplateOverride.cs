using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class DetailsTemplateOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information for the "nth" item displayed in the details list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailsItemInfos")]
        public virtual System.Collections.Generic.IList<DetailsItemInfo> DetailsItemInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
