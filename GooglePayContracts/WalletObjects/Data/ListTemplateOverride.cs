using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Data
{
    public class ListTemplateOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies from a predefined set of options what the will be displayed in the first row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstRowOption")]
        public virtual FirstRowOption FirstRowOption { get; set; }

        /// <summary>A reference to the field to be displayed in the second row.
        ///
        /// This option is only displayed if there are not multiple user objects in a group. If there is a group, the
        /// second row will always display the departure date shared by all objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondRowOption")]
        public virtual FieldSelector SecondRowOption { get; set; }

        /// <summary>A reference to the field to be displayed in the third row.
        ///
        /// This option is only displayed if there are not multiple user objects in a group. If there is a group, the
        /// third row will always display the number of objects in the group. Eg: "3 passes"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdRowOption")]
        public virtual FieldSelector ThirdRowOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
