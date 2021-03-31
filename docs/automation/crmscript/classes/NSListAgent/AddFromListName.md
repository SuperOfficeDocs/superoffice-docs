---
title: crmscript_ref_NSListAgent_AddFromListName
description: ListItemEntity AddFromListName(String udListDefinitionName, ListItemEntity item)
intellisense: NSListAgent.AddFromListName
keywords: NSListAgent,AddFromListName
so.topic: reference
---

Save a new list item for the specified list defintion

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to save the item to.
 - **item** The item to save

**Returns:** The saved list item

```crmscript
NSListAgent agent;
String udListDefinitionName;
ListItemEntity item;
ListItemEntity res = agent.AddFromListName(udListDefinitionName, item);
```

