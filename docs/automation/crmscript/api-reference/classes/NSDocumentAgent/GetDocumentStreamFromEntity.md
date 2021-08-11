---
uid: crmscript_ref_NSDocumentAgent_GetDocumentStreamFromEntity
title: NSStream GetDocumentStreamFromEntity(NSDocumentEntity documentEntity)
intellisense: NSDocumentAgent.GetDocumentStreamFromEntity
keywords: NSDocumentAgent, GetDocumentStreamFromEntity
so.topic: reference
---

# NSStream GetDocumentStreamFromEntity(NSDocumentEntity documentEntity)

Get the document as a stream

**Parameters:**
 - **documentEntity** The document entity object that refers to the binary data (document)

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
NSDocumentEntity documentEntity;
NSStream res = agent.GetDocumentStreamFromEntity(documentEntity);
```

