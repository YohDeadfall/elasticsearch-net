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
namespace Nest.Cluster
{
	[ConvertAs(typeof(AllocationExplainRequest))]
	public partial interface IAllocationExplainRequest : IRequest<AllocationExplainRequestParameters>
	{
		string? CurrentNode { get; set; }

		Nest.IndexName? Index { get; set; }

		bool? Primary { get; set; }

		int? Shard { get; set; }
	}

	public partial class AllocationExplainRequest : PlainRequestBase<AllocationExplainRequestParameters>, IAllocationExplainRequest
	{
		protected IAllocationExplainRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterAllocationExplain;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => CurrentNode is null && Index is null && Primary is null && Shard is null;

		///<summary>/_cluster/allocation/explain</summary>
        public AllocationExplainRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? IncludeDiskInfo { get => Q<bool?>("include_disk_info"); set => Q("include_disk_info", value); }

		[JsonIgnore]
		public bool? IncludeYesDecisions { get => Q<bool?>("include_yes_decisions"); set => Q("include_yes_decisions", value); }

		[JsonPropertyName("current_node")]
		public string? CurrentNode { get; set; }

		[JsonPropertyName("index")]
		public Nest.IndexName? Index { get; set; }

		[JsonPropertyName("primary")]
		public bool? Primary { get; set; }

		[JsonPropertyName("shard")]
		public int? Shard { get; set; }
	}

	[ConvertAs(typeof(DeleteComponentTemplateRequest))]
	public partial interface IDeleteComponentTemplateRequest : IRequest<DeleteComponentTemplateRequestParameters>
	{
	}

