---
uid: crmscript_ref_NSAppointmentAgent_GetProjectAppointmentsByTask
title: Appointment[] GetProjectAppointmentsByTask(Integer projectId, DateTime startTime, DateTime endTime, Integer count, Integer taskId)
intellisense: NSAppointmentAgent.GetProjectAppointmentsByTask
keywords: NSAppointmentAgent, GetProjectAppointmentsByTask
so.topic: reference
---

Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the project specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskId** The task id. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer taskId;
Appointment[] res = agent.GetProjectAppointmentsByTask(projectId, startTime, endTime, count, taskId);
```

