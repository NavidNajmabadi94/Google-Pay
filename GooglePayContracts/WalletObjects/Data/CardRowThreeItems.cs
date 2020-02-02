using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class CardRowThreeItems : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to be displayed at the end of the row. This item will be aligned to the right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endItem")]
        public virtual TemplateItem EndItem { get; set; }

        /// <summary>The item to be displayed in the middle of the row. This item will be centered between the start and
        /// end items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("middleItem")]
        public virtual TemplateItem MiddleItem { get; set; }

        /// <summary>The item to be displayed at the start of the row. This item will be aligned to the left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startItem")]
        public virtual TemplateItem StartItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
