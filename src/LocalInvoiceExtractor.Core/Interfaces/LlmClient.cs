namespace LocalInvoiceExtractor.Core.Interfaces;

public interface ILlmClient
{
    Task<string> GenerateJsonAsync(
        string sourceText,
        string fieldConfigurationJson,
        CancellationToken cancellationToken = default);
}