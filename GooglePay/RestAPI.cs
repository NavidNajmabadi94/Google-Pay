using GooglePayContracts;
using GooglePayContracts.WalletObjects.Data;
using System;
using System.Collections.Generic;
using System.Text;
using static GooglePayContracts.Services;

namespace GooglePay
{
    public class RestAPI
    {
        public void TestInsertOfferClassAndObject()
        {
            RestMethods restMethods = RestMethods.getInstance();
            ResourceDefinitions resourceDefinitions = ResourceDefinitions.getInstance();
            VerticalType verticalType = Services.VerticalType.OFFER;
            Config config = Config.getInstance();
            string UUID = Guid.NewGuid().ToString();
            string classUid = $"{verticalType.ToString()}_CLASS_{UUID}";
            string classId = $"{config.getIssuerId()}.{classUid}";
            string UUIDobj = Guid.NewGuid().ToString();
            string objectUid = $"{verticalType.ToString()}_OBJECT_{UUIDobj}";
            string objectId = $"{config.getIssuerId()}.{objectUid}";
            OfferClass classResponse = restMethods.insertOfferClass(resourceDefinitions.makeOfferClassResource(classId));
            OfferObject objectResponse = restMethods.insertOfferObject(resourceDefinitions.makeOfferObjectResource(objectId, classId));
            Console.WriteLine("classResponse: " + classResponse);
            Console.WriteLine("objectResponse: " + objectResponse);
        }
    }
}
