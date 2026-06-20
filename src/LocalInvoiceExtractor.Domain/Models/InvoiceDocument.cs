namespace LocalInvoiceExtractor.Domain.Models;

public sealed record InvoiceDocument(string FilePath, string RawText);
