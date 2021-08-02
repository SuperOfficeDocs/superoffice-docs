---
uid: crmscript_ref_NSSelectionAgent_GetDynamicSelectionCriteriaGroups
title: NSArchiveRestrictionGroup[] GetDynamicSelectionCriteriaGroups(Integer selectionId)
intellisense: NSSelectionAgent.GetDynamicSelectionCriteriaGroups
keywords: NSSelectionAgent, GetDynamicSelectionCriteriaGroups
so.topic: reference
---

Get the criteria for this dynamic selection. This call supports multiple criteria groups.

**Parameters:**
 - **selectionId** The id of the selection to add members

**Returns:** NSArchiveRestrictionGroup[]

```crmscript
NSSelectionAgent agent;
Integer selectionId;
NSArchiveRestrictionGroup[] res = agent.GetDynamicSelectionCriteriaGroups(selectionId);
```

