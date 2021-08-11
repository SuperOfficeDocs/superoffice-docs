---
uid: crmscript_ref_NSListAgent_SaveHeadingsFromName
title: NSHeadingEntity[] SaveHeadingsFromName(String name, NSHeadingEntity[] entities)
intellisense: NSListAgent.SaveHeadingsFromName
keywords: NSListAgent, SaveHeadingsFromName
so.topic: reference
---

# NSHeadingEntity[] SaveHeadingsFromName(String name, NSHeadingEntity[] entities)

Save headings for list resolved by the provided name.

**Parameters:**
 - **name** The name of the list to look up.
 - **entities** The headings to save

**Returns:** NSHeadingEntity[]

```crmscript
NSListAgent agent;
String name;
NSHeadingEntity[] entities;
NSHeadingEntity[] res = agent.SaveHeadingsFromName(name, entities);
```

