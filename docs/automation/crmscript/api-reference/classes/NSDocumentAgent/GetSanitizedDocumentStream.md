---
uid: crmscript_ref_NSDocumentAgent_GetSanitizedDocumentStream
title: NSStream GetSanitizedDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetSanitizedDocumentStream
keywords: NSDocumentAgent, GetSanitizedDocumentStream
so.topic: reference
---

Get the document content as a stream. Retrieves a sanitized version if possible

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
Integer documentId;
NSStream res = agent.GetSanitizedDocumentStream(documentId);
```

