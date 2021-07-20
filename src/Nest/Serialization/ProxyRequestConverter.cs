using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nest
{
	public class ProxyRequestConverter<TRequest> : JsonConverter<TRequest>
	{
		private readonly IElasticsearchClientSettings _settings;

		public ProxyRequestConverter(IElasticsearchClientSettings settings) => _settings = settings;

		public override TRequest? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
			throw new NotImplementedException();

		public override void Write(Utf8JsonWriter writer, TRequest value, JsonSerializerOptions options)
		{
			if (value is IProxyRequest proxyRequest) proxyRequest.WriteJson(writer, _settings.SourceSerializer);
		}
	}
}
