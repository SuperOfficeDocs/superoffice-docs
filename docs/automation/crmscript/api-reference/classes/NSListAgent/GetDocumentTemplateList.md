---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateList
title: NSDocumentTemplate[] GetDocumentTemplateList(Integer[]  documentTemplateIds);
intellisense: NSListAgent.GetDocumentTemplateList
keywords: NSListAgent, GetDocumentTemplateList
so.topic: reference
---

Gets a vector of DocumentTemplate objects.

**Parameters:**
 - **documentTemplateIds** The identifiers of the NSDocumentTemplate objects

**Returns:** Vector of NSDocumentTemplate objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetDocumentTemplateList(ids);
```

