---
title: crmscript_ref_NSListAgent_GetAllFromListName
description: ListItemEntityArray GetAllFromListName(String udListDefinitionName, Bool includeDeleted)
intellisense: NSListAgent.GetAllFromListName
keywords: NSListAgent,GetAllFromListName
so.topic: reference
---

Get all list items for the specified list defintion

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to get the item from.
 - **includeDeleted** Include deleted items in result?

**Returns:** The list items

```crmscript
NSListAgent agent;
String udListDefinitionName;
Bool includeDeleted;
ListItemEntityArray res = agent.GetAllFromListName(udListDefinitionName, includeDeleted);
```

