---
uid: crmscript_ref_NSListAgent_GetHeadingsFromListDefinition
title: HeadingEntityArray GetHeadingsFromListDefinition(Integer id)
intellisense: NSListAgent.GetHeadingsFromListDefinition
keywords: NSListAgent, GetHeadingsFromListDefinition
so.topic: reference
---

Gets headings for list resolved by the provided id.

**Parameters:**
 - **id** The id of the list to look up.

**Returns:** List of headings

```crmscript
NSListAgent agent;
Integer id;
HeadingEntityArray res = agent.GetHeadingsFromListDefinition(id);
```

