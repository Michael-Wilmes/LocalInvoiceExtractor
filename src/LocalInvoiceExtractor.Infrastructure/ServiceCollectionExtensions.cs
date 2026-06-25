using LocalInvoiceExtractor.Core.Interfaces;
using LocalInvoiceExtractor.Infrastructure.Configuration;
using LocalInvoiceExtractor.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<OllamaOptions>(
            configuration.GetSection(OllamaOptions.SectionName));

        services.AddTransient<IPdfExtractor, PdfExtractor>();
        services.AddTransient<ILlmClient, OllamaClient>();
        services.AddTransient<IExcelExporter, ExcelExporter>();

        return services;
    }
}