using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Pagination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#pagination"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Page token to send to fetch the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Number of results returned in this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsPerPage")]
        public virtual System.Nullable<int> ResultsPerPage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
