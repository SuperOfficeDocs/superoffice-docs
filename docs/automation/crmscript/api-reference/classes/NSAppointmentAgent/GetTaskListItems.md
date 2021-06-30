---
uid: crmscript_ref_NSAppointmentAgent_GetTaskListItems
title: TaskListItem[] GetTaskListItems(Bool includeDeleted)
intellisense: NSAppointmentAgent.GetTaskListItems
keywords: NSAppointmentAgent, GetTaskListItems
so.topic: reference
---

Gets all takslist items

**Parameters:**
 - **includeDeleted** Include deleted items

**Returns:** An array of tasklist items

```crmscript
NSAppointmentAgent agent;
Bool includeDeleted;
TaskListItem[] res = agent.GetTaskListItems(includeDeleted);
```

