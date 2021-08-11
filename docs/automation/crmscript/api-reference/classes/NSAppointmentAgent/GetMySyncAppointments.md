---
uid: crmscript_ref_NSAppointmentAgent_GetMySyncAppointments
title: AppointmentSyncData[] GetMySyncAppointments(DateTime startTime, DateTime endTime)
intellisense: NSAppointmentAgent.GetMySyncAppointments
keywords: NSAppointmentAgent, GetMySyncAppointments
so.topic: reference
---

# AppointmentSyncData[] GetMySyncAppointments(DateTime startTime, DateTime endTime)

Method that returns a specified number of appointments within a time range. The appointments belong to the currently logged on user.

**Parameters:**
 - **startTime** The start of the time interval in which we want appointments. This will usually be the current time.
 - **endTime** The end of the time interval.

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
DateTime startTime;
DateTime endTime;
AppointmentSyncData[] res = agent.GetMySyncAppointments(startTime, endTime);
```

