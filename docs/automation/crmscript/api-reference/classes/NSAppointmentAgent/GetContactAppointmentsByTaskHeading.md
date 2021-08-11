---
uid: crmscript_ref_NSAppointmentAgent_GetContactAppointmentsByTaskHeading
title: NSAppointment[] GetContactAppointmentsByTaskHeading(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer taskHeadingId)
intellisense: NSAppointmentAgent.GetContactAppointmentsByTaskHeading
keywords: NSAppointmentAgent, GetContactAppointmentsByTaskHeading
so.topic: reference
---

# NSAppointment[] GetContactAppointmentsByTaskHeading(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer taskHeadingId)

Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the contact specified. Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.

**Parameters:**
 - **contactId** The contact id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskHeadingId** The task heading id. The heading represents a grouping or filtering of tasks. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer taskHeadingId;
NSAppointment[] res = agent.GetContactAppointmentsByTaskHeading(contactId, startTime, endTime, count, taskHeadingId);
```

