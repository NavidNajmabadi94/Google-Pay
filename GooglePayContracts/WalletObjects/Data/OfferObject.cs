using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{

    public class OfferObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional information about the partner app link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>The barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>Required. The class associated with this object. The class must be of the same type as this object,
        /// must already exist, and must be approved.
        ///
        /// Class IDs should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>A copy of the inherited fields of the parent class. These fields are retrieved during a
        /// GET.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classReference")]
        public virtual OfferClass ClassReference { get; set; }

        /// <summary>Indicates if notifications should explicitly be suppressed. If this field is set to true,
        /// regardless of the `messages` field, expiration notifications to the user will be suppressed. By default,
        /// this field is set to false.
        ///
        /// Currently, this can only be set for offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpirationNotification")]
        public virtual System.Nullable<bool> DisableExpirationNotification { get; set; }

        /// <summary>Whether this object is currently linked to a single device. This field is set by the platform when
        /// a user saves the object, linking it to their device. Intended for use by select partners. Contact support
        /// for additional information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasLinkedDevice")]
        public virtual System.Nullable<bool> HasLinkedDevice { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>Required. The unique identifier for an object. This ID must be unique across all objects from an
        /// issuer. This value should follow the format issuer ID.identifier where the former is issued by Google and
        /// latter is chosen by you. The unique identifier should only include alphanumeric characters, '.', '_', or
        /// '-'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Image module data. If image modules data is also defined on the class, those will be merged with
        /// the image data defined on the object. The maximum number of these fields (combined with the class) is
        /// 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#offerObject"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Links module data. If links module data is also defined on the class, both will be displayed. The
        /// maximum number of these fields (combined with the class) is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>The list of locations where the object can be used. The platform uses this information to trigger
        /// geolocated notifications to users. Note that locations in the object override locations in the class which
        /// override locations in the Google Places ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>An array of messages displayed in the app. All users of this object will receive its associated
        /// messages. The maximum number of these fields is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>Required. The state of the object. This field is used to determine how an object is displayed in
        /// the app. For example, an `inactive` object is no longer displayed in the Google Pay app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Text module data. If text module data is also defined on the class, both will be displayed. The
        /// maximum number of these fields (combined with the class) is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>The time period this object will be `active` and object can be used. An object's state will be
        /// changed to `expired` when this time period has passed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

}
