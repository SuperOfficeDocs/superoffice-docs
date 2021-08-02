---
uid: crmscript_ref_NSListAgent_SaveHeadingsFromListDefinition
title: NSHeadingEntity[] SaveHeadingsFromListDefinition(Integer id, NSHeadingEntity[] entities)
intellisense: NSListAgent.SaveHeadingsFromListDefinition
keywords: NSListAgent, SaveHeadingsFromListDefinition
so.topic: reference
---

Save headings for list resolved by the provided id.

**Parameters:**
 - **id** The id of the list to look up.
 - **entities** The headings to save

**Returns:** NSHeadingEntity[]

```crmscript
NSListAgent agent;
Integer id;
NSHeadingEntity[] entities;
NSHeadingEntity[] res = agent.SaveHeadingsFromListDefinition(id, entities);
```

