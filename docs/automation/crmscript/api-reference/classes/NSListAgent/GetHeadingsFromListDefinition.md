---
uid: crmscript_ref_NSListAgent_GetHeadingsFromListDefinition
title: NSHeadingEntity[] GetHeadingsFromListDefinition(Integer id)
intellisense: NSListAgent.GetHeadingsFromListDefinition
keywords: NSListAgent, GetHeadingsFromListDefinition
so.topic: reference
---

# NSHeadingEntity[] GetHeadingsFromListDefinition(Integer id)

Gets headings for list resolved by the provided id.

**Parameters:**
 - **id** The id of the list to look up.

**Returns:** NSHeadingEntity[]

```crmscript
NSListAgent agent;
Integer id;
NSHeadingEntity[] res = agent.GetHeadingsFromListDefinition(id);
```

