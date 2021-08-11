---
uid: crmscript_ref_NSListAgent_SaveHeadingFromName
title: NSHeadingEntity SaveHeadingFromName(String name, NSHeadingEntity entity)
intellisense: NSListAgent.SaveHeadingFromName
keywords: NSListAgent, SaveHeadingFromName
so.topic: reference
---

# NSHeadingEntity SaveHeadingFromName(String name, NSHeadingEntity entity)

Save new heading for list resolved by the provided name.

**Parameters:**
 - **name** The name of the list to look up.
 - **entity** The new heading to save

**Returns:** NSHeadingEntity

```crmscript
NSListAgent agent;
String name;
NSHeadingEntity entity;
NSHeadingEntity res = agent.SaveHeadingFromName(name, entity);
```

