---
title: crmscript_ref_NSListAgent_GetListItemsForUserGroupFromListName
description: SelectableMDOListItemArray GetListItemsForUserGroupFromListName(String udListDefinitionName, Integer groupId)
intellisense: NSListAgent.GetListItemsForUserGroupFromListName
keywords: NSListAgent,GetListItemsForUserGroupFromListName
so.topic: reference
---

List of list items that is visible in the usergroup

**Parameters:**
 - **udListDefinitionName** The name of the list definition.
 - **groupId** The id of the usergroup

**Returns:** Array of selectable list items

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer groupId;
SelectableMDOListItemArray res = agent.GetListItemsForUserGroupFromListName(udListDefinitionName, groupId);
```

