---
title: crmscript_ref_NSListAgent_GetAllDocumentTemplates
description: DocumentTemplateEntityArray GetAllDocumentTemplates(Bool includeDeleted)
intellisense: NSListAgent.GetAllDocumentTemplates
keywords: NSListAgent,GetAllDocumentTemplates
so.topic: reference
---

Returns all templates

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** Array of all template items

```crmscript
NSListAgent agent;
Bool includeDeleted;
DocumentTemplateEntityArray res = agent.GetAllDocumentTemplates(includeDeleted);
```

