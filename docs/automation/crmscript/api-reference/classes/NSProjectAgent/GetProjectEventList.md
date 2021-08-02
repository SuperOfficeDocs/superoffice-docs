---
uid: crmscript_ref_NSProjectAgent_GetProjectEventList
title: NSProjectEvent[] GetProjectEventList(Integer[]  projectEventIds);
intellisense: NSProjectAgent.GetProjectEventList
keywords: NSProjectAgent, GetProjectEventList
so.topic: reference
---

Gets a vector of NSProjectEvent objects.

**Parameters:**
 - **projectEventIds** The identifiers of the NSProjectEvent objects

**Returns:** NSProjectEvent[]

```crmscript
Integer[] ids;
NSProjectAgent agent;
NSProjectEvent[] res = agent.GetProjectEventList(ids);
```

