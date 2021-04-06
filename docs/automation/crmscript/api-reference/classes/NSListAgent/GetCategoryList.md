---
uid: crmscript_ref_NSListAgent_GetCategoryList
title: NSCategory[] GetCategoryList(Integer[]  categoryIds);
intellisense: NSListAgent.GetCategoryList
keywords: NSListAgent, GetCategoryList
so.topic: reference
---

Gets a vector of Category objects.

**Parameters:**
 - **categoryIds** The identifiers of the NSCategory objects

**Returns:** Vector of NSCategory objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetCategoryList(ids);
```

