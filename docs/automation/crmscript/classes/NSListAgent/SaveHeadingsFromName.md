---
title: crmscript_ref_NSListAgent_SaveHeadingsFromName
description: HeadingEntityArray SaveHeadingsFromName(String name, HeadingEntityArray entities)
intellisense: NSListAgent.SaveHeadingsFromName
keywords: NSListAgent,SaveHeadingsFromName
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
HeadingEntityArray entities;
HeadingEntityArray res = agent.SaveHeadingsFromName(name, entities);
```

