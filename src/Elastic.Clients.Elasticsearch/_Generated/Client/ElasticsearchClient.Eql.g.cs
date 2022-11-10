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
namespace Elastic.Clients.Elasticsearch.Eql;
public partial class EqlNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// Initializes a new instance of the <see cref="EqlNamespacedClient"/> class for mocking.
	/// </summary>			
	protected EqlNamespacedClient() : base()
	{
	}

	internal EqlNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	public virtual DeleteEqlResponse Delete(DeleteEqlRequest request)
	{
		request.BeforeRequest();
		return DoRequest<DeleteEqlRequest, DeleteEqlResponse, DeleteEqlRequestParameters>(request);
	}

	public virtual Task<DeleteEqlResponse> DeleteAsync(DeleteEqlRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteEqlRequest, DeleteEqlResponse, DeleteEqlRequestParameters>(request, cancellationToken);
	}

	public virtual DeleteEqlResponse Delete(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new DeleteEqlRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<DeleteEqlRequestDescriptor, DeleteEqlResponse, DeleteEqlRequestParameters>(descriptor);
	}

	public virtual DeleteEqlResponse Delete(Elastic.Clients.Elasticsearch.Id id, Action<DeleteEqlRequestDescriptor> configureRequest)
	{
		var descriptor = new DeleteEqlRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteEqlRequestDescriptor, DeleteEqlResponse, DeleteEqlRequestParameters>(descriptor);
	}

	public virtual DeleteEqlResponse Delete<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<DeleteEqlRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new DeleteEqlRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteEqlRequestDescriptor<TDocument>, DeleteEqlResponse, DeleteEqlRequestParameters>(descriptor);
	}

	public virtual Task<DeleteEqlResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteEqlRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteEqlRequestDescriptor, DeleteEqlResponse, DeleteEqlRequestParameters>(descriptor);
	}

	public virtual Task<DeleteEqlResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Id id, Action<DeleteEqlRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteEqlRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteEqlRequestDescriptor, DeleteEqlResponse, DeleteEqlRequestParameters>(descriptor);
	}

	public virtual Task<DeleteEqlResponse> DeleteAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<DeleteEqlRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteEqlRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteEqlRequestDescriptor<TDocument>, DeleteEqlResponse, DeleteEqlRequestParameters>(descriptor);
	}

	public virtual EqlGetStatusResponse GetStatus(EqlGetStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<EqlGetStatusRequest, EqlGetStatusResponse, EqlGetStatusRequestParameters>(request);
	}

	public virtual Task<EqlGetStatusResponse> GetStatusAsync(EqlGetStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<EqlGetStatusRequest, EqlGetStatusResponse, EqlGetStatusRequestParameters>(request, cancellationToken);
	}

	public virtual EqlGetStatusResponse GetStatus(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new EqlGetStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<EqlGetStatusRequestDescriptor, EqlGetStatusResponse, EqlGetStatusRequestParameters>(descriptor);
	}

	public virtual EqlGetStatusResponse GetStatus(Elastic.Clients.Elasticsearch.Id id, Action<EqlGetStatusRequestDescriptor> configureRequest)
	{
		var descriptor = new EqlGetStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<EqlGetStatusRequestDescriptor, EqlGetStatusResponse, EqlGetStatusRequestParameters>(descriptor);
	}

	public virtual EqlGetStatusResponse GetStatus<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<EqlGetStatusRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new EqlGetStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<EqlGetStatusRequestDescriptor<TDocument>, EqlGetStatusResponse, EqlGetStatusRequestParameters>(descriptor);
	}

	public virtual Task<EqlGetStatusResponse> GetStatusAsync(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlGetStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlGetStatusRequestDescriptor, EqlGetStatusResponse, EqlGetStatusRequestParameters>(descriptor);
	}

	public virtual Task<EqlGetStatusResponse> GetStatusAsync(Elastic.Clients.Elasticsearch.Id id, Action<EqlGetStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlGetStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlGetStatusRequestDescriptor, EqlGetStatusResponse, EqlGetStatusRequestParameters>(descriptor);
	}

	public virtual Task<EqlGetStatusResponse> GetStatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<EqlGetStatusRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlGetStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlGetStatusRequestDescriptor<TDocument>, EqlGetStatusResponse, EqlGetStatusRequestParameters>(descriptor);
	}

	public virtual EqlSearchResponse<TEvent> Search<TEvent>(EqlSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<EqlSearchRequest, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(request);
	}

	public virtual Task<EqlSearchResponse<TEvent>> SearchAsync<TEvent>(EqlSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<EqlSearchRequest, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(request, cancellationToken);
	}

	public virtual EqlSearchResponse<TEvent> Search<TEvent>(Elastic.Clients.Elasticsearch.Indices indices)
	{
		var descriptor = new EqlSearchRequestDescriptor(indices);
		descriptor.BeforeRequest();
		return DoRequest<EqlSearchRequestDescriptor, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(descriptor);
	}

	public virtual EqlSearchResponse<TEvent> Search<TEvent>(Elastic.Clients.Elasticsearch.Indices indices, Action<EqlSearchRequestDescriptor> configureRequest)
	{
		var descriptor = new EqlSearchRequestDescriptor(indices);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<EqlSearchRequestDescriptor, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(descriptor);
	}

	public virtual Task<EqlSearchResponse<TEvent>> SearchAsync<TEvent>(Elastic.Clients.Elasticsearch.Indices indices, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlSearchRequestDescriptor(indices);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlSearchRequestDescriptor, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(descriptor);
	}

	public virtual Task<EqlSearchResponse<TEvent>> SearchAsync<TEvent>(Elastic.Clients.Elasticsearch.Indices indices, Action<EqlSearchRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlSearchRequestDescriptor(indices);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlSearchRequestDescriptor, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(descriptor);
	}

	public virtual GetEqlResponse<TEvent> Get<TEvent>(GetEqlRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetEqlRequest, GetEqlResponse<TEvent>, GetEqlRequestParameters>(request);
	}

	public virtual Task<GetEqlResponse<TEvent>> GetAsync<TEvent>(GetEqlRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetEqlRequest, GetEqlResponse<TEvent>, GetEqlRequestParameters>(request, cancellationToken);
	}

	public virtual GetEqlResponse<TEvent> Get<TEvent>(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new GetEqlRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<GetEqlRequestDescriptor, GetEqlResponse<TEvent>, GetEqlRequestParameters>(descriptor);
	}

	public virtual GetEqlResponse<TEvent> Get<TEvent>(Elastic.Clients.Elasticsearch.Id id, Action<GetEqlRequestDescriptor> configureRequest)
	{
		var descriptor = new GetEqlRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetEqlRequestDescriptor, GetEqlResponse<TEvent>, GetEqlRequestParameters>(descriptor);
	}

	public virtual Task<GetEqlResponse<TEvent>> GetAsync<TEvent>(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetEqlRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlRequestDescriptor, GetEqlResponse<TEvent>, GetEqlRequestParameters>(descriptor);
	}

	public virtual Task<GetEqlResponse<TEvent>> GetAsync<TEvent>(Elastic.Clients.Elasticsearch.Id id, Action<GetEqlRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetEqlRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlRequestDescriptor, GetEqlResponse<TEvent>, GetEqlRequestParameters>(descriptor);
	}
}