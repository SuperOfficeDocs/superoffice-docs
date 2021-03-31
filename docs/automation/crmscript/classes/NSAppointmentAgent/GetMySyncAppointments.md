---
title: crmscript_ref_NSAppointmentAgent_GetMySyncAppointments
description: AppointmentSyncDataArray GetMySyncAppointments(DateTime startTime, DateTime endTime)
intellisense: NSAppointmentAgent.GetMySyncAppointments
keywords: NSAppointmentAgent,GetMySyncAppointments
so.topic: reference
---

Method that returns a specified number of appointments within a time range. The appointments belong to the currently logged on user.

**Parameters:**
 - **startTime** The start of the time interval in which we want appointments. This will usually be the current time.
 - **endTime** The end of the time interval.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
DateTime startTime;
DateTime endTime;
AppointmentSyncDataArray res = agent.GetMySyncAppointments(startTime, endTime);
```

