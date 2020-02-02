using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class AppLinkDataAppLinkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional image to be displayed in the App Link Module</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLogoImage")]
        public virtual Image AppLogoImage { get; set; }

        /// <summary>Url to follow when opening the App Link Module on clients. It will be used by partners to open
        /// their webpage or deeplink into their app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appTarget")]
        public virtual AppLinkDataAppLinkInfoAppTarget AppTarget { get; set; }

        /// <summary>String to be displayed in the description of the App Link Module Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual LocalizedString Description { get; set; }

        /// <summary>String to be displayed in the title of the App Link Module Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual LocalizedString Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
