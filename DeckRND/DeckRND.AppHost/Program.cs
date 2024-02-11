var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var apiservice = builder.AddProject<Projects.DeckRND_ApiService>("apiservice");

builder.AddProject<Projects.DeckRND_Web>("webfrontend")
	.WithReference(cache)
	.WithReference(apiservice);

builder.Build().Run();
