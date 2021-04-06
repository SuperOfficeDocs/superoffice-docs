---
uid: crmscript_ref_NSListAgent_SetVisibleForUserGroupsFromListName
title: SelectableMDOListItemArray SetVisibleForUserGroupsFromListName(String udListDefinitionName, Integer listItemId, SelectableMDOListItemArray userGroups)
intellisense: NSListAgent.SetVisibleForUserGroupsFromListName
keywords: NSListAgent, SetVisibleForUserGroupsFromListName
so.topic: reference
---

Update User groups that this list item is visible for

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to update the items from.
 - **listItemId** The id of the list item
 - **userGroups** The selectable user groups.

**Returns:** Array of selectable user groups

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer listItemId;
SelectableMDOListItemArray userGroups;
SelectableMDOListItemArray res = agent.SetVisibleForUserGroupsFromListName(udListDefinitionName, listItemId, userGroups);
```

