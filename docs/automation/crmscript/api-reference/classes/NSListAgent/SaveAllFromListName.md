---
uid: crmscript_ref_NSListAgent_SaveAllFromListName
title: ListItemEntity[] SaveAllFromListName(String udListDefinitionName, ListItemEntity[] items)
intellisense: NSListAgent.SaveAllFromListName
keywords: NSListAgent, SaveAllFromListName
so.topic: reference
---

Save all list items for the specified list defintion

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to save the items to.
 - **items** The list items

**Returns:** The list items

```crmscript
NSListAgent agent;
String udListDefinitionName;
ListItemEntity[] items;
ListItemEntity[] res = agent.SaveAllFromListName(udListDefinitionName, items);
```

