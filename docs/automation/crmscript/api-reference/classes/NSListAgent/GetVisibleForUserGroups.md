---
uid: crmscript_ref_NSListAgent_GetVisibleForUserGroups
title: NSSelectableMDOListItem[] GetVisibleForUserGroups(Integer udListDefinitionId, Integer listItemId)
intellisense: NSListAgent.GetVisibleForUserGroups
keywords: NSListAgent, GetVisibleForUserGroups
so.topic: reference
---

# NSSelectableMDOListItem[] GetVisibleForUserGroups(Integer udListDefinitionId, Integer listItemId)

List of User groups that this list item is visible for

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The id of the list item

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer listItemId;
NSSelectableMDOListItem[] res = agent.GetVisibleForUserGroups(udListDefinitionId, listItemId);
```

