---
uid: crmscript_ref_NSDocumentAgent_GetSanitizedDocumentStream
title: Stream GetSanitizedDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetSanitizedDocumentStream
keywords: NSDocumentAgent, GetSanitizedDocumentStream
so.topic: reference
---

Get the document content as a stream. Retrieves a sanitized version if possible

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** The document as a Stream. This stream can be read once and clients should not assume it remains valid after a ReadToEnd or Close.

```crmscript
NSDocumentAgent agent;
Integer documentId;
Stream res = agent.GetSanitizedDocumentStream(documentId);
```

