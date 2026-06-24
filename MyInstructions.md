# LocalInvoiceExtractor - INSTRUCTIONS

## Current Status

- GitHub repository created
- README created
- Architecture defined
- Technology stack selected

Stack:

- .NET 10
- C#
- Docker
- Ollama
- Qwen3:8b
- PdfPig
- ClosedXML
- Spectre.Console


---

# Day 1 - Ollama Setup

## Start Docker Desktop

Verify Docker:

```bash
docker --version
docker ps
```

## Create docker-compose.yml

```yaml
services:
  ollama:
    image: ollama/ollama
    container_name: localinvoiceextractor-ollama
    ports:
      - "11434:11434"
    volumes:
      - ollama_data:/root/.ollama

volumes:
  ollama_data:
```

## Start Container

```bash
docker compose up -d
```

Verify:

```bash
docker ps
```

## Download Model

```bash
docker exec -it localinvoiceextractor-ollama ollama pull qwen3:8b
```

## Test Model

```bash
docker exec -it localinvoiceextractor-ollama ollama run qwen3:8b
```

Example:

Extract invoice date, tax amount and gross amount as JSON.

Success Criteria:

- Ollama container running
- qwen3:8b downloaded
- Model returns valid answers

---

# Day 2 - .NET Integration

Goal:

.NET -> HTTP -> Ollama -> JSON

Tasks:

- Create .NET 10 Console App
- Add HttpClient
- Send prompt to Ollama
- Receive JSON response
- Display result in console

Success Criteria:

- C# communicates with Ollama

---

# Day 3 - PDF Processing

Tasks:

- Add PdfPig
- Read Amazon PDF
- Extract text
- Send text to Ollama
- Receive structured JSON

Success Criteria:

- One PDF processed successfully

---

# Day 4 - Batch Processing

Tasks:

- Process folder of PDFs
- Add Spectre.Console progress bar
- Add logging
- Add error handling

Success Criteria:

- Multiple PDFs processed

---

# Day 5 - Excel Export

Tasks:

- Add ClosedXML
- Create Excel workbook
- Export invoice data
- Create first MVP

Pipeline:

PDF
-> Text
-> Ollama
-> JSON
-> Excel

Success Criteria:

- invoices.xlsx generated

---

# Future

- Multiple invoice types
- Amazon configuration
- eBay configuration
- Confidence scoring
- Web UI
- Docker deployment for application
- Training dataset generation

---

# Project Vision

PDF
-> Local AI
-> Structured Data
-> Excel

No cloud services.
No external AI providers.
Everything runs locally.
