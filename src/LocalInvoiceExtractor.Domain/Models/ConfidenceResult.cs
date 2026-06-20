namespace LocalInvoiceExtractor.Domain.Models;

public sealed record ConfidenceResult(decimal Score, string? Explanation);
