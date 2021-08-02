---
uid: crmscript_ref_NSEMailAgent_GetEmailDocumentAsMimeStream
title: NSStream GetEmailDocumentAsMimeStream(Integer documentId)
intellisense: NSEMailAgent.GetEmailDocumentAsMimeStream
keywords: NSEMailAgent, GetEmailDocumentAsMimeStream
so.topic: reference
---

Gets a particular document, and tries to parse it, and returns it in MIME/RFC822 format.

**Parameters:**
 - **documentId** SuperOffice document ID

**Returns:** NSStream

```crmscript
NSEMailAgent agent;
Integer documentId;
NSStream res = agent.GetEmailDocumentAsMimeStream(documentId);
```

