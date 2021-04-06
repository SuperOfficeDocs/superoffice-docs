---
uid: crmscript_ref_NSEMailAgent_GetEMailFromDocumentId
title: EMailEntity GetEMailFromDocumentId(Integer documentId)
intellisense: NSEMailAgent.GetEMailFromDocumentId
keywords: NSEMailAgent, GetEMailFromDocumentId
so.topic: reference
---

Get an e-mail based on an archived document

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
Integer documentId;
EMailEntity res = agent.GetEMailFromDocumentId(documentId);
```

