---
title: crmscript_ref_NSProjectAgent_GetProjectEventList
description: NSProjectEvent[] GetProjectEventList(Integer[]  projectEventIds);
intellisense: NSProjectAgent.GetProjectEventList
keywords: NSProjectAgent,GetProjectEventList
so.topic: reference
---

Gets a vector of ProjectEvent objects.

**Parameters:**
 - **projectEventIds** The identifiers of the NSProjectEvent objects

**Returns:** Vector of NSProjectEvent objects

```crmscript
Integer[] ids;
NSProjectAgent agent;
agent.GetProjectEventList(ids);
```

