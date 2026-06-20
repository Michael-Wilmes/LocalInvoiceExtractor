using LocalInvoiceExtractor.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LocalInvoiceExtractor.Core;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddTransient<InvoiceProcessingService>();
        return services;
    }
}
