---
uid: crmscript_ref_NSListAgent_GetFromListDefinition
title: NSListItemEntity GetFromListDefinition(Integer id, Integer udListDefinitionId)
intellisense: NSListAgent.GetFromListDefinition
keywords: NSListAgent, GetFromListDefinition
so.topic: reference
---

# NSListItemEntity GetFromListDefinition(Integer id, Integer udListDefinitionId)

Get a list item for the specified list defintion

**Parameters:**
 - **id** The identity of the list item to load
 - **udListDefinitionId** The id of the list definition, indicating which list to get the item from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.

**Returns:** NSListItemEntity

```crmscript
NSListAgent agent;
Integer id;
Integer udListDefinitionId;
NSListItemEntity res = agent.GetFromListDefinition(id, udListDefinitionId);
```

