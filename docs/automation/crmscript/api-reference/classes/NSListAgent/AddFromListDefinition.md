---
uid: crmscript_ref_NSListAgent_AddFromListDefinition
title: NSListItemEntity AddFromListDefinition(Integer udListDefinitionId, NSListItemEntity item)
intellisense: NSListAgent.AddFromListDefinition
keywords: NSListAgent, AddFromListDefinition
so.topic: reference
---

Save a new list item for the specified list defintion

**Parameters:**
 - **udListDefinitionId** The name of the list definition, indicating which list to save the item to.
 - **item** The item to save

**Returns:** NSListItemEntity

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
NSListItemEntity item;
NSListItemEntity res = agent.AddFromListDefinition(udListDefinitionId, item);
```

