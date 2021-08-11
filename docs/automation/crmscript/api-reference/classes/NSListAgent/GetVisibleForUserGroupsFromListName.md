---
uid: crmscript_ref_NSListAgent_GetVisibleForUserGroupsFromListName
title: NSSelectableMDOListItem[] GetVisibleForUserGroupsFromListName(String udListDefinitionName, Integer listItemId)
intellisense: NSListAgent.GetVisibleForUserGroupsFromListName
keywords: NSListAgent, GetVisibleForUserGroupsFromListName
so.topic: reference
---

# NSSelectableMDOListItem[] GetVisibleForUserGroupsFromListName(String udListDefinitionName, Integer listItemId)

List of User groups that this list item is visible for

**Parameters:**
 - **udListDefinitionName** The name of the list definition.
 - **listItemId** The id of the list item

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer listItemId;
NSSelectableMDOListItem[] res = agent.GetVisibleForUserGroupsFromListName(udListDefinitionName, listItemId);
```

