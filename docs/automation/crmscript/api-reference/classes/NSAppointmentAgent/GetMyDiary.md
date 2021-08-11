---
uid: crmscript_ref_NSAppointmentAgent_GetMyDiary
title: NSAppointment[] GetMyDiary(DateTime startTime, DateTime endTime, Integer count)
intellisense: NSAppointmentAgent.GetMyDiary
keywords: NSAppointmentAgent, GetMyDiary
so.topic: reference
---

# NSAppointment[] GetMyDiary(DateTime startTime, DateTime endTime, Integer count)

Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's diary. The appointments belong to the currently logged on user.

**Parameters:**
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
DateTime startTime;
DateTime endTime;
Integer count;
NSAppointment[] res = agent.GetMyDiary(startTime, endTime, count);
```

