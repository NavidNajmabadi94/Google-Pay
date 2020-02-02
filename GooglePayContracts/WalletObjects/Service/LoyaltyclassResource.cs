using GooglePayContracts.WalletObjects.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GooglePayContracts.WalletObjects.Service
{
    public class LoyaltyclassResource
    {
        private const string Resource = "loyaltyclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LoyaltyclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Adds a message to the loyalty class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for a class. This ID must be unique across all classes from an
        /// issuer. This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.</param>
        public virtual AddmessageRequest Addmessage(AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(service, body, resourceId);
        }

        /// <summary>Adds a message to the loyalty class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<LoyaltyClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, AddMessageRequest body, string resourceId)
                : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }


            /// <summary>The unique identifier for a class. This ID must be unique across all classes from an issuer.
            /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter
            /// is chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or
            /// '-'.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            AddMessageRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "addmessage"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "walletobjects/v1/loyaltyClass/{resourceId}/addMessage"; }
            }

            /// <summary>Initializes Addmessage parameter list.</summary>
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

        /// <summary>Returns the loyalty class with the given class ID.</summary>
        /// <param name="resourceId">The unique identifier for a class. This ID must be unique across all classes from an
        /// issuer. This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.</param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(service, resourceId);
        }

        /// <summary>Returns the loyalty class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<LoyaltyClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId)
                : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }


            /// <summary>The unique identifier for a class. This ID must be unique across all classes from an issuer.
            /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter
            /// is chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or
            /// '-'.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }


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
                get { return "walletobjects/v1/loyaltyClass/{resourceId}"; }
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

        /// <summary>Inserts an loyalty class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(LoyaltyClass body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Inserts an loyalty class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<LoyaltyClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, LoyaltyClass body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            LoyaltyClass Body { get; set; }

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
                get { return "walletobjects/v1/loyaltyClass"; }
            }

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Returns a list of all loyalty classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Returns a list of all loyalty classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<LoyaltyClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>Used to get the next set of results if `maxResults` is specified, but more than `maxResults`
            /// classes are available in a list. For example, if you have a list of 200 classes and you call list with
            /// `maxResults` set to 20, list will return the first 20 classes and a token. Call list again with
            /// `maxResults` set to 20 and the token to get the next 20 classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Identifies the max number of results returned by a list. All results are returned if
            /// `maxResults` isn't defined.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }


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
                get { return "walletobjects/v1/loyaltyClass"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "issuerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "issuerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates the loyalty class referenced by the given class ID. This method supports patch
        /// semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for a class. This ID must be unique across all classes from an
        /// issuer. This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.</param>
        public virtual PatchRequest Patch(LoyaltyClass body, string resourceId)
        {
            return new PatchRequest(service, body, resourceId);
        }

        /// <summary>Updates the loyalty class referenced by the given class ID. This method supports patch
        /// semantics.</summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<LoyaltyClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, LoyaltyClass body, string resourceId)
                : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }


            /// <summary>The unique identifier for a class. This ID must be unique across all classes from an issuer.
            /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter
            /// is chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or
            /// '-'.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            LoyaltyClass Body { get; set; }

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
                get { return "walletobjects/v1/loyaltyClass/{resourceId}"; }
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

        /// <summary>Updates the loyalty class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for a class. This ID must be unique across all classes from an
        /// issuer. This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.</param>
        public virtual UpdateRequest Update(LoyaltyClass body, string resourceId)
        {
            return new UpdateRequest(service, body, resourceId);
        }

        /// <summary>Updates the loyalty class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<LoyaltyClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, LoyaltyClass body, string resourceId)
                : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }


            /// <summary>The unique identifier for a class. This ID must be unique across all classes from an issuer.
            /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter
            /// is chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or
            /// '-'.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            LoyaltyClass Body { get; set; }

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
                get { return "walletobjects/v1/loyaltyClass/{resourceId}"; }
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
