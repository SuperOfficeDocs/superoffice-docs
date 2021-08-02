---
uid: crmscript_ref_NSAppointmentAgent_GetContactAppointments
title: NSAppointment[] GetContactAppointments(Integer contactId, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSAppointmentAgent.GetContactAppointments
keywords: NSAppointmentAgent, GetContactAppointments
so.topic: reference
---

Method that returns a specified number of appointments within a time range. The appointments belong to the contact specified. If the logged on user is not allowed to view this persons appointments an exception is thrown.

**Parameters:**
 - **contactId** The contact id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
NSAppointment[] res = agent.GetContactAppointments(contactId, startTime, endTime, count);
```

