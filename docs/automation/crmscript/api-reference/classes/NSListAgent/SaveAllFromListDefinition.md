---
uid: crmscript_ref_NSListAgent_SaveAllFromListDefinition
title: ListItemEntity[] SaveAllFromListDefinition(Integer udListDefinitionId, ListItemEntity[] items)
intellisense: NSListAgent.SaveAllFromListDefinition
keywords: NSListAgent, SaveAllFromListDefinition
so.topic: reference
---

Save all list items for the specified list defintion

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to save the items to. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **items** The list items

**Returns:** The list items

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
ListItemEntity[] items;
ListItemEntity[] res = agent.SaveAllFromListDefinition(udListDefinitionId, items);
```

