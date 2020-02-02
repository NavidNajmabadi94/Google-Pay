using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class LatLongPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#latLongPoint"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The latitude specified as any value in the range of -90.0 through +90.0, both inclusive. Values
        /// outside these bounds will be rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude specified in the range -180.0 through +180.0, both inclusive. Values outside these
        /// bounds will be rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
