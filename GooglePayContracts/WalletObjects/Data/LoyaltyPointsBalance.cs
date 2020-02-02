using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LoyaltyPointsBalance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The double form of a balance. Only one of these subtypes (string, int, double, money) should be
        /// populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("double")]
        public virtual System.Nullable<double> Double__ { get; set; }

        /// <summary>The integer form of a balance. Only one of these subtypes (string, int, double, money) should be
        /// populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int")]
        public virtual System.Nullable<int> Int__ { get; set; }

        /// <summary>The money form of a balance. Only one of these subtypes (string, int, double, money) should be
        /// populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("money")]
        public virtual Money Money { get; set; }

        /// <summary>The string form of a balance. Only one of these subtypes (string, int, double, money) should be
        /// populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("string")]
        public virtual string String__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
