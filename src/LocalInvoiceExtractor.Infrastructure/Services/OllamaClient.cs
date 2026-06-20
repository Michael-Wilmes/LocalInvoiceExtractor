using LocalInvoiceExtractor.Domain.Interfaces;
using LocalInvoiceExtractor.Domain.Models;

namespace LocalInvoiceExtractor.Infrastructure.Services;

public sealed class OllamaClient : ILlmClient
{
    public Task<InvoiceResult> ExtractInvoiceAsync(string invoiceText, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
