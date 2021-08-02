---
uid: crmscript_ref_NSDocumentAgent_CreateDocumentStream
title: NSStream CreateDocumentStream(NSDocumentEntity documentEntity, Bool overwriteExistingData)
intellisense: NSDocumentAgent.CreateDocumentStream
keywords: NSDocumentAgent, CreateDocumentStream
so.topic: reference
---

Creates a new NSStream that can be used to store the document in the file archive.

**Parameters:**
 - **documentEntity** The document the stream belongs to
 - **overwriteExistingData** If true, the stream will overwrite existing data stored for this record in the document archive

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
NSDocumentEntity documentEntity;
Bool overwriteExistingData;
NSStream res = agent.CreateDocumentStream(documentEntity, overwriteExistingData);
```

