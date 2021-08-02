---
uid: crmscript_ref_NSListAgent_SetVisibleForUserGroupsFromListName
title: NSSelectableMDOListItem[] SetVisibleForUserGroupsFromListName(String udListDefinitionName, Integer listItemId, NSSelectableMDOListItem[] userGroups)
intellisense: NSListAgent.SetVisibleForUserGroupsFromListName
keywords: NSListAgent, SetVisibleForUserGroupsFromListName
so.topic: reference
---

Update User groups that this list item is visible for

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to update the items from.
 - **listItemId** The id of the list item
 - **userGroups** The selectable user groups.

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer listItemId;
NSSelectableMDOListItem[] userGroups;
NSSelectableMDOListItem[] res = agent.SetVisibleForUserGroupsFromListName(udListDefinitionName, listItemId, userGroups);
```

