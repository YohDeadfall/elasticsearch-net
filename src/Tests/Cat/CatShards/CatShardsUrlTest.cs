﻿using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Framework;
using Tests.Framework.MockData;
using static Tests.Framework.UrlTester;

namespace Tests.Cat.CatAliases
{
	public class CatShardsUrlTest : IUrlTest
	{
		[U] public async Task Urls()
		{
			await GET("/_cat/shards")
				.Fluent(c => c.CatShards())
				.Request(c => c.CatShards(new CatShardsRequest()))
				.FluentAsync(c => c.CatShardsAsync())
				.RequestAsync(c => c.CatShardsAsync(new CatShardsRequest()))
				;

			await GET("/_cat/shards/project")
				.Fluent(c => c.CatShards(r => r.Index<Project>()))
				.Request(c => c.CatShards(new CatShardsRequest(Nest.Indices.Single<Project>())))
				.FluentAsync(c => c.CatShardsAsync(r => r.Index<Project>()))
				.RequestAsync(c => c.CatShardsAsync(new CatShardsRequest(Nest.Indices.Single<Project>())));
		}
	}
}
