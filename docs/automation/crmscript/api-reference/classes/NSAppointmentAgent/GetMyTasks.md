---
uid: crmscript_ref_NSAppointmentAgent_GetMyTasks
title: NSAppointment[] GetMyTasks(Integer count)
intellisense: NSAppointmentAgent.GetMyTasks
keywords: NSAppointmentAgent, GetMyTasks
so.topic: reference
---

# NSAppointment[] GetMyTasks(Integer count)

Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's task list. The appointments belong to the currently logged on user.

**Parameters:**
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer count;
NSAppointment[] res = agent.GetMyTasks(count);
```

