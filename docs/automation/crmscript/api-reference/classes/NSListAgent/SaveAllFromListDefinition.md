---
uid: crmscript_ref_NSListAgent_SaveAllFromListDefinition
title: NSListItemEntity[] SaveAllFromListDefinition(Integer udListDefinitionId, NSListItemEntity[] items)
intellisense: NSListAgent.SaveAllFromListDefinition
keywords: NSListAgent, SaveAllFromListDefinition
so.topic: reference
---

# NSListItemEntity[] SaveAllFromListDefinition(Integer udListDefinitionId, NSListItemEntity[] items)

Save all list items for the specified list defintion

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to save the items to. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **items** The list items

**Returns:** NSListItemEntity[]

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
NSListItemEntity[] items;
NSListItemEntity[] res = agent.SaveAllFromListDefinition(udListDefinitionId, items);
```

