using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class CardBarcodeSectionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional information to display below the barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstBottomDetail")]
        public virtual BarcodeSectionDetail FirstBottomDetail { get; set; }

        /// <summary>Optional information to display above the barcode. If `secondTopDetail` is defined, this will be
        /// displayed to the start side of this detail section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstTopDetail")]
        public virtual BarcodeSectionDetail FirstTopDetail { get; set; }

        /// <summary>Optional second piece of information to display above the barcode. If `firstTopDetail` is defined,
        /// this will be displayed to the end side of this detail section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondTopDetail")]
        public virtual BarcodeSectionDetail SecondTopDetail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
