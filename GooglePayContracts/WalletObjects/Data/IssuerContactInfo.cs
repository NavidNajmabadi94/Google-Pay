using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class IssuerContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email addresses which will receive alerts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertsEmails")]
        public virtual System.Collections.Generic.IList<string> AlertsEmails { get; set; }

        /// <summary>The primary contact email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The primary contact name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The primary contact phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual string Phone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
