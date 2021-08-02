---
uid: crmscript_ref_NSListAgent_AddFromListName
title: NSListItemEntity AddFromListName(String udListDefinitionName, NSListItemEntity item)
intellisense: NSListAgent.AddFromListName
keywords: NSListAgent, AddFromListName
so.topic: reference
---

Save a new list item for the specified list defintion

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to save the item to.
 - **item** The item to save

**Returns:** NSListItemEntity

```crmscript
NSListAgent agent;
String udListDefinitionName;
NSListItemEntity item;
NSListItemEntity res = agent.AddFromListName(udListDefinitionName, item);
```

