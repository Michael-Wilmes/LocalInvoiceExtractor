# Getting Started

Welcome to LocalInvoiceExtractor.

This guide will help you get the local AI environment up and running in a few minutes.

---

## Prerequisites

Install:

- Docker Desktop
- Git

Verify Docker:

```powershell
docker --version
docker ps
```

Docker Desktop must be running before continuing.

---

## Clone Repository

```powershell
git clone <repository-url>
cd LocalInvoiceExtractor
```

---

## Start Ollama

The project uses Ollama running inside Docker.

From the repository root:

```powershell
docker compose up -d
```

Verify that the container is running:

```powershell
docker ps
```

Expected container:

```text
localinvoiceextractor-ollama
```

---

## Download AI Model

Download the required language model:

```powershell
docker exec -it localinvoiceextractor-ollama ollama pull qwen3:8b
```

The first download may take several minutes.

---

## Verify Installation

Run the model interactively:

```powershell
docker exec -it localinvoiceextractor-ollama ollama run qwen3:8b
```

Try the following prompt:

```text
Extract invoice date, tax amount and gross amount as JSON.
```

If the model returns a response, the installation is successful.

---

## Verify Ollama API

Open your browser:

```text
http://localhost:11434
```

You should see:

```text
Ollama is running
```

---

## Useful Commands

### Start Ollama

```powershell
docker compose up -d
```

### Stop Ollama

```powershell
docker compose down
```

### View Logs

```powershell
docker logs localinvoiceextractor-ollama
```

### Show Running Containers

```powershell
docker ps
```

### Show All Containers

```powershell
docker ps -a
```

### Show Installed Models

```powershell
docker exec -it localinvoiceextractor-ollama ollama list
```

---

## Run Your First Prompt

Start an interactive chat session:

```powershell
docker exec -it localinvoiceextractor-ollama ollama run qwen3:8b
```

You should see a prompt similar to:

```text
>>>
```

Enter a test prompt:

```text
Extract invoice date, tax amount and gross amount as JSON.
```

Example response:

```json
{
  "invoiceDate": "2025-01-15",
  "taxAmount": 19.95,
  "grossAmount": 124.95
}
```

Press:

```text
Ctrl + D
```

to exit the interactive session.

---

## Verify Installed Models

Check whether the model was downloaded successfully:

```powershell
docker exec -it localinvoiceextractor-ollama ollama list
```

Expected output:

```text
NAME       ID       SIZE
qwen3:8b   xxxxx    x.x GB
```

---

## Stept 1 Success Criteria

Day 1 is complete when:

- Docker Desktop is running
- Ollama container is running
- qwen3:8b is downloaded
- The model responds to prompts
- Ollama is reachable at `http://localhost:11434`

Congratulations. Your local AI environment is ready.

---

## What's Next?

Step 2 focuses on .NET integration.

Goal:

```text
.NET Console App
    ↓
HttpClient
    ↓
Ollama API
    ↓
JSON Response
```


---

## Architecture Overview

```text
PDF Invoice
    ↓
PdfPig
    ↓
Extracted Text
    ↓
Ollama (Qwen3:8b)
    ↓
Structured JSON
    ↓
ClosedXML
    ↓
Excel Workbook
```

---

## Project Vision

```text
PDF
    ↓
Local AI
    ↓
Structured Data
    ↓
Excel
```

No cloud services.

No external AI providers.

Everything runs locally.
