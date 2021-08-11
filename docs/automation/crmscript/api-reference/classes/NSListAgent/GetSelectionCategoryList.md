---
uid: crmscript_ref_NSListAgent_GetSelectionCategoryList
title: NSSelectionCategory[] GetSelectionCategoryList(Integer[]  selectionCategoryIds);
intellisense: NSListAgent.GetSelectionCategoryList
keywords: NSListAgent, GetSelectionCategoryList
so.topic: reference
---

# NSSelectionCategory[] GetSelectionCategoryList(Integer[]  selectionCategoryIds);

Gets a vector of SelectionCategory objects.

**Parameters:**
 - **selectionCategoryIds** The identifiers of the NSSelectionCategory objects

**Returns:** NSSelectionCategory[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSSelectionCategory[] res = agent.GetSelectionCategoryList(ids);
```

