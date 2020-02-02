using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The currency code, such as "USD" or "EUR."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#money"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The unit of money amount in micros. For example, $1 USD would be represented as 1000000
        /// micros.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("micros")]
        public virtual System.Nullable<long> Micros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
