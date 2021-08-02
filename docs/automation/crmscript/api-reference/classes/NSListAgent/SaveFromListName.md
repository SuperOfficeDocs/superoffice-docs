---
uid: crmscript_ref_NSListAgent_SaveFromListName
title: NSListItemEntity SaveFromListName(Integer id, String udListDefinitionName, NSListItemEntity item)
intellisense: NSListAgent.SaveFromListName
keywords: NSListAgent, SaveFromListName
so.topic: reference
---

Save a list item for the specified list defintion

**Parameters:**
 - **id** The identity of the list item to load
 - **udListDefinitionName** The name of the list definition, indicating which list to save the item to.
 - **item** The item to save

**Returns:** NSListItemEntity

```crmscript
NSListAgent agent;
Integer id;
String udListDefinitionName;
NSListItemEntity item;
NSListItemEntity res = agent.SaveFromListName(id, udListDefinitionName, item);
```

