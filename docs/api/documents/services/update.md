---
title: update_document_services
description: How to update a document in SO\_ARC
author: {github-id}             # Your GitHub alias.
so.date:
so.topic: howto
so.category: document
so.area: api-services
keywords:
---

# How to update a document in SO\_ARC

To modify a document, we will first have to [download the document to a temporary folder][1] so that it is available locally for the user to make modifications. Once modified, the temporary file is uploaded to the document archive folder.

In the example below, the original file extension is extracted and then appended to the end of the temporary file name.

[!code-csharp[CS](includes/update-document.cs)]

## Download

When calling the `DocumentAgent.CreateTempFile` method, the temporary file name and the document stream for the original document are passed into the method.

`DocumentAgent.GetDocumentStream` is used to download the document contents from the server. The temp filename is used for storing the contents locally and, once the file is created, you have to explicitly close, and dispose the steam to eliminate concurrent access issues. At this point, you may modify the document.

## Upload

Assuming the modifications are done, the next step is to upload the modified document to the document archive folder. This is achieved by setting the file stream of the temporary modified file as the document stream for the original document entity. Using a `FileStream` instance, and passing in the full path to the local file, the file open mode, and the file access details, you prepare the document for upload.

The `DocumentAgent.SetDocumentStream` method is used to do perform the actual upload. `SetDocumentStream()` requires 3 parameters:

* the original document entity
* the stream for the temporary local file
* the Boolean value specifying whether the stream will overwrite an existing file with the same name stored in the document archive

<!-- Referenced links -->
[1]: download.md
