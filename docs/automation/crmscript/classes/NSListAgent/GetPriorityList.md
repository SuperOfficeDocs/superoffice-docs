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

**Returns:** Vector of NSPriority objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetPriorityList(ids);
```

