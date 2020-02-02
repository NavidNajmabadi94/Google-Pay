using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class SignUpInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the class the user can sign up for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
