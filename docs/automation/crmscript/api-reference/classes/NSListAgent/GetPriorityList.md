---
uid: crmscript_ref_NSListAgent_GetPriorityList
title: NSPriority[] GetPriorityList(Integer[]  priorityIds);
intellisense: NSListAgent.GetPriorityList
keywords: NSListAgent, GetPriorityList
so.topic: reference
---

Gets a vector of Priority objects.

**Parameters:**
 - **priorityIds** The identifiers of the NSPriority objects

**Returns:** NSPriority[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSPriority[] res = agent.GetPriorityList(ids);
```

