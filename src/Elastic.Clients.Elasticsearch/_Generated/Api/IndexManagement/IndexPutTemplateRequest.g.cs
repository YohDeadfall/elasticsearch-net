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

using Elastic.Clients.Elasticsearch.Experimental;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexPutTemplateRequestParameters : RequestParameters<IndexPutTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public int? Order { get => Q<int?>("order"); set => Q("order", value); }
	}

	public partial class IndexPutTemplateRequest : PlainRequestBase<IndexPutTemplateRequestParameters>
	{
		public IndexPutTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public int? Order { get => Q<int?>("order"); set => Q("order", value); }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, IndexManagement.IAlias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_patterns")]
		public IEnumerable<string>? IndexPatterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Mapping.ITypeMapping? Mappings { get; set; }

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Dictionary<string, object>? Settings { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public object? Version { get; set; }
	}

	[JsonConverter(typeof(IndexPutTemplateRequestDescriptorConverter))]
	public partial class IndexPutTemplateRequestDescriptor : RequestDescriptorBase<IndexPutTemplateRequestDescriptor, IndexPutTemplateRequestParameters>
	{
		public IndexPutTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal Dictionary<Elastic.Clients.Elasticsearch.IndexName, IndexManagement.IAlias>? _aliases;
		internal IEnumerable<string>? _indexPatterns;
		internal Mapping.ITypeMapping? _mappings;
		internal Dictionary<string, object>? _settings;
		internal object? _version;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public IndexPutTemplateRequestDescriptor Create(bool? create) => Qs("create", create);
		public IndexPutTemplateRequestDescriptor FlatSettings(bool? flatSettings) => Qs("flat_settings", flatSettings);
		public IndexPutTemplateRequestDescriptor IncludeTypeName(bool? includeTypeName) => Qs("include_type_name", includeTypeName);
		public IndexPutTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IndexPutTemplateRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public IndexPutTemplateRequestDescriptor Order(int? order) => Qs("order", order);
		public IndexPutTemplateRequestDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName?, IndexManagement.IAlias?>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName?, IndexManagement.IAlias?>> selector) => Assign(selector, (a, v) => a._aliases = v?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName?, IndexManagement.IAlias?>()));
		public IndexPutTemplateRequestDescriptor IndexPatterns(IEnumerable<string>? indexPatterns) => Assign(indexPatterns, (a, v) => a._indexPatterns = v);
		public IndexPutTemplateRequestDescriptor Mappings(Mapping.ITypeMapping? mappings) => Assign(mappings, (a, v) => a._mappings = v);
		public IndexPutTemplateRequestDescriptor Settings(Func<FluentDictionary<string?, object?>, FluentDictionary<string?, object?>> selector) => Assign(selector, (a, v) => a._settings = v?.Invoke(new FluentDictionary<string?, object?>()));
		public IndexPutTemplateRequestDescriptor Version(object? version) => Assign(version, (a, v) => a._version = v);
	}

	internal sealed class IndexPutTemplateRequestDescriptorConverter : JsonConverter<IndexPutTemplateRequestDescriptor>
	{
		public override IndexPutTemplateRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexPutTemplateRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value._aliases is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, value._aliases, options);
			}

			if (value._indexPatterns is not null)
			{
				writer.WritePropertyName("index_patterns");
				JsonSerializer.Serialize(writer, value._indexPatterns, options);
			}

			if (value._mappings is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, value._mappings, options);
			}

			if (value._settings is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, value._settings, options);
			}

			if (value._version is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, value._version, options);
			}

			writer.WriteEndObject();
		}
	}
}