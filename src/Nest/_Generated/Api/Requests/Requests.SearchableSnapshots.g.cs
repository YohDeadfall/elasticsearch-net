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
//
// ------------------------------------------------

using Elastic.Transport;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.SearchableSnapshots
{
	[ConvertAs(typeof(ClearCacheRequest))]
	public partial interface IClearCacheRequest : IRequest<ClearCacheRequestParameters>
	{
	}

	public partial class ClearCacheRequest : PlainRequestBase<ClearCacheRequestParameters>, IClearCacheRequest
	{
		protected IClearCacheRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SearchableSnapshotsClearCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_searchable_snapshots/cache/clear</summary>
        public ClearCacheRequest() : base()
		{
		}

		///<summary>/{index}/_searchable_snapshots/cache/clear</summary>
        public ClearCacheRequest(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
	}

	[ConvertAs(typeof(MountRequest))]
	public partial interface IMountRequest : IRequest<MountRequestParameters>
	{
		Nest.IndexName Index { get; set; }

		Nest.IndexName? RenamedIndex { get; set; }

		Dictionary<string, object>? IndexSettings { get; set; }

		IEnumerable<string>? IgnoreIndexSettings { get; set; }
	}

	public partial class MountRequest : PlainRequestBase<MountRequestParameters>, IMountRequest
	{
		protected IMountRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SearchableSnapshotsMount;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/{snapshot}/_mount</summary>
        public MountRequest(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

		[JsonIgnore]
		public string? Storage { get => Q<string?>("storage"); set => Q("storage", value); }

		[JsonPropertyName("index")]
		public Nest.IndexName Index { get; set; }

		[JsonPropertyName("renamed_index")]
		public Nest.IndexName? RenamedIndex { get; set; }

		[JsonPropertyName("index_settings")]
		public Dictionary<string, object>? IndexSettings { get; set; }

		[JsonPropertyName("ignore_index_settings")]
		public IEnumerable<string>? IgnoreIndexSettings { get; set; }
	}

	[ConvertAs(typeof(StatsRequest))]
	public partial interface IStatsRequest : IRequest<StatsRequestParameters>
	{
	}

	public partial class StatsRequest : PlainRequestBase<StatsRequestParameters>, IStatsRequest
	{
		protected IStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SearchableSnapshotsStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_searchable_snapshots/stats</summary>
        public StatsRequest() : base()
		{
		}

		///<summary>/{index}/_searchable_snapshots/stats</summary>
        public StatsRequest(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}

		[JsonIgnore]
		public Nest.SearchableSnapshots.StatsLevel? Level { get => Q<Nest.SearchableSnapshots.StatsLevel?>("level"); set => Q("level", value); }
	}
}