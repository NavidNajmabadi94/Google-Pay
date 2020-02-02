using GooglePayContracts.WalletObjects.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Service
{
    public class IssuerResource
    {
        private const string Resource = "issuer";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IssuerResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns the issuer with the given issuer ID.</summary>
        /// <param name="resourceId">The unique identifier for an issuer. This ID must be unique across all
        /// issuers.</param>
        public virtual GetRequest Get(long resourceId)
        {
            return new GetRequest(service, resourceId);
        }

        /// <summary>Returns the issuer with the given issuer ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Issuer>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long resourceId)
                : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }


            /// <summary>The unique identifier for an issuer. This ID must be unique across all issuers.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "walletobjects/v1/issuer/{resourceId}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "resourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Inserts an issuer with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Issuer body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Inserts an issuer with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Issuer>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Issuer body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Issuer Body { get; set; }

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
                get { return "walletobjects/v1/issuer"; }
            }

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Returns a list of all issuers shared to the caller.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Returns a list of all issuers shared to the caller.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<IssuerListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "walletobjects/v1/issuer"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Updates the issuer referenced by the given issuer ID. This method supports patch
        /// semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for an issuer. This ID must be unique across all
        /// issuers.</param>
        public virtual PatchRequest Patch(Issuer body, long resourceId)
        {
            return new PatchRequest(service, body, resourceId);
        }

        /// <summary>Updates the issuer referenced by the given issuer ID. This method supports patch
        /// semantics.</summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Issuer>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Issuer body, long resourceId)
                : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }


            /// <summary>The unique identifier for an issuer. This ID must be unique across all issuers.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Issuer Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "patch"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PATCH"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "walletobjects/v1/issuer/{resourceId}"; }
            }

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "resourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates the issuer referenced by the given issuer ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for an issuer. This ID must be unique across all
        /// issuers.</param>
        public virtual UpdateRequest Update(Issuer body, long resourceId)
        {
            return new UpdateRequest(service, body, resourceId);
        }

        /// <summary>Updates the issuer referenced by the given issuer ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Issuer>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Issuer body, long resourceId)
                : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }


            /// <summary>The unique identifier for an issuer. This ID must be unique across all issuers.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Issuer Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "update"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PUT"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "walletobjects/v1/issuer/{resourceId}"; }
            }

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "resourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}
