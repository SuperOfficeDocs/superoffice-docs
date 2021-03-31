---
title: crmscript_ref_NSListAgent_SaveHeadingFromListDefinition
description: HeadingEntity SaveHeadingFromListDefinition(Integer id, HeadingEntity entity)
intellisense: NSListAgent.SaveHeadingFromListDefinition
keywords: NSListAgent,SaveHeadingFromListDefinition
so.topic: reference
---

Save new heading for list resolved by the provided id.

**Parameters:**
 - **id** The id of the list to look up.
 - **entity** The new heading to save

**Returns:** The saved entity.

```crmscript
NSListAgent agent;
Integer id;
HeadingEntity entity;
HeadingEntity res = agent.SaveHeadingFromListDefinition(id, entity);
```

