---
uid: crmscript_ref_NSListAgent_GetCategoryList
title: NSCategory[] GetCategoryList(Integer[]  categoryIds);
intellisense: NSListAgent.GetCategoryList
keywords: NSListAgent, GetCategoryList
so.topic: reference
---

Gets a vector of NSCategory objects.

**Parameters:**
 - **categoryIds** The identifiers of the NSCategory objects

**Returns:** NSCategory[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSCategory[] res = agent.GetCategoryList(ids);
```

