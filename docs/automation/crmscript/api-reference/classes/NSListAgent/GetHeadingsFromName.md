---
uid: crmscript_ref_NSListAgent_GetHeadingsFromName
title: NSHeadingEntity[] GetHeadingsFromName(String name)
intellisense: NSListAgent.GetHeadingsFromName
keywords: NSListAgent, GetHeadingsFromName
so.topic: reference
---

# NSHeadingEntity[] GetHeadingsFromName(String name)

Gets headings for list resolved by the provided name.

**Parameters:**
 - **name** The name of the list to look up.

**Returns:** NSHeadingEntity[]

```crmscript
NSListAgent agent;
String name;
NSHeadingEntity[] res = agent.GetHeadingsFromName(name);
```

