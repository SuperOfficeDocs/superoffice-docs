---
uid: crmscript_ref_NSListAgent_CreateDefaultHeadingFromListDefinition
title: HeadingEntity CreateDefaultHeadingFromListDefinition(Integer udListDefinitionId)
intellisense: NSListAgent.CreateDefaultHeadingFromListDefinition
keywords: NSListAgent, CreateDefaultHeadingFromListDefinition
so.topic: reference
---

Get a heading for the specified list defintion

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to get the item from

**Returns:** The loaded heading

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
HeadingEntity res = agent.CreateDefaultHeadingFromListDefinition(udListDefinitionId);
```

