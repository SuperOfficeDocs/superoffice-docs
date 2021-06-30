---
uid: crmscript_ref_NSSelectionAgent_GetDynamicSelectionCriteria
title: ArchiveRestrictionInfo[] GetDynamicSelectionCriteria(Integer selectionId)
intellisense: NSSelectionAgent.GetDynamicSelectionCriteria
keywords: NSSelectionAgent, GetDynamicSelectionCriteria
so.topic: reference
---

Get the criteria for this dynamic selection.

**Parameters:**
 - **selectionId** The id of the selection to add members

**Returns:** Criteria defining the selection result. NULL if selection does not exist, or if this is not a dynamic selection.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
ArchiveRestrictionInfo[] res = agent.GetDynamicSelectionCriteria(selectionId);
```

