---
uid: crmscript_ref_NSListAgent_GetFromListName
title: NSListItemEntity GetFromListName(Integer id, String udListDefinitionName)
intellisense: NSListAgent.GetFromListName
keywords: NSListAgent, GetFromListName
so.topic: reference
---

Get a list item for the specified list defintion

**Parameters:**
 - **id** The identity of the list item to load
 - **udListDefinitionName** The name of the list definition, indicating which list to get the item from.

**Returns:** NSListItemEntity

```crmscript
NSListAgent agent;
Integer id;
String udListDefinitionName;
NSListItemEntity res = agent.GetFromListName(id, udListDefinitionName);
```

