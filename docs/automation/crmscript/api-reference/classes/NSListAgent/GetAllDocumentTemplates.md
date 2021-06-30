---
uid: crmscript_ref_NSListAgent_GetAllDocumentTemplates
title: DocumentTemplateEntity[] GetAllDocumentTemplates(Bool includeDeleted)
intellisense: NSListAgent.GetAllDocumentTemplates
keywords: NSListAgent, GetAllDocumentTemplates
so.topic: reference
---

Returns all templates

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** Array of all template items

```crmscript
NSListAgent agent;
Bool includeDeleted;
DocumentTemplateEntity[] res = agent.GetAllDocumentTemplates(includeDeleted);
```

