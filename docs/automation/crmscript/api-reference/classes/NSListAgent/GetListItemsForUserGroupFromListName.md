---
uid: crmscript_ref_NSListAgent_GetListItemsForUserGroupFromListName
title: NSSelectableMDOListItem[] GetListItemsForUserGroupFromListName(String udListDefinitionName, Integer groupId)
intellisense: NSListAgent.GetListItemsForUserGroupFromListName
keywords: NSListAgent, GetListItemsForUserGroupFromListName
so.topic: reference
---

# NSSelectableMDOListItem[] GetListItemsForUserGroupFromListName(String udListDefinitionName, Integer groupId)

List of list items that is visible in the usergroup

**Parameters:**
 - **udListDefinitionName** The name of the list definition.
 - **groupId** The id of the usergroup

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer groupId;
NSSelectableMDOListItem[] res = agent.GetListItemsForUserGroupFromListName(udListDefinitionName, groupId);
```

