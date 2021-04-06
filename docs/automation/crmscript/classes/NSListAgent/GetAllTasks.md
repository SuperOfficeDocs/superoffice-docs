---
uid: crmscript_ref_NSListAgent_GetAllTasks
title: TaskListItemArray GetAllTasks(Bool includeDeleted)
intellisense: NSListAgent.GetAllTasks
keywords: NSListAgent, GetAllTasks
so.topic: reference
---

Returns all appointment tasks

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** An array of all available tasks

```crmscript
NSListAgent agent;
Bool includeDeleted;
TaskListItemArray res = agent.GetAllTasks(includeDeleted);
```

