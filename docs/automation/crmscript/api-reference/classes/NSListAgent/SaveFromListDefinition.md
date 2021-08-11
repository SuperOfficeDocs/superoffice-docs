---
uid: crmscript_ref_NSListAgent_SaveFromListDefinition
title: NSListItemEntity SaveFromListDefinition(Integer id, Integer udListDefinitionId, NSListItemEntity item)
intellisense: NSListAgent.SaveFromListDefinition
keywords: NSListAgent, SaveFromListDefinition
so.topic: reference
---

# NSListItemEntity SaveFromListDefinition(Integer id, Integer udListDefinitionId, NSListItemEntity item)

Save a list item for the specified list defintion

**Parameters:**
 - **id** The identity of the list item to load
 - **udListDefinitionId** The id of the list definition, indicating which list to save the item to. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **item** The item to save

**Returns:** NSListItemEntity

```crmscript
NSListAgent agent;
Integer id;
Integer udListDefinitionId;
NSListItemEntity item;
NSListItemEntity res = agent.SaveFromListDefinition(id, udListDefinitionId, item);
```

