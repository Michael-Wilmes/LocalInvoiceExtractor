using LocalInvoiceExtractor.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using DomainConfigurationProvider = LocalInvoiceExtractor.Domain.Interfaces.IConfigurationProvider;

namespace LocalInvoiceExtractor.Infrastructure.Configuration;

public sealed class ConfigurationProvider(IConfiguration configuration) : DomainConfigurationProvider
{
    public string? GetValue(string key)
    {
        return configuration[key];
    }
}
