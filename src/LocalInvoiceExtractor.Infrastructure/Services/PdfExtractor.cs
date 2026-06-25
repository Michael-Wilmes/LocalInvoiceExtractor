using LocalInvoiceExtractor.Core.Interfaces;

namespace LocalInvoiceExtractor.Infrastructure.Services;

public sealed class PdfExtractor : IPdfExtractor
{
    public Task<string> ExtractTextAsync(string pdfPath, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
