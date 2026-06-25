using LocalInvoiceExtractor.Core.Interfaces;
using LocalInvoiceExtractor.Domain.Models;

namespace LocalInvoiceExtractor.Infrastructure.Services;

public sealed class OllamaClient : ILlmClient
{
    public Task<string> GenerateJsonAsync(
        string sourceText,
        string fieldConfigurationJson,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
