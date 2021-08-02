---
uid: crmscript_ref_NSListAgent_SaveAllFromListName
title: NSListItemEntity[] SaveAllFromListName(String udListDefinitionName, NSListItemEntity[] items)
intellisense: NSListAgent.SaveAllFromListName
keywords: NSListAgent, SaveAllFromListName
so.topic: reference
---

Save all list items for the specified list defintion

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to save the items to.
 - **items** The list items

**Returns:** NSListItemEntity[]

```crmscript
NSListAgent agent;
String udListDefinitionName;
NSListItemEntity[] items;
NSListItemEntity[] res = agent.SaveAllFromListName(udListDefinitionName, items);
```

