using LocalInvoiceExtractor.Core.Interfaces;
using LocalInvoiceExtractor.Domain.Models;

namespace LocalInvoiceExtractor.Core.Services;

public sealed class InvoiceProcessingService(
    IPdfExtractor pdfExtractor,
    ILlmClient llmClient)
{
    public async Task<string> ProcessAsync(
        string pdfPath,
        string fieldConfigurationJson,
        CancellationToken cancellationToken = default)
    {
        var text = await pdfExtractor.ExtractTextAsync(pdfPath, cancellationToken);

        return await llmClient.GenerateJsonAsync(
            text,
            fieldConfigurationJson,
            cancellationToken);
    }
}