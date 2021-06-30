---
uid: crmscript_ref_NSAppointmentAgent_GetProjectAppointmentsByTaskHeading
title: Appointment[] GetProjectAppointmentsByTaskHeading(Integer projectId, DateTime startTime, DateTime endTime, Integer count, Integer taskHeadingId)
intellisense: NSAppointmentAgent.GetProjectAppointmentsByTaskHeading
keywords: NSAppointmentAgent, GetProjectAppointmentsByTaskHeading
so.topic: reference
---

Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the project specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskHeadingId** The task heading id. The heading represents a grouping or filtering of tasks. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer taskHeadingId;
Appointment[] res = agent.GetProjectAppointmentsByTaskHeading(projectId, startTime, endTime, count, taskHeadingId);
```

