using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class FieldSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If more than one reference is supplied, then the first one that references a non-empty field will
        /// be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<FieldReference> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
