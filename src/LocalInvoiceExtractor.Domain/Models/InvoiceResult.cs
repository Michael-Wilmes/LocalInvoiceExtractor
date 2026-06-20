namespace LocalInvoiceExtractor.Domain.Models;

public sealed record InvoiceResult(string InvoiceNumber, decimal TotalAmount, ConfidenceResult Confidence);
