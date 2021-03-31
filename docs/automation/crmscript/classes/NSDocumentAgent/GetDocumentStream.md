---
title: crmscript_ref_NSDocumentAgent_GetDocumentStream
description: Stream GetDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetDocumentStream
keywords: NSDocumentAgent,GetDocumentStream
so.topic: reference
---

Get the document content as a stream

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** The document as a Stream. This stream can be read once and clients should not assume it remains valid after a ReadToEnd or Close.

```crmscript
NSDocumentAgent agent;
Integer documentId;
Stream res = agent.GetDocumentStream(documentId);
```

