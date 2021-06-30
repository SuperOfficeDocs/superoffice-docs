---
uid: crmscript_ref_NSAppointmentAgent_GetContactAppointmentsByTask
title: Appointment[] GetContactAppointmentsByTask(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer taskId)
intellisense: NSAppointmentAgent.GetContactAppointmentsByTask
keywords: NSAppointmentAgent, GetContactAppointmentsByTask
so.topic: reference
---

Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the contact specified. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Parameters:**
 - **contactId** The contact id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskId** The task id. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer taskId;
Appointment[] res = agent.GetContactAppointmentsByTask(contactId, startTime, endTime, count, taskId);
```

