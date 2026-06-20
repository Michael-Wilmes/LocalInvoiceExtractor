namespace LocalInvoiceExtractor.Domain.Interfaces;

public interface IPdfExtractor
{
    Task<string> ExtractTextAsync(string pdfPath, CancellationToken cancellationToken = default);
}
