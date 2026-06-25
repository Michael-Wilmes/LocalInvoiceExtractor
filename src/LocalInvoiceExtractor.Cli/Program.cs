using LocalInvoiceExtractor.Core;
using LocalInvoiceExtractor.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;


var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddCore();
builder.Services.AddInfrastructure(builder.Configuration);

using var host = builder.Build();

await host.StartAsync();
await host.StopAsync();
