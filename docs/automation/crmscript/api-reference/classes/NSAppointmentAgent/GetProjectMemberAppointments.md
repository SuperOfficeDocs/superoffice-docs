---
uid: crmscript_ref_NSAppointmentAgent_GetProjectMemberAppointments
title: Appointment[] GetProjectMemberAppointments(Integer personId, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSAppointmentAgent.GetProjectMemberAppointments
keywords: NSAppointmentAgent, GetProjectMemberAppointments
so.topic: reference
---

Method that returns a specified number of appointments within a time range. The appointments belong to the projects where the person specified is member.

**Parameters:**
 - **personId** The project member's person id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer personId;
DateTime startTime;
DateTime endTime;
Integer count;
Appointment[] res = agent.GetProjectMemberAppointments(personId, startTime, endTime, count);
```

