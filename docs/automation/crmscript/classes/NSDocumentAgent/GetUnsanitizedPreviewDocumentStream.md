---
title: crmscript_ref_NSDocumentAgent_GetUnsanitizedPreviewDocumentStream
description: DocumentPreview GetUnsanitizedPreviewDocumentStream(Integer documentId)
intellisense: NSDocumentAgent.GetUnsanitizedPreviewDocumentStream
keywords: NSDocumentAgent,GetUnsanitizedPreviewDocumentStream
so.topic: reference
---

Get the preview version of the document content as a stream. Retrieves an unsanitized version. This has less CPU impact but the caller must sanitize the content before presenting it to the user.

**Parameters:**
 - **documentId** SuperOffice document id

**Returns:** Unsanitized preview version of the document

```crmscript
NSDocumentAgent agent;
Integer documentId;
DocumentPreview res = agent.GetUnsanitizedPreviewDocumentStream(documentId);
```

