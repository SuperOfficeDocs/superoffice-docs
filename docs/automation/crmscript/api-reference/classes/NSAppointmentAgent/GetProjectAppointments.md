---
uid: crmscript_ref_NSAppointmentAgent_GetProjectAppointments
title: NSAppointment[] GetProjectAppointments(Integer projectId, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSAppointmentAgent.GetProjectAppointments
keywords: NSAppointmentAgent, GetProjectAppointments
so.topic: reference
---

# NSAppointment[] GetProjectAppointments(Integer projectId, DateTime startTime, DateTime endTime, Integer count)

Method that returns a specified number of appointments within a time range. The appointments belong to the project specified. If the logged on user is not allowed to view this projects appointments an exception is thrown.

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
NSAppointment[] res = agent.GetProjectAppointments(projectId, startTime, endTime, count);
```

