---
uid: crmscript_ref_NSListAgent_GetSelectionCategoryList
title: NSSelectionCategory[] GetSelectionCategoryList(Integer[]  selectionCategoryIds);
intellisense: NSListAgent.GetSelectionCategoryList
keywords: NSListAgent, GetSelectionCategoryList
so.topic: reference
---

Gets a vector of SelectionCategory objects.

**Parameters:**
 - **selectionCategoryIds** The identifiers of the NSSelectionCategory objects

**Returns:** Vector of NSSelectionCategory objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetSelectionCategoryList(ids);
```

