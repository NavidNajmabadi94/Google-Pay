using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class OfferClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>Callback options to be used to call the issuer back for every save/delete of an object for this
        /// class by the end-user. All objects of this class are eligible for the callback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>Country code used to display the card's country (when the user is not in that country), as well as
        /// to display localized content when content is not available in the user's locale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>The details of the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>Available only to Smart Tap enabled partners.  Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>The fine print or terms of the offer, such as "20% off any t-shirt at Adam's Apparel."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finePrint")]
        public virtual string FinePrint { get; set; }

        /// <summary>The help link for the offer, such as `http://myownpersonaldomain.com/help`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpUri")]
        public virtual Uri HelpUri { get; set; }

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
        /// `"walletobjects#offerClass"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Links module data. If links module data is also defined on the object, both will be displayed. The
        /// maximum number of these fields (combined with the object) is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Translated strings for the details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedDetails")]
        public virtual LocalizedString LocalizedDetails { get; set; }

        /// <summary>Translated strings for the fine_print.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedFinePrint")]
        public virtual LocalizedString LocalizedFinePrint { get; set; }

        /// <summary>Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full
        /// string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>Translated strings for the provider. Recommended maximum length is 12 characters to ensure full
        /// string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedProvider")]
        public virtual LocalizedString LocalizedProvider { get; set; }

        /// <summary>Translated strings for the short title. Recommended maximum length is 20 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedShortTitle")]
        public virtual LocalizedString LocalizedShortTitle { get; set; }

        /// <summary>Translated strings for the title. Recommended maximum length is 60 characters to ensure full string
        /// is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedTitle")]
        public virtual LocalizedString LocalizedTitle { get; set; }

        /// <summary>The list of locations where the object can be used. The platform uses this information to trigger
        /// geolocated notifications to users. Note that locations in the object override locations in the class which
        /// override locations in the Google Places ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>An array of messages displayed in the app. All users of this object will receive its associated
        /// messages. The maximum number of these fields is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>Identifies whether multiple users and devices will save the same object referencing this
        /// class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>Required. The offer provider (either the aggregator name or merchant name). Recommended maximum
        /// length is 12 characters to ensure full string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Required. The redemption channels applicable to this offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionChannel")]
        public virtual string RedemptionChannel { get; set; }

        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>Required. The status of the class. This field can be set to `draft` or The status of the class.
        /// This field can be set to `draft` or `underReview` using the insert, patch, or update API calls. Once the
        /// review state is changed from `draft` it may not be changed back to `draft`.
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

        /// <summary>A shortened version of the title of the offer, such as "20% off," shown to users as a quick
        /// reference to the offer contents. Recommended maximum length is 20 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortTitle")]
        public virtual string ShortTitle { get; set; }

        /// <summary>Text module data. If text modules data is also defined on the object, both will be displayed. The
        /// maximum number of these fields (combined with the object) is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>Required. The title of the offer, such as "20% off any t-shirt." Recommended maximum length is 60
        /// characters to ensure full string is displayed on smaller screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The title image of the offer. This image is displayed in both the details and list views of the
        /// app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleImage")]
        public virtual Image TitleImage { get; set; }

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
