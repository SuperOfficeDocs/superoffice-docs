---
title: crmscript_ref_NSDocumentAgent_GetDocumentStreamFromEntity
description: Stream GetDocumentStreamFromEntity(DocumentEntity documentEntity)
intellisense: NSDocumentAgent.GetDocumentStreamFromEntity
keywords: NSDocumentAgent,GetDocumentStreamFromEntity
so.topic: reference
---

Get the document as a stream

**Parameters:**
 - **documentEntity** The document entity object that refers to the binary data (document)

**Returns:** The document as a Stream

```crmscript
NSDocumentAgent agent;
DocumentEntity documentEntity;
Stream res = agent.GetDocumentStreamFromEntity(documentEntity);
```

