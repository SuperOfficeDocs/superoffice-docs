---
uid: crmscript_ref_NSAppointmentAgent_GetTaskListItems
title: NSTaskListItem[] GetTaskListItems(Bool includeDeleted)
intellisense: NSAppointmentAgent.GetTaskListItems
keywords: NSAppointmentAgent, GetTaskListItems
so.topic: reference
---

# NSTaskListItem[] GetTaskListItems(Bool includeDeleted)

Gets all takslist items

**Parameters:**
 - **includeDeleted** Include deleted items

**Returns:** NSTaskListItem[]

```crmscript
NSAppointmentAgent agent;
Bool includeDeleted;
NSTaskListItem[] res = agent.GetTaskListItems(includeDeleted);
```

