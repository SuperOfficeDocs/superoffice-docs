---
uid: crmscript_ref_NSSelectionAgent_SetDynamicSelectionCriteria2
title: NSArchiveRestrictionInfo[] SetDynamicSelectionCriteria2(Integer selectionId, String filter)
intellisense: NSSelectionAgent.SetDynamicSelectionCriteria2
keywords: NSSelectionAgent, SetDynamicSelectionCriteria2
so.topic: reference
---

# NSArchiveRestrictionInfo[] SetDynamicSelectionCriteria2(Integer selectionId, String filter)

Update the criteria for this dynamic selection using string. Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''

**Parameters:**
 - **selectionId** The id of the selection to add members
 - **filter** Criteria defining the selection result in OData filter form: `category in (1,2,3) and name = 'foo'` 

**Returns:** NSArchiveRestrictionInfo[]

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String filter;
NSArchiveRestrictionInfo[] res = agent.SetDynamicSelectionCriteria2(selectionId, filter);
```

