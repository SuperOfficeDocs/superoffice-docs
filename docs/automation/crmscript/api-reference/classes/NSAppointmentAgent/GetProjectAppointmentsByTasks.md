---
uid: crmscript_ref_NSAppointmentAgent_GetProjectAppointmentsByTasks
title: NSAppointment[] GetProjectAppointmentsByTasks(Integer projectId, DateTime startTime, DateTime endTime, Integer count, Integer[] taskIds)
intellisense: NSAppointmentAgent.GetProjectAppointmentsByTasks
keywords: NSAppointmentAgent, GetProjectAppointmentsByTasks
so.topic: reference
---

# NSAppointment[] GetProjectAppointmentsByTasks(Integer projectId, DateTime startTime, DateTime endTime, Integer count, Integer[] taskIds)

Method that returns a specified number of appointments matching the list of appointment task types within a time range. The appointments belong to the project specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskIds** The task ids as an integer array. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer[] taskIds;
NSAppointment[] res = agent.GetProjectAppointmentsByTasks(projectId, startTime, endTime, count, taskIds);
```

