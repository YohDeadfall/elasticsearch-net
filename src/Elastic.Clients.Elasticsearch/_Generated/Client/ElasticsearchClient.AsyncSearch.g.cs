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
namespace Elastic.Clients.Elasticsearch.AsyncSearch;
public sealed partial class AsyncSearchNamespace : NamespacedClientProxy
{
	internal AsyncSearchNamespace(ElasticsearchClient client) : base(client)
	{
	}

	public AsyncSearchStatusResponse Status(AsyncSearchStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequest, AsyncSearchStatusResponse>(request);
	}

	public Task<AsyncSearchStatusResponse> StatusAsync(AsyncSearchStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequest, AsyncSearchStatusResponse>(request, cancellationToken);
	}

	public AsyncSearchStatusResponse Status(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse>(descriptor);
	}

	public AsyncSearchStatusResponse Status(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse>(descriptor);
	}

	public AsyncSearchStatusResponse Status<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse>(descriptor);
	}

	public Task<AsyncSearchStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse>(descriptor);
	}

	public Task<AsyncSearchStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse>(descriptor);
	}

	public Task<AsyncSearchStatusResponse> StatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse>(descriptor);
	}

	public AsyncSearchSubmitResponse<TDocument> Submit<TDocument>(AsyncSearchSubmitRequest request)
	{
		request.BeforeRequest();
		return DoRequest<AsyncSearchSubmitRequest, AsyncSearchSubmitResponse<TDocument>>(request);
	}

	public Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(AsyncSearchSubmitRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<AsyncSearchSubmitRequest, AsyncSearchSubmitResponse<TDocument>>(request, cancellationToken);
	}

	public AsyncSearchSubmitResponse<TDocument> Submit<TDocument>()
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>>(descriptor);
	}

	public AsyncSearchSubmitResponse<TDocument> Submit<TDocument>(Action<AsyncSearchSubmitRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>>(descriptor);
	}

	public Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>>(descriptor);
	}

	public Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(Action<AsyncSearchSubmitRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>>(descriptor);
	}

	public DeleteAsyncSearchResponse Delete(DeleteAsyncSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse>(request);
	}

	public Task<DeleteAsyncSearchResponse> DeleteAsync(DeleteAsyncSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse>(request, cancellationToken);
	}

	public DeleteAsyncSearchResponse Delete(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse>(descriptor);
	}

	public DeleteAsyncSearchResponse Delete(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse>(descriptor);
	}

	public DeleteAsyncSearchResponse Delete<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse>(descriptor);
	}

	public Task<DeleteAsyncSearchResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse>(descriptor);
	}

	public Task<DeleteAsyncSearchResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse>(descriptor);
	}

	public Task<DeleteAsyncSearchResponse> DeleteAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse>(descriptor);
	}

	public GetAsyncSearchResponse<TDocument> Get<TDocument>(GetAsyncSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>>(request);
	}

	public Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(GetAsyncSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>>(request, cancellationToken);
	}

	public GetAsyncSearchResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>>(descriptor);
	}

	public GetAsyncSearchResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>>(descriptor);
	}

	public Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>>(descriptor);
	}

	public Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>>(descriptor);
	}
}