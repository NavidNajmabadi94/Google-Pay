using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>The period of time that the message will be displayed to users. You can define both a `startTime`
        /// and `endTime` for each message. A message is displayed immediately after a Wallet Object is inserted unless
        /// a `startTime` is set. The message will appear in a list of messages indefinitely if `endTime` is not
        /// provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayInterval")]
        public virtual TimeInterval DisplayInterval { get; set; }

        /// <summary>The message header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>The ID associated with a message. This field is here to enable ease of management of messages.
        /// Notice ID values could possibly duplicate across multiple messages in the same class/instance, and care must
        /// be taken to select a reasonable ID for each message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#walletObjectMessage"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Translated strings for the message body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedBody")]
        public virtual LocalizedString LocalizedBody { get; set; }

        /// <summary>Translated strings for the message header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedHeader")]
        public virtual LocalizedString LocalizedHeader { get; set; }

        /// <summary>The type of the message. Currently, this can only be set for offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageType")]
        public virtual string MessageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

}
