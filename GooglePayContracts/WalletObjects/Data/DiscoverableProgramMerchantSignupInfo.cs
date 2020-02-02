namespace GooglePayContracts.WalletObjects.Data
{

    /// <summary>Information about the merchant hosted signup flow for a program.</summary>
    public class DiscoverableProgramMerchantSignupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary> User data that is sent in a POST request to the signup website URL. This information is encoded
        /// and then shared so that the merchant's website can prefill fields used to enroll the user for the
        /// discoverable program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signupSharedDatas")]
        public virtual System.Collections.Generic.IList<string> SignupSharedDatas { get; set; }

        /// <summary>The URL to direct the user to for the merchant's signup site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signupWebsite")]
        public virtual Uri SignupWebsite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}