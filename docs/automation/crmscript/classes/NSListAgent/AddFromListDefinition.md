---
title: crmscript_ref_NSListAgent_AddFromListDefinition
description: ListItemEntity AddFromListDefinition(Integer udListDefinitionId, ListItemEntity item)
intellisense: NSListAgent.AddFromListDefinition
keywords: NSListAgent,AddFromListDefinition
so.topic: reference
---

Save a new list item for the specified list defintion

**Parameters:**
 - **udListDefinitionId** The name of the list definition, indicating which list to save the item to.
 - **item** The item to save

**Returns:** The saved list item

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
ListItemEntity item;
ListItemEntity res = agent.AddFromListDefinition(udListDefinitionId, item);
```

