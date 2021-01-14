---
title: NSStream CreateDocumentStream(NSDocumentEntity documentEntity, Bool overwriteExistingData)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSStream CreateDocumentStream(NSDocumentEntity p_0, Bool p_1)
intellisense: 1
classref: 1
sortOrder: 2514
keywords: CreateDocumentStream(NSDocumentEntity,Bool)
---


Creates a new Stream that can be used to store the document in the file archive.



* **documentEntity:** The document the stream belongs to
* **overwriteExistingData:** If true, the stream will overwrite existing data stored for this record in the document archive
* **Returns:** A writeable stream. When written and closed, the stream will become the new document content, subject to locking and versioning constraints.


