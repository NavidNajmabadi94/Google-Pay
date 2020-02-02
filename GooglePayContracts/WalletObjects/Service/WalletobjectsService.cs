using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Service
{
    public class WalletobjectsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WalletobjectsService() :
            this(new Google.Apis.Services.BaseClientService.Initializer())
        { }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WalletobjectsService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            giftcardclass = new GiftcardclassResource(this);
            giftcardobject = new GiftcardobjectResource(this);
            issuer = new IssuerResource(this);
            jwt = new JwtResource(this);
            loyaltyclass = new LoyaltyclassResource(this);
            loyaltyobject = new LoyaltyobjectResource(this);
            offerclass = new OfferclassResource(this);
            offerobject = new OfferobjectResource(this);
            permissions = new PermissionsResource(this);
            smarttap = new SmarttapResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "walletobjects"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://walletobjects.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the Google Pay Passes API.</summary>
        public class Scope
        {
            /// <summary>You should never encounter this message. Please do not approve the access request.</summary>
            public static string WalletObjectIssuer = "https://www.googleapis.com/auth/wallet_object.issuer";

        }
        private readonly GiftcardclassResource giftcardclass;

        /// <summary>Gets the Giftcardclass resource.</summary>
        public virtual GiftcardclassResource Giftcardclass
        {
            get { return giftcardclass; }
        }

        private readonly GiftcardobjectResource giftcardobject;

        /// <summary>Gets the Giftcardobject resource.</summary>
        public virtual GiftcardobjectResource Giftcardobject
        {
            get { return giftcardobject; }
        }

        private readonly IssuerResource issuer;

        /// <summary>Gets the Issuer resource.</summary>
        public virtual IssuerResource Issuer
        {
            get { return issuer; }
        }

        private readonly JwtResource jwt;

        /// <summary>Gets the Jwt resource.</summary>
        public virtual JwtResource Jwt
        {
            get { return jwt; }
        }

        private readonly LoyaltyclassResource loyaltyclass;

        /// <summary>Gets the Loyaltyclass resource.</summary>
        public virtual LoyaltyclassResource Loyaltyclass
        {
            get { return loyaltyclass; }
        }

        private readonly LoyaltyobjectResource loyaltyobject;

        /// <summary>Gets the Loyaltyobject resource.</summary>
        public virtual LoyaltyobjectResource Loyaltyobject
        {
            get { return loyaltyobject; }
        }

        private readonly OfferclassResource offerclass;

        /// <summary>Gets the Offerclass resource.</summary>
        public virtual OfferclassResource Offerclass
        {
            get { return offerclass; }
        }

        private readonly OfferobjectResource offerobject;

        /// <summary>Gets the Offerobject resource.</summary>
        public virtual OfferobjectResource Offerobject
        {
            get { return offerobject; }
        }

        private readonly PermissionsResource permissions;

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions
        {
            get { return permissions; }
        }

        private readonly SmarttapResource smarttap;

        /// <summary>Gets the Smarttap resource.</summary>
        public virtual SmarttapResource Smarttap
        {
            get { return smarttap; }
        }
    }
}
