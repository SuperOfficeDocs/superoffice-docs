---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateList
title: NSDocumentTemplate[] GetDocumentTemplateList(Integer[]  documentTemplateIds);
intellisense: NSListAgent.GetDocumentTemplateList
keywords: NSListAgent, GetDocumentTemplateList
so.topic: reference
---

# NSDocumentTemplate[] GetDocumentTemplateList(Integer[]  documentTemplateIds);

Gets a vector of NSDocumentTemplate objects.

**Parameters:**
 - **documentTemplateIds** The identifiers of the NSDocumentTemplate objects

**Returns:** NSDocumentTemplate[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSDocumentTemplate[] res = agent.GetDocumentTemplateList(ids);
```

