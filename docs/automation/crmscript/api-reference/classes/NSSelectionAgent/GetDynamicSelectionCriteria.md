---
uid: crmscript_ref_NSSelectionAgent_GetDynamicSelectionCriteria
title: NSArchiveRestrictionInfo[] GetDynamicSelectionCriteria(Integer selectionId)
intellisense: NSSelectionAgent.GetDynamicSelectionCriteria
keywords: NSSelectionAgent, GetDynamicSelectionCriteria
so.topic: reference
---

Get the criteria for this dynamic selection.

**Parameters:**
 - **selectionId** The id of the selection to add members

**Returns:** NSArchiveRestrictionInfo[]

```crmscript
NSSelectionAgent agent;
Integer selectionId;
NSArchiveRestrictionInfo[] res = agent.GetDynamicSelectionCriteria(selectionId);
```

