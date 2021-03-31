---
uid: crmscript_ref_NSListAgent_SaveFromListDefinition
title: ListItemEntity SaveFromListDefinition(Integer id, Integer udListDefinitionId, ListItemEntity item)
intellisense: NSListAgent.SaveFromListDefinition
keywords: NSListAgent, SaveFromListDefinition
so.topic: reference
---

Save a list item for the specified list defintion

**Parameters:**
 - **id** The identity of the list item to load
 - **udListDefinitionId** The id of the list definition, indicating which list to save the item to. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **item** The item to save

**Returns:** The saved list item

```crmscript
NSListAgent agent;
Integer id;
Integer udListDefinitionId;
ListItemEntity item;
ListItemEntity res = agent.SaveFromListDefinition(id, udListDefinitionId, item);
```

