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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Enrich;

public sealed partial class EnrichPolicy
{
	[JsonInclude, JsonPropertyName("elasticsearch_version")]
	public string? ElasticsearchVersion { get; set; }
	[JsonInclude, JsonPropertyName("enrich_fields")]
	public Elastic.Clients.Elasticsearch.Fields EnrichFields { get; set; }
	[JsonInclude, JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.Indices Indices { get; set; }
	[JsonInclude, JsonPropertyName("match_field")]
	public Elastic.Clients.Elasticsearch.Field MatchField { get; set; }
	[JsonInclude, JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Name? Name { get; set; }
	[JsonInclude, JsonPropertyName("query")]
	public string? Query { get; set; }
}

public sealed partial class EnrichPolicyDescriptor<TDocument> : SerializableDescriptor<EnrichPolicyDescriptor<TDocument>>
{
	internal EnrichPolicyDescriptor(Action<EnrichPolicyDescriptor<TDocument>> configure) => configure.Invoke(this);

	public EnrichPolicyDescriptor() : base()
	{
	}

	private string? ElasticsearchVersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields EnrichFieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Indices IndicesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field MatchFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }
	private string? QueryValue { get; set; }

	public EnrichPolicyDescriptor<TDocument> ElasticsearchVersion(string? elasticsearchVersion)
	{
		ElasticsearchVersionValue = elasticsearchVersion;
		return Self;
	}

	public EnrichPolicyDescriptor<TDocument> EnrichFields(Elastic.Clients.Elasticsearch.Fields enrichFields)
	{
		EnrichFieldsValue = enrichFields;
		return Self;
	}

	public EnrichPolicyDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		IndicesValue = indices;
		return Self;
	}

	public EnrichPolicyDescriptor<TDocument> MatchField(Elastic.Clients.Elasticsearch.Field matchField)
	{
		MatchFieldValue = matchField;
		return Self;
	}

	public EnrichPolicyDescriptor<TDocument> MatchField<TValue>(Expression<Func<TDocument, TValue>> matchField)
	{
		MatchFieldValue = matchField;
		return Self;
	}

	public EnrichPolicyDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		NameValue = name;
		return Self;
	}

	public EnrichPolicyDescriptor<TDocument> Query(string? query)
	{
		QueryValue = query;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ElasticsearchVersionValue))
		{
			writer.WritePropertyName("elasticsearch_version");
			writer.WriteStringValue(ElasticsearchVersionValue);
		}

		writer.WritePropertyName("enrich_fields");
		JsonSerializer.Serialize(writer, EnrichFieldsValue, options);
		writer.WritePropertyName("indices");
		JsonSerializer.Serialize(writer, IndicesValue, options);
		writer.WritePropertyName("match_field");
		JsonSerializer.Serialize(writer, MatchFieldValue, options);
		if (NameValue is not null)
		{
			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
		}

		if (!string.IsNullOrEmpty(QueryValue))
		{
			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class EnrichPolicyDescriptor : SerializableDescriptor<EnrichPolicyDescriptor>
{
	internal EnrichPolicyDescriptor(Action<EnrichPolicyDescriptor> configure) => configure.Invoke(this);

	public EnrichPolicyDescriptor() : base()
	{
	}

	private string? ElasticsearchVersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields EnrichFieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Indices IndicesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field MatchFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }
	private string? QueryValue { get; set; }

	public EnrichPolicyDescriptor ElasticsearchVersion(string? elasticsearchVersion)
	{
		ElasticsearchVersionValue = elasticsearchVersion;
		return Self;
	}

	public EnrichPolicyDescriptor EnrichFields(Elastic.Clients.Elasticsearch.Fields enrichFields)
	{
		EnrichFieldsValue = enrichFields;
		return Self;
	}

	public EnrichPolicyDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		IndicesValue = indices;
		return Self;
	}

	public EnrichPolicyDescriptor MatchField(Elastic.Clients.Elasticsearch.Field matchField)
	{
		MatchFieldValue = matchField;
		return Self;
	}

	public EnrichPolicyDescriptor MatchField<TDocument, TValue>(Expression<Func<TDocument, TValue>> matchField)
	{
		MatchFieldValue = matchField;
		return Self;
	}

	public EnrichPolicyDescriptor MatchField<TDocument>(Expression<Func<TDocument, object>> matchField)
	{
		MatchFieldValue = matchField;
		return Self;
	}

	public EnrichPolicyDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		NameValue = name;
		return Self;
	}

	public EnrichPolicyDescriptor Query(string? query)
	{
		QueryValue = query;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ElasticsearchVersionValue))
		{
			writer.WritePropertyName("elasticsearch_version");
			writer.WriteStringValue(ElasticsearchVersionValue);
		}

		writer.WritePropertyName("enrich_fields");
		JsonSerializer.Serialize(writer, EnrichFieldsValue, options);
		writer.WritePropertyName("indices");
		JsonSerializer.Serialize(writer, IndicesValue, options);
		writer.WritePropertyName("match_field");
		JsonSerializer.Serialize(writer, MatchFieldValue, options);
		if (NameValue is not null)
		{
			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
		}

		if (!string.IsNullOrEmpty(QueryValue))
		{
			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
		}

		writer.WriteEndObject();
	}
}