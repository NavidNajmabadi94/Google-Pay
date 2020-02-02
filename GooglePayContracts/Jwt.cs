using Google.Apis.Auth.OAuth2;
using GooglePayContracts.WalletObjects.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GooglePayContracts
{
    /// <summary>
    /// class that defines JWT format for a Google Pay Pass.
    /// to check the JWT protocol for Google Pay Passes, check:
    /// https://developers.google.com/pay/passes/reference/s2w-reference#google-pay-api-for-passes-jwt
    /// also demonstrates RSA-SHA256 signing implementation to make the signed JWT used
    /// in links and buttons. Learn more:
    /// https://developers.google.com/pay/passes/guides/get-started/implementing-the-api/save-to-google-pay
    /// </summary>
    public class Jwt
    {
        public string aud;
        public string typ;
        public string iss;
        public List<string> origins;
        public int iat;

        public JwtPayload payload;
        private ServiceAccountCredential credential;

        public Jwt()
        {
            Config config = Config.getInstance();
            this.aud = config.getAudience();
            this.iat = (int)(System.DateTime.UtcNow - new System.DateTime(1970, 1, 1)).TotalSeconds;
            this.typ = config.getJwtType();
            this.iss = config.getServiceAccountEmailAddress();
            this.origins = config.getOrigins();
            this.payload = new JwtPayload();
            string serviceAccountFile = config.getServiceAccountFile();
            using (FileStream fs = new FileStream(serviceAccountFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                this.credential = ServiceAccountCredential.FromServiceAccountData(fs);
            }

        }
        public void addOfferClass(OfferClass offerClass)
        {
            if (this.payload.offerClasses == null)
            {
                this.payload.offerClasses = new List<OfferClass>();
            }
            this.payload.offerClasses.Add(offerClass);
        }
        public void addOfferObject(OfferObject offerObject)
        {
            if (this.payload.offerObjects == null)
            {
                this.payload.offerObjects = new List<OfferObject>();
            }
            this.payload.offerObjects.Add(offerObject);
        }
        public void addLoyaltyClass(LoyaltyClass loyaltyClass)
        {
            if (this.payload.loyaltyClasses == null)
            {
                this.payload.loyaltyClasses = new List<LoyaltyClass>();
            }
            this.payload.loyaltyClasses.Add(loyaltyClass);
        }
        public void addLoyaltyObject(LoyaltyObject loyaltyObject)
        {
            if (this.payload.loyaltyObjects == null)
            {
                this.payload.loyaltyObjects = new List<LoyaltyObject>();
            }
            this.payload.loyaltyObjects.Add(loyaltyObject);
        }
        public void addGiftCardClass(GiftCardClass giftCardClass)
        {
            if (this.payload.giftCardClasses == null)
            {
                this.payload.giftCardClasses = new List<GiftCardClass>();
            }
            this.payload.giftCardClasses.Add(giftCardClass);
        }
        public void addGiftCardObject(GiftCardObject giftCardObject)
        {
            if (this.payload.giftCardObjects == null)
            {
                this.payload.giftCardObjects = new List<GiftCardObject>();
            }
            this.payload.giftCardObjects.Add(giftCardObject);
        }
     
        public string generateSignedJwt()
        {

            string header = "{\"alg\":\"RS256\",\"typ\":\"JWT\"}";
            string payload = JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            string encodedSafeHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes(header)).Replace('+', '-').Replace('/', '_').Replace("=", "");
            string encodedSafePayload = Convert.ToBase64String(Encoding.UTF8.GetBytes(payload)).Replace('+', '-').Replace('/', '_').Replace("=", ""); ;
            string signature = credential.CreateSignature(Encoding.UTF8.GetBytes($"{encodedSafeHeader}.{encodedSafePayload}")).Replace('+', '-').Replace('/', '_').Replace("=", "");

            string token = $"{encodedSafeHeader}.{encodedSafePayload}.{signature}";
            return token;
        }
        public class JwtPayload
        {
            public List<OfferClass> offerClasses;
            public List<OfferObject> offerObjects;
            public List<LoyaltyClass> loyaltyClasses;
            public List<LoyaltyObject> loyaltyObjects;
            public List<GiftCardClass> giftCardClasses;
            public List<GiftCardObject> giftCardObjects;
        }

    }
}
