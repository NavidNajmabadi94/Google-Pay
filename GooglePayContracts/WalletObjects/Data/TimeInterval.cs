using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class TimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End time of the interval.
        ///
        /// Offset is not required.  If an offset is provided and `start` time is set, `start` must also include an
        /// offset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual DateTime End { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#timeInterval"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Start time of the interval.
        ///
        /// Offset is not required. If an offset is provided and `end` time is set, `end` must also  include an
        /// offset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual DateTime Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
