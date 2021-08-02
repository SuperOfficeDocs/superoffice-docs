---
uid: crmscript_ref_NSListAgent_SaveHeadingFromListDefinition
title: NSHeadingEntity SaveHeadingFromListDefinition(Integer id, NSHeadingEntity entity)
intellisense: NSListAgent.SaveHeadingFromListDefinition
keywords: NSListAgent, SaveHeadingFromListDefinition
so.topic: reference
---

Save new heading for list resolved by the provided id.

**Parameters:**
 - **id** The id of the list to look up.
 - **entity** The new heading to save

**Returns:** NSHeadingEntity

```crmscript
NSListAgent agent;
Integer id;
NSHeadingEntity entity;
NSHeadingEntity res = agent.SaveHeadingFromListDefinition(id, entity);
```

