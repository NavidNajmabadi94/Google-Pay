using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Permissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the issuer the list of permissions refer to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerId")]
        public virtual System.Nullable<long> IssuerId { get; set; }

        /// <summary>The complete list of permissions for the issuer account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<Permission> PermissionsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
