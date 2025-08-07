var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres");

var apiService = builder.AddProject<Projects.Feeder_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.Feeder_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();