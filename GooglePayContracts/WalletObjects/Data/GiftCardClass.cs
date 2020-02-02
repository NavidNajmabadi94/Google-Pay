using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class GiftCardClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines whether the merchant supports gift card redemption using barcode. If true, app displays
        /// a barcode for the gift card on the Gift card details screen. If false, a barcode is not displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowBarcodeRedemption")]
        public virtual System.Nullable<bool> AllowBarcodeRedemption { get; set; }

        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>Callback options to be used to call the issuer back for every save/delete of an object for this
        /// class by the end-user. All objects of this class are eligible for the callback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>The label to display for the card number, such as "Card Number".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardNumberLabel")]
        public virtual string CardNumberLabel { get; set; }

        /// <summary>Country code used to display the card's country (when the user is not in that country), as well as
        /// to display localized content when content is not available in the user's locale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>Available only to Smart Tap enabled partners.  Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>The label to display for event number, such as "Target Event #".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventNumberLabel")]
        public virtual string EventNumberLabel { get; set; }

        /// <summary>Optional banner image displayed on the front of the card. If none is present, nothing will be
        /// displayed. The image will display at 100% width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>The background color for the card. If not set the dominant color of the hero image is used, and if
        /// no hero image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex
        /// RGB triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb,
        /// such as `#fc0`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>The URI of your application's home page. Populating the URI in this field results in the exact same
        /// behavior as populating an URI in linksModuleData (when an object is rendered, a link to the homepage is
        /// shown in what would usually be thought of as the linksModuleData section of the object).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual Uri HomepageUri { get; set; }

        /// <summary>Required. The unique identifier for a class. This ID must be unique across all classes from an
        /// issuer. This value should follow the format issuer ID.identifier where the former is issued by Google and
        /// latter is chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or
        /// '-'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Image module data. If image modules data is also defined on the object, those will be merged with
        /// the image data defined on the class. The maximum number of these fields (combined with the object) is
        /// 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>Required. The issuer name. Recommended maximum length is 20 characters to ensure full string is
        /// displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerName")]
        public virtual string IssuerName { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#giftCardClass"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Links module data. If links module data is also defined on the object, both will be displayed. The
        /// maximum number of these fields (combined with the object) is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Translated strings for the card_number_label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedCardNumberLabel")]
        public virtual LocalizedString LocalizedCardNumberLabel { get; set; }

        /// <summary>Translated strings for the event_number_label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedEventNumberLabel")]
        public virtual LocalizedString LocalizedEventNumberLabel { get; set; }

        /// <summary>Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full
        /// string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>Translated strings for the merchant_name. The app may display an ellipsis after the first 20
        /// characters to ensure full string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedMerchantName")]
        public virtual LocalizedString LocalizedMerchantName { get; set; }

        /// <summary>Translated strings for the pin_label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedPinLabel")]
        public virtual LocalizedString LocalizedPinLabel { get; set; }

        /// <summary>The list of locations where the object can be used. The platform uses this information to trigger
        /// geolocated notifications to users. Note that locations in the object override locations in the class which
        /// override locations in the Google Places ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>Merchant name, such as "Adam's Apparel". The app may display an ellipsis after the first 20
        /// characters to ensure full string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantName")]
        public virtual string MerchantName { get; set; }

        /// <summary>An array of messages displayed in the app. All users of this object will receive its associated
        /// messages. The maximum number of these fields is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>Identifies whether multiple users and devices will save the same object referencing this
        /// class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>The label to display for the PIN, such as "4-digit PIN".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pinLabel")]
        public virtual string PinLabel { get; set; }

        /// <summary>The logo of the gift card program or company. This logo is displayed in both the details and list
        /// views of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programLogo")]
        public virtual Image ProgramLogo { get; set; }

        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>Required. The status of the class. This field can be set to `draft` or `underReview` using the
        /// insert, patch, or update API calls. Once the review state is changed from `draft` it may not be changed back
        /// to `draft`.
        ///
        /// You should keep this field to `draft` when the class is under development. A `draft` class cannot be used to
        /// create any object.
        ///
        /// You should set this field to `underReview` when you believe the class is ready for use. The platform will
        /// automatically set this field to `approved` and it can be immediately used to create or migrate objects.
        ///
        /// When updating an already `approved` class you should keep setting this field to `underReview`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual string ReviewStatus { get; set; }

        /// <summary>Text module data. If text modules data is also defined on the object, both will be displayed. The
        /// maximum number of these fields (combined with the object) is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordMark")]
        public virtual Image WordMark { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
