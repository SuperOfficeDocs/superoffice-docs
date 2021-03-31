---
title: crmscript_ref_NSSelectionAgent_SetDynamicSelectionCriteria3
description: ArchiveRestrictionInfoArray SetDynamicSelectionCriteria3(Integer selectionId, ArchiveRestrictionInfoArray criteria, String filter)
intellisense: NSSelectionAgent.SetDynamicSelectionCriteria3
keywords: NSSelectionAgent,SetDynamicSelectionCriteria3
so.topic: reference
---

Update the criteria for this dynamic selection. Use criteria as either restriction objects or OData string format. Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''

**Parameters:**
 - **selectionId** The id of the selection to add members
 - **criteria** Criteria defining the selection result. Pass NULL if using the filter string instead.
 - **filter** Criteria defining the selection result in OData filter form: `category in (1,2,3) and name = 'foo'`. Pass NULL or empty string '' if using the criteria objects.

**Returns:** Criteria defining the selection result. NULL if this is not a dynamic selection.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
ArchiveRestrictionInfoArray criteria;
String filter;
ArchiveRestrictionInfoArray res = agent.SetDynamicSelectionCriteria3(selectionId, criteria, filter);
```

