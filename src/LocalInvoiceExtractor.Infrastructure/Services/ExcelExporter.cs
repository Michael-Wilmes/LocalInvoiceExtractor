using LocalInvoiceExtractor.Domain.Interfaces;
using LocalInvoiceExtractor.Domain.Models;

namespace LocalInvoiceExtractor.Infrastructure.Services;

public sealed class ExcelExporter : IExcelExporter
{
    public Task ExportAsync(IEnumerable<InvoiceResult> invoices, string outputPath, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
