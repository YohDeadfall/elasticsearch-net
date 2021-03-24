// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Text.Json.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public interface IEqlDeleteRequest : IRequest<EqlDeleteRequestParameters>
    {
    }

    public class EqlDeleteRequest : PlainRequestBase<EqlDeleteRequestParameters>, IEqlDeleteRequest
    {
        protected IEqlDeleteRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlDelete;
        protected override HttpMethod HttpMethod => HttpMethod.DELETE;
        protected override bool SupportsBody => false;
        ///<summary>/_eql/search/{id}</summary>
        public EqlDeleteRequest(Id id): base(r => r)
        {
        }

        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

        [JsonPropertyName("stub_c")]
        public string StubC { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public interface IEqlGetRequest : IRequest<EqlGetRequestParameters>
    {
    }

    public class EqlGetRequest : PlainRequestBase<EqlGetRequestParameters>, IEqlGetRequest
    {
        protected IEqlGetRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlGet;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
        ///<summary>/_eql/search/{id}</summary>
        public EqlGetRequest(Id id): base(r => r)
        {
        }

        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

        [JsonPropertyName("stub_c")]
        public string StubC { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public interface IEqlGetStatusRequest : IRequest<EqlGetStatusRequestParameters>
    {
    }

    public class EqlGetStatusRequest : PlainRequestBase<EqlGetStatusRequestParameters>, IEqlGetStatusRequest
    {
        protected IEqlGetStatusRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlGetStatus;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
        ///<summary>/_eql/search/status/{id}</summary>
        public EqlGetStatusRequest(Id id): base(r => r)
        {
        }

        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

        [JsonPropertyName("stub_c")]
        public string StubC { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public interface IEqlSearchRequest : IRequest<EqlSearchRequestParameters>
    {
    }

    public class EqlSearchRequest : PlainRequestBase<EqlSearchRequestParameters>, IEqlSearchRequest
    {
        protected IEqlSearchRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlSearch;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
        ///<summary>/{index}/_eql/search</summary>
        public EqlSearchRequest(Index index): base(r => r)
        {
        }

        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

        [JsonPropertyName("stub_c")]
        public string StubC { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }
}