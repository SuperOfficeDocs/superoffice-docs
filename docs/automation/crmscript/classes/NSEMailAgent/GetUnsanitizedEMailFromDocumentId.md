---
title: crmscript_ref_NSEMailAgent_GetUnsanitizedEMailFromDocumentId
description: EMailEntity GetUnsanitizedEMailFromDocumentId(Integer documentId)
intellisense: NSEMailAgent.GetUnsanitizedEMailFromDocumentId
keywords: NSEMailAgent,GetUnsanitizedEMailFromDocumentId
so.topic: reference
---

Get an e-mail based on an archived document. The returned value is not sanitized.

**Parameters:**
 - **documentId** Unique id of the document

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
Integer documentId;
EMailEntity res = agent.GetUnsanitizedEMailFromDocumentId(documentId);
```

