using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the user, group, or service account to which this permission refers
        /// to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>The role granted by this permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
