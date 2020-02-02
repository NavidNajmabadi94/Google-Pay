using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class CardTemplateOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Template information for rows in the card view. At most two rows are allowed to be
        /// specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardRowTemplateInfos")]
        public virtual System.Collections.Generic.IList<CardRowTemplateInfo> CardRowTemplateInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
