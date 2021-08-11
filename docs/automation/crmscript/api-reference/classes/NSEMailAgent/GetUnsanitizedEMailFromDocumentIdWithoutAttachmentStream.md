---
uid: crmscript_ref_NSEMailAgent_GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
title: NSEMailEntity GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream(Integer documentId)
intellisense: NSEMailAgent.GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
keywords: NSEMailAgent, GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
so.topic: reference
---

# NSEMailEntity GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream(Integer documentId)

Get an e-mail based on an archived document. The returned value is not sanitized.

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
Integer documentId;
NSEMailEntity res = agent.GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream(documentId);
```

