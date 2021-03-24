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

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public class ClusterAllocationExplainDescriptor : RequestDescriptorBase<ClusterAllocationExplainDescriptor, ClusterAllocationExplainRequestParameters, IClusterAllocationExplainRequest>, IClusterAllocationExplainRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterAllocationExplain;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class ClusterDeleteComponentTemplateDescriptor : RequestDescriptorBase<ClusterDeleteComponentTemplateDescriptor, ClusterDeleteComponentTemplateRequestParameters, IClusterDeleteComponentTemplateRequest>, IClusterDeleteComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class ClusterDeleteVotingConfigExclusionsDescriptor : RequestDescriptorBase<ClusterDeleteVotingConfigExclusionsDescriptor, ClusterDeleteVotingConfigExclusionsRequestParameters, IClusterDeleteVotingConfigExclusionsRequest>, IClusterDeleteVotingConfigExclusionsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class ClusterComponentTemplateExistsDescriptor : RequestDescriptorBase<ClusterComponentTemplateExistsDescriptor, ClusterComponentTemplateExistsRequestParameters, IClusterComponentTemplateExistsRequest>, IClusterComponentTemplateExistsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterExistsComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
	}

	public class ClusterGetComponentTemplateDescriptor : RequestDescriptorBase<ClusterGetComponentTemplateDescriptor, ClusterGetComponentTemplateRequestParameters, IClusterGetComponentTemplateRequest>, IClusterGetComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ClusterGetSettingsDescriptor : RequestDescriptorBase<ClusterGetSettingsDescriptor, ClusterGetSettingsRequestParameters, IClusterGetSettingsRequest>, IClusterGetSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetSettings;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ClusterHealthDescriptor : RequestDescriptorBase<ClusterHealthDescriptor, ClusterHealthRequestParameters, IClusterHealthRequest>, IClusterHealthRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ClusterPendingTasksDescriptor : RequestDescriptorBase<ClusterPendingTasksDescriptor, ClusterPendingTasksRequestParameters, IClusterPendingTasksRequest>, IClusterPendingTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ClusterPostVotingConfigExclusionsDescriptor : RequestDescriptorBase<ClusterPostVotingConfigExclusionsDescriptor, ClusterPostVotingConfigExclusionsRequestParameters, IClusterPostVotingConfigExclusionsRequest>, IClusterPostVotingConfigExclusionsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPostVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class ClusterPutComponentTemplateDescriptor : RequestDescriptorBase<ClusterPutComponentTemplateDescriptor, ClusterPutComponentTemplateRequestParameters, IClusterPutComponentTemplateRequest>, IClusterPutComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class ClusterPutSettingsDescriptor : RequestDescriptorBase<ClusterPutSettingsDescriptor, ClusterPutSettingsRequestParameters, IClusterPutSettingsRequest>, IClusterPutSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutSettings;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class RemoteInfoDescriptor : RequestDescriptorBase<RemoteInfoDescriptor, RemoteInfoRequestParameters, IRemoteInfoRequest>, IRemoteInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterRemoteInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ClusterRerouteDescriptor : RequestDescriptorBase<ClusterRerouteDescriptor, ClusterRerouteRequestParameters, IClusterRerouteRequest>, IClusterRerouteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class ClusterStateDescriptor : RequestDescriptorBase<ClusterStateDescriptor, ClusterStateRequestParameters, IClusterStateRequest>, IClusterStateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ClusterStatsDescriptor : RequestDescriptorBase<ClusterStatsDescriptor, ClusterStatsRequestParameters, IClusterStatsRequest>, IClusterStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}
}