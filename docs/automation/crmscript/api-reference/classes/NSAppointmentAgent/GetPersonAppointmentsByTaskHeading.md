---
uid: crmscript_ref_NSAppointmentAgent_GetPersonAppointmentsByTaskHeading
title: NSAppointment[] GetPersonAppointmentsByTaskHeading(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count, Integer taskHeadingId)
intellisense: NSAppointmentAgent.GetPersonAppointmentsByTaskHeading
keywords: NSAppointmentAgent, GetPersonAppointmentsByTaskHeading
so.topic: reference
---

# NSAppointment[] GetPersonAppointmentsByTaskHeading(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count, Integer taskHeadingId)

Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.

**Parameters:**
 - **personId** The person id of the SuperOffice user (associate).
 - **includeProjectAppointments** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **taskHeadingId** The task heading id. The heading represents a grouping or filtering of tasks. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer personId;
Bool includeProjectAppointments;
DateTime startTime;
DateTime endTime;
Integer count;
Integer taskHeadingId;
NSAppointment[] res = agent.GetPersonAppointmentsByTaskHeading(personId, includeProjectAppointments, startTime, endTime, count, taskHeadingId);
```

