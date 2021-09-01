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

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.Logstash
{
	public class LogstashNamespace : NamespacedClientProxy
	{
		internal LogstashNamespace(ElasticClient client) : base(client)
		{
		}

		public DeletePipelineResponse DeletePipeline(IDeletePipelineRequest request) => DoRequest<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters);
		public Task<DeletePipelineResponse> DeletePipelineAsync(IDeletePipelineRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters, cancellationToken);
		public DeletePipelineResponse DeletePipeline(Nest.Id id, Func<DeletePipelineDescriptor, IDeletePipelineRequest> selector = null) => DeletePipeline(selector.InvokeOrDefault(new DeletePipelineDescriptor(id)));
		public Task<DeletePipelineResponse> DeletePipelineAsync(Nest.Id id, Func<DeletePipelineDescriptor, IDeletePipelineRequest> selector = null, CancellationToken cancellationToken = default) => DeletePipelineAsync(selector.InvokeOrDefault(new DeletePipelineDescriptor(id)), cancellationToken);
		public GetPipelineResponse GetPipeline(IGetPipelineRequest request) => DoRequest<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters);
		public Task<GetPipelineResponse> GetPipelineAsync(IGetPipelineRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters, cancellationToken);
		public GetPipelineResponse GetPipeline(Nest.Ids id, Func<GetPipelineDescriptor, IGetPipelineRequest> selector = null) => GetPipeline(selector.InvokeOrDefault(new GetPipelineDescriptor(id)));
		public Task<GetPipelineResponse> GetPipelineAsync(Nest.Ids id, Func<GetPipelineDescriptor, IGetPipelineRequest> selector = null, CancellationToken cancellationToken = default) => GetPipelineAsync(selector.InvokeOrDefault(new GetPipelineDescriptor(id)), cancellationToken);
		public PutPipelineResponse PutPipeline(IPutPipelineRequest request) => DoRequest<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters);
		public Task<PutPipelineResponse> PutPipelineAsync(IPutPipelineRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters, cancellationToken);
		public PutPipelineResponse PutPipeline(Nest.Id id, Func<PutPipelineDescriptor, IPutPipelineRequest> selector = null) => PutPipeline(selector.InvokeOrDefault(new PutPipelineDescriptor(id)));
		public Task<PutPipelineResponse> PutPipelineAsync(Nest.Id id, Func<PutPipelineDescriptor, IPutPipelineRequest> selector = null, CancellationToken cancellationToken = default) => PutPipelineAsync(selector.InvokeOrDefault(new PutPipelineDescriptor(id)), cancellationToken);
	}
}