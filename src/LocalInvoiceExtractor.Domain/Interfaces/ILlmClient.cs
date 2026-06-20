using LocalInvoiceExtractor.Domain.Models;

namespace LocalInvoiceExtractor.Domain.Interfaces;

public interface ILlmClient
{
    Task<InvoiceResult> ExtractInvoiceAsync(string invoiceText, CancellationToken cancellationToken = default);
}
