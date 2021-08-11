---
uid: crmscript_ref_NSListAgent_GetAllDocumentTemplates
title: NSDocumentTemplateEntity[] GetAllDocumentTemplates(Bool includeDeleted)
intellisense: NSListAgent.GetAllDocumentTemplates
keywords: NSListAgent, GetAllDocumentTemplates
so.topic: reference
---

# NSDocumentTemplateEntity[] GetAllDocumentTemplates(Bool includeDeleted)

Returns all templates

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSDocumentTemplateEntity[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSDocumentTemplateEntity[] res = agent.GetAllDocumentTemplates(includeDeleted);
```

