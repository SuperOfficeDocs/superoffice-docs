---
uid: crmscript_ref_NSSelectionAgent_SetDynamicSelectionCriteriaGroups
title: NSArchiveRestrictionGroup[] SetDynamicSelectionCriteriaGroups(Integer selectionId, NSArchiveRestrictionGroup[] criteria)
intellisense: NSSelectionAgent.SetDynamicSelectionCriteriaGroups
keywords: NSSelectionAgent, SetDynamicSelectionCriteriaGroups
so.topic: reference
---

# NSArchiveRestrictionGroup[] SetDynamicSelectionCriteriaGroups(Integer selectionId, NSArchiveRestrictionGroup[] criteria)

Update the criteria for this dynamic selection. Replaces existing criteria with the new values. This call supports multiple criteria groups.

**Parameters:**
 - **selectionId** The id of the selection to add members
 - **criteria** Criteria groups defining the selection result. Empty array is legal, simply means no criteria have been set

**Returns:** NSArchiveRestrictionInfo[]

```crmscript
NSSelectionAgent agent;
Integer selectionId;
NSArchiveRestrictionGroup[] criteria;
NSArchiveRestrictionGroup[] res = agent.SetDynamicSelectionCriteriaGroups(selectionId, criteria);
```

