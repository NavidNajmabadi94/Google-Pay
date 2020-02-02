using GooglePayContracts.WalletObjects.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Service
{
    public class SmarttapResource
    {
        private const string Resource = "smarttap";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SmarttapResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Inserts the smart tap.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(SmartTap body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Inserts the smart tap.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<SmartTap>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, SmartTap body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            SmartTap Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "insert"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "walletobjects/v1/smartTap"; }
            }

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}
