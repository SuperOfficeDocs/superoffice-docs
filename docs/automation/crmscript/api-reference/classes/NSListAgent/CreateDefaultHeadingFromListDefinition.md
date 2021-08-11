---
uid: crmscript_ref_NSListAgent_CreateDefaultHeadingFromListDefinition
title: NSHeadingEntity CreateDefaultHeadingFromListDefinition(Integer udListDefinitionId)
intellisense: NSListAgent.CreateDefaultHeadingFromListDefinition
keywords: NSListAgent, CreateDefaultHeadingFromListDefinition
so.topic: reference
---

# NSHeadingEntity CreateDefaultHeadingFromListDefinition(Integer udListDefinitionId)

Get a heading for the specified list defintion

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to get the item from

**Returns:** NSHeadingEntity

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
NSHeadingEntity res = agent.CreateDefaultHeadingFromListDefinition(udListDefinitionId);
```

