---
uid: crmscript_ref_NSListAgent_SetVisibleForUserGroups
title: NSSelectableMDOListItem[] SetVisibleForUserGroups(Integer udListDefinitionId, Integer listItemId, NSSelectableMDOListItem[] userGroups)
intellisense: NSListAgent.SetVisibleForUserGroups
keywords: NSListAgent, SetVisibleForUserGroups
so.topic: reference
---

# NSSelectableMDOListItem[] SetVisibleForUserGroups(Integer udListDefinitionId, Integer listItemId, NSSelectableMDOListItem[] userGroups)

Update User groups that this list item is visible for

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The id of the list item
 - **userGroups** The selectable user groups.

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer listItemId;
NSSelectableMDOListItem[] userGroups;
NSSelectableMDOListItem[] res = agent.SetVisibleForUserGroups(udListDefinitionId, listItemId, userGroups);
```

