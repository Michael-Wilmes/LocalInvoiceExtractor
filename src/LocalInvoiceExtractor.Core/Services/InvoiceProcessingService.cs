using LocalInvoiceExtractor.Domain.Interfaces;
using LocalInvoiceExtractor.Domain.Models;

namespace LocalInvoiceExtractor.Core.Services;

public sealed class InvoiceProcessingService(
    IPdfExtractor pdfExtractor,
    ILlmClient llmClient)
{
    public async Task<InvoiceResult> ProcessAsync(string pdfPath, CancellationToken cancellationToken = default)
    {
        var text = await pdfExtractor.ExtractTextAsync(pdfPath, cancellationToken);
        return await llmClient.ExtractInvoiceAsync(text, cancellationToken);
    }
}
