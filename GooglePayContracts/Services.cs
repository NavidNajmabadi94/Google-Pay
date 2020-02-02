using GooglePayContracts.WalletObjects.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts
{
    /*******************************
  *
  *  These are services that you would expose to front end so they can generate save links or buttons.
  *
  *  Depending on your needs, you only need to implement 1 of the services.
  *
  *******************************/
    public class Services
    {
        public Services()
        {

        }
        /*******************************
        *
        *
        *  See all the verticals: https://developers.google.com/pay/passes/guides/overview/basics/about-google-pay-api-for-passes
        *
        *******************************/
        public enum VerticalType
        {
            OFFER
            , EVENTTICKET
            , FLIGHT     // also referred to as Boarding Passes
            , GIFTCARD
            , LOYALTY
            , TRANSIT
        }
        /// <summary>
        /// Generates a signed "fat" JWT.
        /// No REST calls made.
        /// Use fat JWT in JS web button.
        /// Fat JWT is too long to be used in Android intents.
        /// Possibly might break in redirects.
        /// </summary>
        /// <param name="verticalType"> pass type to created</param>
        /// <param name="classId">the unique identifier for the class</param>
        /// <param name="objectId">the unique identifier for the object</param>
        /// <returns></returns>
        public string makeFatJwt(VerticalType verticalType, string classId, string objectId)
        {
            ResourceDefinitions resourceDefinitions = ResourceDefinitions.getInstance();
            RestMethods restMethods = RestMethods.getInstance();
            // create JWT to put objects and class into JSON Web Token (JWT) format for Google Pay API for Passes
            Jwt googlePassJwt = new Jwt();
            // get class definition, object definition and see if Ids exist. for a fat JWT, first time a user hits the save button, the class and object are inserted            
            try
            {
                switch (verticalType)
                {
                    case VerticalType.OFFER:
                        OfferClass offerClass = resourceDefinitions.makeOfferClassResource(classId);
                        OfferObject offerObject = resourceDefinitions.makeOfferObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to get class and object to see if they exist.");
                        OfferClass classResponse = restMethods.getOfferClass(classId);
                        OfferObject objectResponse = restMethods.getOfferObject(objectId);
                        // check responses
                        if (!(classResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} already exists.");
                        }
                        if (!(objectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} already exists.");
                        }
                        if (!(classResponse is null) && objectResponse.ClassId != offerObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({objectResponse.ClassId}). " +
                            $"It does not match the target classId ({offerObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add both class and object resource definitions into JWT because no REST calls made to pre-insert
                        googlePassJwt.addOfferClass(offerClass);
                        googlePassJwt.addOfferObject(offerObject);
                        break;
                    case VerticalType.LOYALTY:
                        LoyaltyClass loyaltyClass = resourceDefinitions.makeLoyaltyClassResource(classId);
                        LoyaltyObject loyaltyObject = resourceDefinitions.makeLoyaltyObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to get class and object to see if they exist.");
                        LoyaltyClass loyaltyClassResponse = restMethods.getLoyaltyClass(classId);
                        LoyaltyObject loyaltyObjectResponse = restMethods.getLoyaltyObject(objectId);
                        // check responses
                        if (!(loyaltyClassResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} already exists.");
                        }
                        if (!(loyaltyObjectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} already exists.");
                        }
                        if (!(loyaltyClassResponse is null) && loyaltyObjectResponse.ClassId != loyaltyObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({loyaltyObjectResponse.ClassId}). " +
                            $"It does not match the target classId ({loyaltyObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add both class and object resource definitions into JWT because no REST calls made to pre-insert
                        googlePassJwt.addLoyaltyClass(loyaltyClass);
                        googlePassJwt.addLoyaltyObject(loyaltyObject);
                        break;
                    case VerticalType.GIFTCARD:
                        GiftCardClass giftCardClass = resourceDefinitions.makeGiftCardClassResource(classId);
                        GiftCardObject giftCardObject = resourceDefinitions.makeGiftCardObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to get class and object to see if they exist.");
                        GiftCardClass giftCardClassResponse = restMethods.getGiftCardClass(classId);
                        GiftCardObject giftCardObjectResponse = restMethods.getGiftCardObject(objectId);
                        // check responses
                        if (!(giftCardClassResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} already exists.");
                        }
                        if (!(giftCardObjectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} already exists.");
                        }
                        if (!(giftCardClassResponse is null) && giftCardObjectResponse.ClassId != giftCardObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({giftCardObjectResponse.ClassId}). " +
                            $"It does not match the target classId ({giftCardObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add both class and object resource definitions into JWT because no REST calls made to pre-insert
                        googlePassJwt.addGiftCardClass(giftCardClass);
                        googlePassJwt.addGiftCardObject(giftCardObject);
                        break;
                }
                // return "fat" JWT. Try putting it into JS web button
                // note button needs to be rendered in local web server who's domain matches the ORIGINS
                // defined in the JWT. See https://developers.google.com/pay/passes/reference/s2w-reference
                return googlePassJwt.generateSignedJwt();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                return null;
            }
        }
        /// <summary>
        /// Generates a signed "object" JWT.
        /// 1 REST call is made to pre-insert class.
        /// If this JWT only contains 1 object, usually isn't too long; can be used in Android intents/redirects.
        /// </summary>
        /// <param name="verticalType"> pass type to created</param>
        /// <param name="classId">the unique identifier for the class</param>
        /// <param name="objectId">the unique identifier for the object</param>
        /// <returns></returns>
        public string makeObjectJwt(VerticalType verticalType, string classId, string objectId)
        {
            ResourceDefinitions resourceDefinitions = ResourceDefinitions.getInstance();
            RestMethods restMethods = RestMethods.getInstance();
            // create JWT to put objects and class into JSON Web Token (JWT) format for Google Pay API for Passes
            Jwt googlePassJwt = new Jwt();
            // get class, object definitions, insert class (check in Merchant center GUI: https://pay.google.com/gp/m/issuer/list)
            try
            {
                switch (verticalType)
                {
                    case VerticalType.OFFER:
                        OfferClass offerClass = resourceDefinitions.makeOfferClassResource(classId);
                        OfferObject offerObject = resourceDefinitions.makeOfferObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to insert class");
                        OfferClass classResponse = restMethods.insertOfferClass(offerClass);
                        System.Console.WriteLine("\nMaking REST call to get object to see if it exists.");
                        OfferObject objectResponse = restMethods.getOfferObject(objectId);
                        // check responses
                        if (!(classResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} inserted.");
                        }
                        else
                        {
                            System.Console.WriteLine($"classId: {classId} insertion failed. See above Server Response for more information.");
                        }
                        if (!(objectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} already exists.");
                        }
                        if (!(objectResponse is null) && objectResponse.ClassId != offerObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({objectResponse.ClassId}). " +
                            $"It does not match the target classId ({offerObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add only object because class was pre-inserted
                        googlePassJwt.addOfferObject(offerObject);
                        break;
                    case VerticalType.LOYALTY:
                        LoyaltyClass loyaltyClass = resourceDefinitions.makeLoyaltyClassResource(classId);
                        LoyaltyObject loyaltyObject = resourceDefinitions.makeLoyaltyObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to insert class");
                        LoyaltyClass loyaltyClassResponse = restMethods.insertLoyaltyClass(loyaltyClass);
                        System.Console.WriteLine("\nMaking REST call to get object to see if it exists.");
                        LoyaltyObject loyaltyObjectResponse = restMethods.getLoyaltyObject(objectId);
                        // check responses
                        if (!(loyaltyClassResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} inserted.");
                        }
                        else
                        {
                            System.Console.WriteLine($"classId: {classId} insertion failed. See above Server Response for more information.");
                        }
                        if (!(loyaltyObjectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} already exists.");
                        }
                        if (!(loyaltyObjectResponse is null) && loyaltyObjectResponse.ClassId != loyaltyObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({loyaltyObjectResponse.ClassId}). " +
                            $"It does not match the target classId ({loyaltyObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add only object because class was pre-inserted
                        googlePassJwt.addLoyaltyObject(loyaltyObject);
                        break;
                    case VerticalType.GIFTCARD:
                        GiftCardClass giftCardClass = resourceDefinitions.makeGiftCardClassResource(classId);
                        GiftCardObject giftCardObject = resourceDefinitions.makeGiftCardObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to insert class");
                        GiftCardClass giftCardClassResponse = restMethods.insertGiftCardClass(giftCardClass);
                        System.Console.WriteLine("\nMaking REST call to get object to see if it exists.");
                        GiftCardObject giftCardObjectResponse = restMethods.getGiftCardObject(objectId);
                        // check responses
                        if (!(giftCardClassResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} inserted.");
                        }
                        else
                        {
                            System.Console.WriteLine($"classId: {classId} insertion failed. See above Server Response for more information.");
                        }
                        if (!(giftCardObjectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} already exists.");
                        }
                        if (!(giftCardObjectResponse is null) && giftCardObjectResponse.ClassId != giftCardObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({giftCardObjectResponse.ClassId}). " +
                            $"It does not match the target classId ({giftCardObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add only object because class was pre-inserted
                        googlePassJwt.addGiftCardObject(giftCardObject);
                        break;
                }
                // return "object" JWT.Try putting it into save link.
                // See https://developers.google.com/pay/passes/guides/get-started/implementing-the-api/save-to-google-pay#add-link-to-email
                return googlePassJwt.generateSignedJwt();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                return null;
            }
        }
        /// <summary>
        /// Generates a signed "skinny" JWT.
        /// 2 REST calls are made to pre-insert class and object
        /// This JWT can be used in JS web button.
        /// This is the shortest type of JWT; recommended for Android intents/redirects.
        /// </summary>
        /// <param name="verticalType"> pass type to created</param>
        /// <param name="classId">the unique identifier for the class</param>
        /// <param name="objectId">the unique identifier for the object</param>
        /// <returns></returns>
        public string makeSkinnyJwt(VerticalType verticalType, string classId, string objectId)
        {
            ResourceDefinitions resourceDefinitions = ResourceDefinitions.getInstance();
            RestMethods restMethods = RestMethods.getInstance();
            // create JWT to put objects and class into JSON Web Token (JWT) format for Google Pay API for Passes
            Jwt googlePassJwt = new Jwt();
            // get class, object definitions, insert class (check in Merchant center GUI: https://pay.google.com/gp/m/issuer/list)
            try
            {
                switch (verticalType)
                {
                    case VerticalType.OFFER:
                        OfferClass offerClass = resourceDefinitions.makeOfferClassResource(classId);
                        OfferObject offerObject = resourceDefinitions.makeOfferObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to insert class and object");
                        OfferClass classResponse = restMethods.insertOfferClass(offerClass);
                        OfferObject objectResponse = restMethods.insertOfferObject(offerObject);
                        // check response
                        if (!(classResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} inserted.");
                        }
                        else
                        {
                            System.Console.WriteLine($"classId: {classId} insertion failed. See above Server Response for more information.");
                        }
                        if (!(objectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} inserted.");
                        }
                        else
                        {
                            System.Console.WriteLine($"objectId: {objectId} insertion failed. See above Server Response for more information.");
                        }
                        if (!(objectResponse is null) && objectResponse.ClassId != offerObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({objectResponse.ClassId}). " +
                            $"It does not match the target classId ({offerObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add only object id because class and object were pre inserted.
                        offerObject = new OfferObject() { Id = offerObject.Id };
                        googlePassJwt.addOfferObject(offerObject);
                        break;
                    case VerticalType.LOYALTY:
                        LoyaltyClass loyaltyClass = resourceDefinitions.makeLoyaltyClassResource(classId);
                        LoyaltyObject loyaltyObject = resourceDefinitions.makeLoyaltyObjectResource(objectId, classId);
                        System.Console.WriteLine("\nMaking REST call to insert class and object");
                        LoyaltyClass loyaltyClassResponse = restMethods.insertLoyaltyClass(loyaltyClass);
                        LoyaltyObject loyaltyObjectResponse = restMethods.insertLoyaltyObject(loyaltyObject);
                        // check response
                        // check class get response
                        if (!(loyaltyClassResponse is null))
                        {
                            System.Console.WriteLine($"classId: {classId} inserted.");
                        }
                        else
                        {
                            System.Console.WriteLine($"classId: {classId} insertion failed. See above Server Response for more information.");
                        }
                        if (!(loyaltyObjectResponse is null))
                        {
                            System.Console.WriteLine($"objectId: {objectId} inserted.");
                        }
                        else
                        {
                            System.Console.WriteLine($"objectId: {objectId} insertion failed. See above Server Response for more information.");
                        }
                        if (!(loyaltyObjectResponse is null) && loyaltyObjectResponse.ClassId != loyaltyObject.ClassId)
                        {
                            System.Console.WriteLine($"the classId of inserted object is ({loyaltyObjectResponse.ClassId}). " +
                            $"It does not match the target classId ({loyaltyObject.ClassId}). The saved object will not " +
                            "have the class properties you expect.");
                        }
                        // need to add only object id because class and object were pre inserted.
                        loyaltyObject = new LoyaltyObject() { Id = loyaltyObject.Id };
                        googlePassJwt.addLoyaltyObject(loyaltyObject);
                        break;
                }
                // return "skinny" JWT. Try putting it into save link.
                // See https://developers.google.com/pay/passes/guides/get-started/implementing-the-api/save-to-google-pay#add-link-to-email
                return googlePassJwt.generateSignedJwt();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
