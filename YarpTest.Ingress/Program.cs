var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddHttpForwarderWithServiceDiscovery();

var app = builder.Build();

app.MapForwarder("/api/{**catch-all}", "https+http://apiservice");

app.Run();