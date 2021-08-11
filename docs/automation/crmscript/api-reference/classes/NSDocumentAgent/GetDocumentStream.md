---
uid: crmscript_ref_NSDocumentAgent_GetDocumentStream
title: NSStream GetDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetDocumentStream
keywords: NSDocumentAgent, GetDocumentStream
so.topic: reference
---

# NSStream GetDocumentStream(Integer documentId)

Get the document content as a stream

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
Integer documentId;
NSStream res = agent.GetDocumentStream(documentId);
```

