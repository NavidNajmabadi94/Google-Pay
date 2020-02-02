using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class InfoModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of collections of labels and values. These will be displayed one after the other in a
        /// singular column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelValueRows")]
        public virtual System.Collections.Generic.IList<LabelValueRow> LabelValueRows { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("showLastUpdateTime")]
        public virtual System.Nullable<bool> ShowLastUpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

}
