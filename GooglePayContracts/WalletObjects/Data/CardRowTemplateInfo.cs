using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class CardRowTemplateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Template for a row containing one item. Exactly one of "one_item", "two_items", "three_items" must
        /// be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneItem")]
        public virtual CardRowOneItem OneItem { get; set; }

        /// <summary>Template for a row containing three items. Exactly one of "one_item", "two_items", "three_items"
        /// must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threeItems")]
        public virtual CardRowThreeItems ThreeItems { get; set; }

        /// <summary>Template for a row containing two items. Exactly one of "one_item", "two_items", "three_items" must
        /// be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twoItems")]
        public virtual CardRowTwoItems TwoItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
