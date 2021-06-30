---
uid: crmscript_ref_NSListAgent_SaveHeadingsFromListDefinition
title: HeadingEntity[] SaveHeadingsFromListDefinition(Integer id, HeadingEntity[] entities)
intellisense: NSListAgent.SaveHeadingsFromListDefinition
keywords: NSListAgent, SaveHeadingsFromListDefinition
so.topic: reference
---

Save headings for list resolved by the provided id.

**Parameters:**
 - **id** The id of the list to look up.
 - **entities** The headings to save

**Returns:** List of headings

```crmscript
NSListAgent agent;
Integer id;
HeadingEntity[] entities;
HeadingEntity[] res = agent.SaveHeadingsFromListDefinition(id, entities);
```

