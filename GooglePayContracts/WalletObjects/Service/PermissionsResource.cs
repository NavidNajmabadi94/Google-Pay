using GooglePayContracts.WalletObjects.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Service
{
    public class PermissionsResource
    {
        private const string Resource = "permissions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PermissionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns the permissions for the given issuer id.</summary>
        /// <param name="resourceId">The unique identifier for an issuer. This ID must be unique across all
        /// issuers.</param>
        public virtual GetRequest Get(long resourceId)
        {
            return new GetRequest(service, resourceId);
        }

        /// <summary>Returns the permissions for the given issuer id.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Permissions>
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
                get { return "walletobjects/v1/permissions/{resourceId}"; }
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

        /// <summary>Updates the permissions for the given issuer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for an issuer. This ID must be unique across all
        /// issuers.</param>
        public virtual UpdateRequest Update(Permissions body, long resourceId)
        {
            return new UpdateRequest(service, body, resourceId);
        }

        /// <summary>Updates the permissions for the given issuer.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Permissions>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Permissions body, long resourceId)
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
            Permissions Body { get; set; }

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
                get { return "walletobjects/v1/permissions/{resourceId}"; }
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
