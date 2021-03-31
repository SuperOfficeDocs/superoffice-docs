---
title: crmscript_ref_NSEMailAgent_GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
description: EMailEntity GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream(Integer documentId)
intellisense: NSEMailAgent.GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
keywords: NSEMailAgent,GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
so.topic: reference
---

Get an e-mail based on an archived document. The returned value is not sanitized.

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
Integer documentId;
EMailEntity res = agent.GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream(documentId);
```

