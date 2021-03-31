---
uid: crmscript_ref_NSDocumentAgent_CreateDocumentStream
title: Stream CreateDocumentStream(DocumentEntity documentEntity, Bool overwriteExistingData)
intellisense: NSDocumentAgent.CreateDocumentStream
keywords: NSDocumentAgent, CreateDocumentStream
so.topic: reference
---

Creates a new Stream that can be used to store the document in the file archive.

**Parameters:**
 - **documentEntity** The document the stream belongs to
 - **overwriteExistingData** If true, the stream will overwrite existing data stored for this record in the document archive

**Returns:** A writeable stream. When written and closed, the stream will become the new document content, subject to locking and versioning constraints.

```crmscript
NSDocumentAgent agent;
DocumentEntity documentEntity;
Bool overwriteExistingData;
Stream res = agent.CreateDocumentStream(documentEntity, overwriteExistingData);
```

