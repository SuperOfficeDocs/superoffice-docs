---
uid: crmscript_ref_NSListAgent_GetListItemsForUserGroup
title: SelectableMDOListItem[] GetListItemsForUserGroup(Integer udListDefinitionId, Integer groupId)
intellisense: NSListAgent.GetListItemsForUserGroup
keywords: NSListAgent, GetListItemsForUserGroup
so.topic: reference
---

List of list items that is visible in the usergroup

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **groupId** The id of the usergroup

**Returns:** Array of selectable list items

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer groupId;
SelectableMDOListItem[] res = agent.GetListItemsForUserGroup(udListDefinitionId, groupId);
```

