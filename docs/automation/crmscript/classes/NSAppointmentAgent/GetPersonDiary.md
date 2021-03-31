---
title: crmscript_ref_NSAppointmentAgent_GetPersonDiary
description: AppointmentArray GetPersonDiary(Integer personId, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSAppointmentAgent.GetPersonDiary
keywords: NSAppointmentAgent,GetPersonDiary
so.topic: reference
---

Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's diary. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.

**Parameters:**
 - **personId** The person id of the SuperOffice user (associate).
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
AppointmentArray res = agent.GetPersonDiary(personId, startTime, endTime, count);
```

