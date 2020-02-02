using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class FieldReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only valid if the `fieldPath` references a date field. Chooses how the date field will be formatted
        /// and displayed in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormat")]
        public virtual string DateFormat { get; set; }

        /// <summary>Path to the field being referenced, prefixed with "object" or "class" and separated with dots. For
        /// example, it may be the string "object.purchaseDetails.purchasePrice".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

}
