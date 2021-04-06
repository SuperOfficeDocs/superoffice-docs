---
uid: crmscript_ref_NSListAgent_SaveHeadingFromName
title: HeadingEntity SaveHeadingFromName(String name, HeadingEntity entity)
intellisense: NSListAgent.SaveHeadingFromName
keywords: NSListAgent, SaveHeadingFromName
so.topic: reference
---

Save new heading for list resolved by the provided name.

**Parameters:**
 - **name** The name of the list to look up.
 - **entity** The new heading to save

**Returns:** The saved entity.

```crmscript
NSListAgent agent;
String name;
HeadingEntity entity;
HeadingEntity res = agent.SaveHeadingFromName(name, entity);
```

