---
title: crmscript_ref_NSListAgent_GetAllFromListDefinition
description: ListItemEntityArray GetAllFromListDefinition(Integer udListDefinitionId, Bool includeDeleted)
intellisense: NSListAgent.GetAllFromListDefinition
keywords: NSListAgent,GetAllFromListDefinition
so.topic: reference
---

Get all list items for the specified list defintion

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to get the item from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **includeDeleted** Include deleted items in result?

**Returns:** The list items

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Bool includeDeleted;
ListItemEntityArray res = agent.GetAllFromListDefinition(udListDefinitionId, includeDeleted);
```

