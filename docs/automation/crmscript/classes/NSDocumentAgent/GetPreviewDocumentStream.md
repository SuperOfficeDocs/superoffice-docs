---
uid: crmscript_ref_NSDocumentAgent_GetPreviewDocumentStream
title: DocumentPreview GetPreviewDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetPreviewDocumentStream
keywords: NSDocumentAgent, GetPreviewDocumentStream
so.topic: reference
---

Get the preview version of the document content as a stream. Retrieves a sanitized version if possible

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** Preview version of the document

```crmscript
NSDocumentAgent agent;
Integer documentId;
DocumentPreview res = agent.GetPreviewDocumentStream(documentId);
```

