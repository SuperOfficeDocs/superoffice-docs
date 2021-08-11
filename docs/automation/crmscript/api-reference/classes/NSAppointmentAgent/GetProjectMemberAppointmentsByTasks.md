---
uid: crmscript_ref_NSAppointmentAgent_GetProjectMemberAppointmentsByTasks
title: NSAppointment[] GetProjectMemberAppointmentsByTasks(Integer personId, DateTime startTime, DateTime endTime, Integer count, Integer[] taskIds)
intellisense: NSAppointmentAgent.GetProjectMemberAppointmentsByTasks
keywords: NSAppointmentAgent, GetProjectMemberAppointmentsByTasks
so.topic: reference
---

# NSAppointment[] GetProjectMemberAppointmentsByTasks(Integer personId, DateTime startTime, DateTime endTime, Integer count, Integer[] taskIds)

Method that returns a specified number of appointments matching a set of appointment task types within a time range. The appointments belong to the projects where the person specified is member. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Parameters:**
 - **personId** The project member's person id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskIds** The task IDs as an integer array. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer personId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer[] taskIds;
NSAppointment[] res = agent.GetProjectMemberAppointmentsByTasks(personId, startTime, endTime, count, taskIds);
```

