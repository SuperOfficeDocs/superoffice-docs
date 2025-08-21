---
uid: api-services-document-update
title: How to update a document in SO_ARC
description: How to update a document in SO_ARC.
keywords: document, API, services, document agent, DocumentAgent.CreateTempFile, DocumentAgent.GetDocumentStream, DocumentAgent.SetDocumentStream, SO_ARC
author: Tony Yates
date: 06.11.2008
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: document
area: api-services
redirect_from:
  - /en/document/howto/services/update
  - /en/api/netserver/web-services/howto/document/services-update
---

# How to update a document in SO_ARC

To modify a document, we will first have to [download the document to a temporary folder][1] so that it is available locally for the user to make modifications. Once modified, the temporary file is uploaded to the document archive folder.

In the example below, the original file extension is extracted and then appended to the end of the temporary file name.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;
using System.IO;

//  The ID of the document to be updated
private void UpdateDocument(int documentId)
{
  // Create an DocumentAgent object and retrieve a document
  using(DocumentAgent agent = new DocumentAgent())
  {
    DocumentEntity documentEntityExisting = agent.GetDocumentEntity(documentId);
    // Check if the document exists
    if (documentEntityExisting != null)
    {
      // Generate the file name for the downloaded document
      string extentionOfOriginalDocument = Path.GetExtension(documentEntityExisting.Name);
      string fileName = "tempFile" + extentionOfOriginalDocument;

      // Download the document to the temporary folder
      Stream originalDocumentStream = agent.GetDocumentStream(documentId);
      agent.CreateTempFile(fileName, originalDocumentStream);

      // Close and dispose the stream
      originalDocumentStream.Close();
      originalDocumentStream.Dispose();

      // Now the file is ready to be modified../..
      // Read the path for the temporary folder from the config file
      string tempFilePath = Path.Combine(SuperOffice.Configuration.ConfigFile.Documents.TemporaryPath,
          SoContext.CurrentPrincipal != null ? SoContext.CurrentPrincipal.Associate : "ALL");

      // Full path for the downloaded document
      string fullPath = Path.Combine(tempFilePath.Replace("\\\\", "\\"), fileName);

      // Check if the temporary document exists
      if (File.Exists(fullPath))
      {
          // Assuming the user has modified the temporary file...
          // Get the file stream for the temporary local file
          Stream tempStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
          agent.SetDocumentStream(documentEntityExisting, tempStream, true);
      }
    }
  }
}
```

## Download

When calling the `DocumentAgent.CreateTempFile` method, the temporary file name and the document stream for the original document are passed into the method.

`IDocumentAgent.GetDocumentStream` is used to download the document contents from the server. The temporary filename is used for storing the contents locally and, once the file is created, you have to explicitly close, and dispose of the steam to eliminate concurrent access issues. At this point, you may modify the document.

## Upload

Assuming the modifications are done, the next step is to upload the modified document to the document archive folder. This is achieved by setting the file stream of the temporary modified file as the document stream for the original document entity. Using a `FileStream` instance, and passing in the full path to the local file, the file open mode, and the file access details, you prepare the document for upload.

The `IDocumentAgent.SetDocumentStream` method is used to do perform the actual upload. `SetDocumentStream()` requires 3 parameters:

* The original document entity
* The stream for the temporary local file
* The Boolean value specifying whether the stream will overwrite an existing file with the same name stored in the document archive

<!-- Referenced links -->
[1]: services-download.md
