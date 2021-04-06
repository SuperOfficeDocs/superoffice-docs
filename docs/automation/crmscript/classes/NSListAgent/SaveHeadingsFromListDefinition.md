---
uid: crmscript_ref_NSListAgent_SaveHeadingsFromListDefinition
title: HeadingEntityArray SaveHeadingsFromListDefinition(Integer id, HeadingEntityArray entities)
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
HeadingEntityArray entities;
HeadingEntityArray res = agent.SaveHeadingsFromListDefinition(id, entities);
```

