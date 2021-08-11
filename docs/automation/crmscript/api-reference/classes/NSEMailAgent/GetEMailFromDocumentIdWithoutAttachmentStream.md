---
uid: crmscript_ref_NSEMailAgent_GetEMailFromDocumentIdWithoutAttachmentStream
title: NSEMailEntity GetEMailFromDocumentIdWithoutAttachmentStream(Integer documentId)
intellisense: NSEMailAgent.GetEMailFromDocumentIdWithoutAttachmentStream
keywords: NSEMailAgent, GetEMailFromDocumentIdWithoutAttachmentStream
so.topic: reference
---

# NSEMailEntity GetEMailFromDocumentIdWithoutAttachmentStream(Integer documentId)

Get an e-mail based on an archived document

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
Integer documentId;
NSEMailEntity res = agent.GetEMailFromDocumentIdWithoutAttachmentStream(documentId);
```

