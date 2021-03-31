---
title: crmscript_ref_NSListAgent_SaveFromListName
description: ListItemEntity SaveFromListName(Integer id, String udListDefinitionName, ListItemEntity item)
intellisense: NSListAgent.SaveFromListName
keywords: NSListAgent,SaveFromListName
so.topic: reference
---

Save a list item for the specified list defintion

**Parameters:**
 - **id** The identity of the list item to load
 - **udListDefinitionName** The name of the list definition, indicating which list to save the item to.
 - **item** The item to save

**Returns:** The saved list item

```crmscript
NSListAgent agent;
Integer id;
String udListDefinitionName;
ListItemEntity item;
ListItemEntity res = agent.SaveFromListName(id, udListDefinitionName, item);
```

