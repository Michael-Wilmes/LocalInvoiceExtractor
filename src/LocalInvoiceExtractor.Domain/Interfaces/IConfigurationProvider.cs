namespace LocalInvoiceExtractor.Domain.Interfaces;

public interface IConfigurationProvider
{
    string? GetValue(string key);
}
