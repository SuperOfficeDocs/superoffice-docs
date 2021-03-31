---
title: crmscript_ref_NSAppointmentAgent_GetProjectMemberAppointmentsByTask
description: AppointmentArray GetProjectMemberAppointmentsByTask(Integer personId, DateTime startTime, DateTime endTime, Integer count, Integer taskId)
intellisense: NSAppointmentAgent.GetProjectMemberAppointmentsByTask
keywords: NSAppointmentAgent,GetProjectMemberAppointmentsByTask
so.topic: reference
---

Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the projects where the person specified is member. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Parameters:**
 - **personId** The project member's person id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskId** The task id. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer personId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer taskId;
AppointmentArray res = agent.GetProjectMemberAppointmentsByTask(personId, startTime, endTime, count, taskId);
```

