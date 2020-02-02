namespace GooglePayContracts.WalletObjects.Data
{
    public class ModifyLinkedOfferObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The linked offer object ids to add to the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addLinkedOfferObjectIds")]
        public virtual System.Collections.Generic.IList<string> AddLinkedOfferObjectIds { get; set; }

        /// <summary>The linked offer object ids to remove from the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeLinkedOfferObjectIds")]
        public virtual System.Collections.Generic.IList<string> RemoveLinkedOfferObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}