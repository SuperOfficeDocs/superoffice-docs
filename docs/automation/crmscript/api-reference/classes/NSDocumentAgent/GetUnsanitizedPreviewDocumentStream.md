---
uid: crmscript_ref_NSDocumentAgent_GetUnsanitizedPreviewDocumentStream
title: NSDocumentPreview GetUnsanitizedPreviewDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetUnsanitizedPreviewDocumentStream
keywords: NSDocumentAgent, GetUnsanitizedPreviewDocumentStream
so.topic: reference
---

# NSDocumentPreview GetUnsanitizedPreviewDocumentStream(Integer documentId)

Get the preview version of the document content as a stream. Retrieves an unsanitized version. This has less CPU impact but the caller must sanitize the content before presenting it to the user.

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** NSDocumentPreview

```crmscript
NSDocumentAgent agent;
Integer documentId;
NSDocumentPreview res = agent.GetUnsanitizedPreviewDocumentStream(documentId);
```

