---
uid: crmscript_ref_NSEMailAgent_GetEmailDocumentAsMimeStream
title: Stream GetEmailDocumentAsMimeStream(Integer documentId)
intellisense: NSEMailAgent.GetEmailDocumentAsMimeStream
keywords: NSEMailAgent, GetEmailDocumentAsMimeStream
so.topic: reference
---

Gets a particular document, and tries to parse it, and returns it in MIME/RFC822 format.

**Parameters:**
 - **documentId** SuperOffice document ID

**Returns:** A document-stream representing the document in MIME/RFC822 format.

```crmscript
NSEMailAgent agent;
Integer documentId;
Stream res = agent.GetEmailDocumentAsMimeStream(documentId);
```

