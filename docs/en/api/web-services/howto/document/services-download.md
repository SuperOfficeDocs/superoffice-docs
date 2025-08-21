---
uid: api-services-document-download
title: How to download a new document
description: How to download a document
keywords: document, API, services, DocumentAgent, DocumentAgent.CreateTempFile, DocumentAgent.GetDocumentEntity, DocumentEntity
author: Tony Yates
date: 06.11.2008
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: document
area: api-services
redirect_from:
  - /en/document/howto/services/download
  - /en/api/netserver/web-services/howto/document/services-download
---

# How to download a new document

The following code example demonstrates how to download the created document to a local directory and open it.

## Code

```csharp

private void DownloadDocument(int documentId)
{
  // create an DocumentAgent object and retrieve a document
  using(DocumentAgent agent = new DocumentAgent())
  {
    DocumentEntity documentEntityExisting = agent.GetDocumentEntity(documentId);

    // check if the document exists
    if (documentEntityExisting != null)
    { 
      // generate the file name for the downloaded document
      string extentionOfOriginalDocument = Path.GetExtension(documentEntityExisting.Name);
      string fileName = "tempFile" + extentionOfOriginalDocument;

      // download the document to the temporary folder
      agent.CreateTempFile(fileName, agent.GetDocumentStream(documentEntityExisting));

      // read the path for the temporary folder from the config file
      string tempFilePath = Path.Combine(SuperOffice.Configuration.ConfigFile.Documents.TemporaryPath, SoContext.CurrentPrincipal != null ? SoContext.CurrentPrincipal.Associate : "ALL");

      // full path for the downloaded document
      string fullPath = Path.Combine(tempFilePath.Replace("\\\\", "\\"), fileName);

      // open the document using the open shell command
      if (File.Exists(fullPath))
      {
        // create a process
        System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

        // pass the file name with extension to open the file
        myProcess.StartInfo.FileName = fullPath;
        myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
        myProcess.Start();
      }
      else
      {
        MessageBox.Show("The document has not been downloaded properly.");
      }
    }
    else
    {
      MessageBox.Show("The document you are trying to open does not exist in the server.");
    }
  }
}
```

## Walk-through

The first step retrieves the document using an **agent** instance, `DocumentAgent`. The `DocumentAgent.GetDocumentEntity` method is invoked to get a `DocumentEntity` instance, which contains all properties of the document you are going to download - such as header and description.

You must also provide a **name** for the file. This name becomes the temporary file name where the file is downloaded, built up, and opened.

> [!NOTE]
> Make sure the extensions of both the original and the downloaded document are the same.

Now you are ready to download the document. Use the `DocumentAgent.CreateTempFile` method to execute the download.

The example uses the `System.Diagnostics.Process` class to open the file. This ensures that the default application assigned to open this file type is launched to view the document.
