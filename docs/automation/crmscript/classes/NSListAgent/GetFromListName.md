---
uid: crmscript_ref_NSListAgent_GetFromListName
title: ListItemEntity GetFromListName(Integer id, String udListDefinitionName)
intellisense: NSListAgent.GetFromListName
keywords: NSListAgent, GetFromListName
so.topic: reference
---

Get a list item for the specified list defintion

**Parameters:**
 - **id** The identity of the list item to load
 - **udListDefinitionName** The name of the list definition, indicating which list to get the item from.

**Returns:** The loaded list item

```crmscript
NSListAgent agent;
Integer id;
String udListDefinitionName;
ListItemEntity res = agent.GetFromListName(id, udListDefinitionName);
```

