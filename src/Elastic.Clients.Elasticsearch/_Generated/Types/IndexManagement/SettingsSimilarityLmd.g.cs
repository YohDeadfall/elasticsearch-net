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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class SettingsSimilarityLmd
{
	[JsonInclude, JsonPropertyName("mu")]
	public int Mu { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "LMDirichlet";
}

public sealed partial class SettingsSimilarityLmdDescriptor : SerializableDescriptor<SettingsSimilarityLmdDescriptor>
{
	internal SettingsSimilarityLmdDescriptor(Action<SettingsSimilarityLmdDescriptor> configure) => configure.Invoke(this);

	public SettingsSimilarityLmdDescriptor() : base()
	{
	}

	private int MuValue { get; set; }

	public SettingsSimilarityLmdDescriptor Mu(int mu)
	{
		MuValue = mu;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("mu");
		writer.WriteNumberValue(MuValue);
		writer.WritePropertyName("type");
		writer.WriteStringValue("LMDirichlet");
		writer.WriteEndObject();
	}
}