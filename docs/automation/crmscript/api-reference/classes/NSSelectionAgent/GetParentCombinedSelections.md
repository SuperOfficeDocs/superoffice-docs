---
uid: crmscript_ref_NSSelectionAgent_GetParentCombinedSelections
title: Integer[] GetParentCombinedSelections(Integer selectionId)
intellisense: NSSelectionAgent.GetParentCombinedSelections
keywords: NSSelectionAgent, GetParentCombinedSelections
so.topic: reference
---

Get a list of all selection ids where the given selection is used to create a combined selection.

**Parameters:**
 - **selectionId** The selectionId to query for.

**Returns:** Array of selectionIds.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
Integer[] res = agent.GetParentCombinedSelections(selectionId);
```

