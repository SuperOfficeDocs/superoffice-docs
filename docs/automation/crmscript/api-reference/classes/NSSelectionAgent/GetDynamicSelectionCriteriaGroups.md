---
uid: crmscript_ref_NSSelectionAgent_GetDynamicSelectionCriteriaGroups
title: ArchiveRestrictionGroup[] GetDynamicSelectionCriteriaGroups(Integer selectionId)
intellisense: NSSelectionAgent.GetDynamicSelectionCriteriaGroups
keywords: NSSelectionAgent, GetDynamicSelectionCriteriaGroups
so.topic: reference
---

Get the criteria for this dynamic selection. This call supports multiple criteria groups.

**Parameters:**
 - **selectionId** The id of the selection to add members

**Returns:** Criteria groups defining the selection result. NULL if selection does not exist, or if this is not a dynamic selection.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
ArchiveRestrictionGroup[] res = agent.GetDynamicSelectionCriteriaGroups(selectionId);
```

