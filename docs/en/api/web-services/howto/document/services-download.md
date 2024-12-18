---
uid: api-services-document-download
title: How to download a new document
description: How to download a document
keywords: document, API, services, DocumentAgent, DocumentAgent.CreateTempFile, DocumentAgent.GetDocumentEntity, DocumentEntity
author: Tony Yates
date: 06.11.2008
version: 10
topic: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: document
area: api-services
---

# How to download a new document

The following code example demonstrates how to download the created document to a local directory and open it.

## Code

[!code-csharp[CS](includes/download-document.cs)]

## Walk-through

The first step retrieves the document using an **agent** instance, `DocumentAgent`. The `DocumentAgent.GetDocumentEntity` method is invoked to get a `DocumentEntity` instance, which contains all properties of the document you are going to download - such as header and description.

You must also provide a **name** for the file. This name becomes the temporary file name where the file is downloaded, built up, and opened.

> [!NOTE]
> Make sure the extensions of both the original and the downloaded document are the same.

Now you are ready to download the document. Use the `DocumentAgent.CreateTempFile` method to execute the download.

The example uses the `System.Diagnostics.Process` class to open the file. This ensures that the default application assigned to open this file type is launched to view the document.
