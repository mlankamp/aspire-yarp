var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddHttpForwarderWithServiceDiscovery();

var app = builder.Build();

app.MapForwarder("/api/{**catch-all}", "http://apiservice");

app.Run();