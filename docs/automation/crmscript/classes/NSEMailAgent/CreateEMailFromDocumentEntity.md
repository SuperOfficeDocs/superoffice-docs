---
title: crmscript_ref_NSEMailAgent_CreateEMailFromDocumentEntity
description: EMailEntity CreateEMailFromDocumentEntity(DocumentEntity documentEntity)
intellisense: NSEMailAgent.CreateEMailFromDocumentEntity
keywords: NSEMailAgent,CreateEMailFromDocumentEntity
so.topic: reference
---

Get an e-mail based on the provided DocumentEntity

**Parameters:**
 - **documentEntity** DocumentEntity data

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
DocumentEntity documentEntity;
EMailEntity res = agent.CreateEMailFromDocumentEntity(documentEntity);
```

