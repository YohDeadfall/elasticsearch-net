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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class CommonGramsTokenFilter : TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("common_words")]
		public IReadOnlyCollection<string>? CommonWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("common_words_path")]
		public string? CommonWordsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_case")]
		public bool? IgnoreCase { get; init; }

		[JsonInclude]
		[JsonPropertyName("query_mode")]
		public bool? QueryMode { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "common_grams";
	}
}