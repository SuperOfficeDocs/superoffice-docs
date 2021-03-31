---
uid: crmscript_ref_NSAppointmentAgent_GetPersonAppointments
title: AppointmentArray GetPersonAppointments(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSAppointmentAgent.GetPersonAppointments
keywords: NSAppointmentAgent, GetPersonAppointments
so.topic: reference
---

Method that returns a specified number of appointments within a time range. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.

**Parameters:**
 - **personId** The person id of the SuperOffice user (associate).
 - **includeProjectAppointments** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer personId;
Bool includeProjectAppointments;
DateTime startTime;
DateTime endTime;
Integer count;
AppointmentArray res = agent.GetPersonAppointments(personId, includeProjectAppointments, startTime, endTime, count);
```

