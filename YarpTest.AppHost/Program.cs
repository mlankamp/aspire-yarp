var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.YarpTest_ApiService>("apiservice");

var ingress = builder.AddProject<Projects.YarpTest_Ingress>("ingress")
    .WithReference(apiService)
    .WithExternalHttpEndpoints();

builder.Build().Run();