	public partial class DeleteComponentTemplateRequest : PlainRequestBase<DeleteComponentTemplateRequestParameters>, IDeleteComponentTemplateRequest
	{
		protected IDeleteComponentTemplateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_component_template/{name}</summary>
        public DeleteComponentTemplateRequest(Nest.Name name) : base(r => r.Required("name", name))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(DeleteVotingConfigExclusionsRequest))]
	public partial interface IDeleteVotingConfigExclusionsRequest : IRequest<DeleteVotingConfigExclusionsRequestParameters>
	{
	}

	public partial class DeleteVotingConfigExclusionsRequest : PlainRequestBase<DeleteVotingConfigExclusionsRequestParameters>, IDeleteVotingConfigExclusionsRequest
	{
		protected IDeleteVotingConfigExclusionsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_cluster/voting_config_exclusions</summary>
        public DeleteVotingConfigExclusionsRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? WaitForRemoval { get => Q<bool?>("wait_for_removal"); set => Q("wait_for_removal", value); }
	}

	[ConvertAs(typeof(ExistsComponentTemplateRequest))]
	public partial interface IExistsComponentTemplateRequest : IRequest<ExistsComponentTemplateRequestParameters>
	{
	}

	public partial class ExistsComponentTemplateRequest : PlainRequestBase<ExistsComponentTemplateRequestParameters>, IExistsComponentTemplateRequest
	{
		protected IExistsComponentTemplateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterExistsComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_component_template/{name}</summary>
        public ExistsComponentTemplateRequest(Nest.Names name) : base(r => r.Required("name", name))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
	}

	[ConvertAs(typeof(GetComponentTemplateRequest))]
	public partial interface IGetComponentTemplateRequest : IRequest<GetComponentTemplateRequestParameters>
	{
	}

	public partial class GetComponentTemplateRequest : PlainRequestBase<GetComponentTemplateRequestParameters>, IGetComponentTemplateRequest
	{
		protected IGetComponentTemplateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_component_template</summary>
        public GetComponentTemplateRequest() : base()
		{
		}

		///<summary>/_component_template/{name}</summary>
        public GetComponentTemplateRequest(Nest.Name? name) : base(r => r.Optional("name", name))
		{
		}

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	[ConvertAs(typeof(GetSettingsRequest))]
	public partial interface IGetSettingsRequest : IRequest<GetSettingsRequestParameters>
	{
	}

	public partial class GetSettingsRequest : PlainRequestBase<GetSettingsRequestParameters>, IGetSettingsRequest
	{
		protected IGetSettingsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetSettings;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_cluster/settings</summary>
        public GetSettingsRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(HealthRequest))]
	public partial interface IHealthRequest : IRequest<HealthRequestParameters>
	{
	}

	public partial class HealthRequest : PlainRequestBase<HealthRequestParameters>, IHealthRequest
	{
		protected IHealthRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_cluster/health</summary>
        public HealthRequest() : base()
		{
		}

		///<summary>/_cluster/health/{index}</summary>
        public HealthRequest(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Nest.Level? Level { get => Q<Nest.Level?>("level"); set => Q("level", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Nest.WaitForActiveShards? WaitForActiveShards { get => Q<Nest.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public Nest.WaitForEvents? WaitForEvents { get => Q<Nest.WaitForEvents?>("wait_for_events"); set => Q("wait_for_events", value); }

		[JsonIgnore]
		public string? WaitForNodes { get => Q<string?>("wait_for_nodes"); set => Q("wait_for_nodes", value); }

		[JsonIgnore]
		public bool? WaitForNoInitializingShards { get => Q<bool?>("wait_for_no_initializing_shards"); set => Q("wait_for_no_initializing_shards", value); }

		[JsonIgnore]
		public bool? WaitForNoRelocatingShards { get => Q<bool?>("wait_for_no_relocating_shards"); set => Q("wait_for_no_relocating_shards", value); }

		[JsonIgnore]
		public Nest.WaitForStatus? WaitForStatus { get => Q<Nest.WaitForStatus?>("wait_for_status"); set => Q("wait_for_status", value); }
	}

	[ConvertAs(typeof(PendingTasksRequest))]
	public partial interface IPendingTasksRequest : IRequest<PendingTasksRequestParameters>
	{
	}

	public partial class PendingTasksRequest : PlainRequestBase<PendingTasksRequestParameters>, IPendingTasksRequest
	{
		protected IPendingTasksRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_cluster/pending_tasks</summary>
        public PendingTasksRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	[ConvertAs(typeof(PostVotingConfigExclusionsRequest))]
	public partial interface IPostVotingConfigExclusionsRequest : IRequest<PostVotingConfigExclusionsRequestParameters>
	{
	}

	public partial class PostVotingConfigExclusionsRequest : PlainRequestBase<PostVotingConfigExclusionsRequestParameters>, IPostVotingConfigExclusionsRequest
	{
		protected IPostVotingConfigExclusionsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPostVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_cluster/voting_config_exclusions</summary>
        public PostVotingConfigExclusionsRequest() : base()
		{
		}

		[JsonIgnore]
		public Nest.Names? NodeNames { get => Q<Nest.Names?>("node_names"); set => Q("node_names", value); }

		[JsonIgnore]
		public Nest.Ids? NodeIds { get => Q<Nest.Ids?>("node_ids"); set => Q("node_ids", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(PutComponentTemplateRequest))]
	public partial interface IPutComponentTemplateRequest : IRequest<PutComponentTemplateRequestParameters>
	{
		Nest.IndexManagement.IndexState Template { get; set; }

		Dictionary<string, Nest.IndexManagement.AliasDefinition>? Aliases { get; set; }

		Nest.Mapping.TypeMapping? Mappings { get; set; }

		Nest.IndexManagement.IndexSettings? Settings { get; set; }

		Nest.VersionNumber? Version { get; set; }

		Nest.Metadata? Meta { get; set; }
	}

	public partial class PutComponentTemplateRequest : PlainRequestBase<PutComponentTemplateRequestParameters>, IPutComponentTemplateRequest
	{
		protected IPutComponentTemplateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_component_template/{name}</summary>
        public PutComponentTemplateRequest(Nest.Name name) : base(r => r.Required("name", name))
		{
		}

		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonPropertyName("template")]
		public Nest.IndexManagement.IndexState Template { get; set; }

		[JsonPropertyName("aliases")]
		public Dictionary<string, Nest.IndexManagement.AliasDefinition>? Aliases { get; set; }

		[JsonPropertyName("mappings")]
		public Nest.Mapping.TypeMapping? Mappings { get; set; }

		[JsonPropertyName("settings")]
		public Nest.IndexManagement.IndexSettings? Settings { get; set; }

		[JsonPropertyName("version")]
		public Nest.VersionNumber? Version { get; set; }

		[JsonPropertyName("_meta")]
		public Nest.Metadata? Meta { get; set; }
	}

	[ConvertAs(typeof(PutSettingsRequest))]
	public partial interface IPutSettingsRequest : IRequest<PutSettingsRequestParameters>
	{
		Dictionary<string, object>? Persistent { get; set; }

		Dictionary<string, object>? Transient { get; set; }
	}

	public partial class PutSettingsRequest : PlainRequestBase<PutSettingsRequestParameters>, IPutSettingsRequest
	{
		protected IPutSettingsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutSettings;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Persistent is null && Transient is null;

		///<summary>/_cluster/settings</summary>
        public PutSettingsRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonPropertyName("persistent")]
		public Dictionary<string, object>? Persistent { get; set; }

		[JsonPropertyName("transient")]
		public Dictionary<string, object>? Transient { get; set; }
	}

	[ConvertAs(typeof(RemoteInfoRequest))]
	public partial interface IRemoteInfoRequest : IRequest<RemoteInfoRequestParameters>
	{
	}

	public partial class RemoteInfoRequest : PlainRequestBase<RemoteInfoRequestParameters>, IRemoteInfoRequest
	{
		protected IRemoteInfoRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterRemoteInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_remote/info</summary>
        public RemoteInfoRequest() : base()
		{
		}
	}

	[ConvertAs(typeof(RerouteRequest))]
	public partial interface IRerouteRequest : IRequest<RerouteRequestParameters>
	{
		IEnumerable<Nest.Cluster.Reroute.Command>? Commands { get; set; }
	}

	public partial class RerouteRequest : PlainRequestBase<RerouteRequestParameters>, IRerouteRequest
	{
		protected IRerouteRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Commands is null;

		///<summary>/_cluster/reroute</summary>
        public RerouteRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public Nest.Metrics? Metric { get => Q<Nest.Metrics?>("metric"); set => Q("metric", value); }

		[JsonIgnore]
		public bool? RetryFailed { get => Q<bool?>("retry_failed"); set => Q("retry_failed", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonPropertyName("commands")]
		public IEnumerable<Nest.Cluster.Reroute.Command>? Commands { get; set; }
	}

	[ConvertAs(typeof(StateRequest))]
	public partial interface IStateRequest : IRequest<StateRequestParameters>
	{
	}

	public partial class StateRequest : PlainRequestBase<StateRequestParameters>, IStateRequest
	{
		protected IStateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_cluster/state</summary>
        public StateRequest() : base()
		{
		}

		///<summary>/_cluster/state/{metric}</summary>
        public StateRequest(Nest.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_cluster/state/{metric}/{index}</summary>
        public StateRequest(Nest.Metrics? metric, Nest.Indices? index) : base(r => r.Optional("metric", metric).Optional("index", index))
		{
		}

		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.VersionNumber? WaitForMetadataVersion { get => Q<Nest.VersionNumber?>("wait_for_metadata_version"); set => Q("wait_for_metadata_version", value); }

		[JsonIgnore]
		public Nest.Time? WaitForTimeout { get => Q<Nest.Time?>("wait_for_timeout"); set => Q("wait_for_timeout", value); }
	}

	[ConvertAs(typeof(StatsRequest))]
	public partial interface IStatsRequest : IRequest<StatsRequestParameters>
	{
	}

	public partial class StatsRequest : PlainRequestBase<StatsRequestParameters>, IStatsRequest
	{
		protected IStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_cluster/stats</summary>
        public StatsRequest() : base()
		{
		}

		///<summary>/_cluster/stats/nodes/{node_id}</summary>
        public StatsRequest(Nest.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
		{
		}

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}
}