var builder = DistributedApplication.CreateBuilder(args);

// Create the RedisResource object
var redis = builder.AddRedis("redis");

var products = builder.AddProject<Projects.Products>("products");

builder.AddProject<Projects.Store>("store")
    .WithReference(products)
    .WithReference(redis);

builder.Build().Run();
