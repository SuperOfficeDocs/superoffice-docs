---
uid: crmscript_ref_NSEMailAgent_GetUnsanitizedEMailFromDocumentId
title: NSEMailEntity GetUnsanitizedEMailFromDocumentId(Integer documentId)
intellisense: NSEMailAgent.GetUnsanitizedEMailFromDocumentId
keywords: NSEMailAgent, GetUnsanitizedEMailFromDocumentId
so.topic: reference
---

# NSEMailEntity GetUnsanitizedEMailFromDocumentId(Integer documentId)

Get an e-mail based on an archived document. The returned value is not sanitized.

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
Integer documentId;
NSEMailEntity res = agent.GetUnsanitizedEMailFromDocumentId(documentId);
```

