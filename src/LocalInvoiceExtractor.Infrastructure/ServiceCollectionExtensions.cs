using LocalInvoiceExtractor.Domain.Interfaces;
using LocalInvoiceExtractor.Infrastructure.Configuration;
using LocalInvoiceExtractor.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LocalInvoiceExtractor.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IConfigurationProvider, ConfigurationProvider>();
        services.AddTransient<IPdfExtractor, PdfExtractor>();
        services.AddTransient<ILlmClient, OllamaClient>();
        services.AddTransient<IExcelExporter, ExcelExporter>();
        return services;
    }
}
