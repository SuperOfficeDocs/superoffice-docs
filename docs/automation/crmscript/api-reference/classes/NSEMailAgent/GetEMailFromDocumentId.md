---
uid: crmscript_ref_NSEMailAgent_GetEMailFromDocumentId
title: NSEMailEntity GetEMailFromDocumentId(Integer documentId)
intellisense: NSEMailAgent.GetEMailFromDocumentId
keywords: NSEMailAgent, GetEMailFromDocumentId
so.topic: reference
---

# NSEMailEntity GetEMailFromDocumentId(Integer documentId)

Get an e-mail based on an archived document

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
Integer documentId;
NSEMailEntity res = agent.GetEMailFromDocumentId(documentId);
```

