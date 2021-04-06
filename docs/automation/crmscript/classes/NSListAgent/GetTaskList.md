---
uid: crmscript_ref_NSListAgent_GetTaskList
title: NSTask[] GetTaskList(Integer[]  taskIds);
intellisense: NSListAgent.GetTaskList
keywords: NSListAgent, GetTaskList
so.topic: reference
---

Gets a vector of Task objects.

**Parameters:**
 - **taskIds** The identifiers of the NSTask objects

**Returns:** Vector of NSTask objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetTaskList(ids);
```

