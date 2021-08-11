---
uid: crmscript_ref_NSListAgent_GetTaskList
title: NSTask[] GetTaskList(Integer[]  taskIds);
intellisense: NSListAgent.GetTaskList
keywords: NSListAgent, GetTaskList
so.topic: reference
---

# NSTask[] GetTaskList(Integer[]  taskIds);

Gets a vector of Task objects.

**Parameters:**
 - **taskIds** The identifiers of the NSTask objects

**Returns:** NSTask[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSTask[] res = agent.GetTaskList(ids);
```

