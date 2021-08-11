---
uid: crmscript_ref_NSDocumentAgent_GetPreviewDocumentStream
title: NSDocumentPreview GetPreviewDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetPreviewDocumentStream
keywords: NSDocumentAgent, GetPreviewDocumentStream
so.topic: reference
---

# NSDocumentPreview GetPreviewDocumentStream(Integer documentId)

Get the preview version of the document content as a stream. Retrieves a sanitized version if possible

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** NSDocumentPreview

```crmscript
NSDocumentAgent agent;
Integer documentId;
NSDocumentPreview res = agent.GetPreviewDocumentStream(documentId);
```

