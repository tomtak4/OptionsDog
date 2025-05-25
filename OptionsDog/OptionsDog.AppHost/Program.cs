var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.OptionsDog_ApiService>("apiservice");

builder.AddProject<Projects.OptionsDog_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
