namespace LocalInvoiceExtractor.Core.Interfaces;

public interface IPdfExtractor
{
    Task<string> ExtractTextAsync(string pdfPath, CancellationToken cancellationToken = default);
}