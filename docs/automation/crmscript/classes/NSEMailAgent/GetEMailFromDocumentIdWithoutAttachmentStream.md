---
title: crmscript_ref_NSEMailAgent_GetEMailFromDocumentIdWithoutAttachmentStream
description: EMailEntity GetEMailFromDocumentIdWithoutAttachmentStream(Integer documentId)
intellisense: NSEMailAgent.GetEMailFromDocumentIdWithoutAttachmentStream
keywords: NSEMailAgent,GetEMailFromDocumentIdWithoutAttachmentStream
so.topic: reference
---

Get an e-mail based on an archived document

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
Integer documentId;
EMailEntity res = agent.GetEMailFromDocumentIdWithoutAttachmentStream(documentId);
```

