using GooglePayContracts.WalletObjects.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Service
{
    public class JwtResource
    {
        private const string Resource = "jwt";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public JwtResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Inserts the resources in the JWT.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(JwtResource body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Inserts the resources in the JWT.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<JwtInsertResponse>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, JwtResource body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            JwtResource Body { get; set; }

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
                get { return "walletobjects/v1/jwt"; }
            }

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}
