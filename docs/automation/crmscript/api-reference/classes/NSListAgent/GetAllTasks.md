---
uid: crmscript_ref_NSListAgent_GetAllTasks
title: NSTaskListItem[] GetAllTasks(Bool includeDeleted)
intellisense: NSListAgent.GetAllTasks
keywords: NSListAgent, GetAllTasks
so.topic: reference
---

Returns all appointment tasks

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSTaskListItem[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSTaskListItem[] res = agent.GetAllTasks(includeDeleted);
```

