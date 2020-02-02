using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts
{
    /// <summary>
    /// Config
    /// Used to define constants for:
    /// a) authorizing REST calls
    /// b) sign JSON Web Token (JWT)
    /// </summary>
    public class Config
    {
        private static Config config = new Config();
        private string SERVICE_ACCOUNT_EMAIL_ADDRESS;
        private string SERVICE_ACCOUNT_FILE;
        private string ISSUER_ID;
        private List<string> ORIGINS;
        private string AUDIENCE;
        private string JWT_TYPE;
        private List<string> SCOPES;

        private string APPLICATION_NAME;    // this isn't required

        private Config()
        {
            try
            {
                // Identifiers of Service account
                this.SERVICE_ACCOUNT_EMAIL_ADDRESS = "test@iam.gserviceaccount.com"; // CHANGEME
                this.SERVICE_ACCOUNT_FILE = "privateKey.json"; // CHANGEME. Path to file with private key and Google credential config

                // Used by the Google Pay API for Passes Client library
                this.APPLICATION_NAME = "google wallet"; // CHANGEME

                // Identifier of Google Pay API for Passes Merchant Center
                this.ISSUER_ID = "my_issuerId"; // CHANGEME

                // List of origins for save to phone button. Used for JWT
                // See https://developers.google.com/pay/passes/reference/s2w-reference
                this.ORIGINS = new List<string>() { "http://localhost:8080" };  // CHANGEME

                // Constants that are application agnostic. Used for JWT
                this.AUDIENCE = "google";
                this.JWT_TYPE = "savetoandroidpay";
                this.SCOPES = new List<string>() { "https://www.googleapis.com/auth/wallet_object.issuer" };
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
        }
        public string getServiceAccountEmailAddress()
        {
            return this.SERVICE_ACCOUNT_EMAIL_ADDRESS;
        }

        public string getServiceAccountFile()
        {
            return this.SERVICE_ACCOUNT_FILE;
        }

        public string getIssuerId()
        {
            return this.ISSUER_ID;
        }

        public List<string> getOrigins()
        {
            return this.ORIGINS;
        }

        public string getAudience()
        {
            return this.AUDIENCE;
        }

        public string getJwtType()
        {
            return this.JWT_TYPE;
        }

        public List<string> getScopes()
        {
            return this.SCOPES;
        }

        public string getApplicationName()
        {
            return this.APPLICATION_NAME;
        }

        public static Config getInstance()
        {
            if (config == null)
            {
                config = new Config();
            }
            return config;
        }
    }
}
