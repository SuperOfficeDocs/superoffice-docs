---
uid: crmscript_ref_NSListAgent_SaveHeadingsFromName
title: HeadingEntity[] SaveHeadingsFromName(String name, HeadingEntity[] entities)
intellisense: NSListAgent.SaveHeadingsFromName
keywords: NSListAgent, SaveHeadingsFromName
so.topic: reference
---

Save headings for list resolved by the provided name.

**Parameters:**
 - **name** The name of the list to look up.
 - **entities** The headings to save

**Returns:** List of headings

```crmscript
NSListAgent agent;
String name;
HeadingEntity[] entities;
HeadingEntity[] res = agent.SaveHeadingsFromName(name, entities);
```

