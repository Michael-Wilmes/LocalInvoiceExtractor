using LocalInvoiceExtractor.Domain.Models;

namespace LocalInvoiceExtractor.Domain.Interfaces;

public interface IExcelExporter
{
    Task ExportAsync(IEnumerable<InvoiceResult> invoices, string outputPath, CancellationToken cancellationToken = default);
}
