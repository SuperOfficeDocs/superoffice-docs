---
uid: crmscript_ref_NSAppointmentAgent_GetAppointmentList
title: NSAppointment[] GetAppointmentList(Integer[]  appointmentIds);
intellisense: NSAppointmentAgent.GetAppointmentList
keywords: NSAppointmentAgent, GetAppointmentList
so.topic: reference
---

Gets a vector of Appointment objects.

**Parameters:**
 - **appointmentIds** The identifiers of the NSAppointment objects

**Returns:** Vector of NSAppointment objects

```crmscript
Integer[] ids;
NSAppointmentAgent agent;
agent.GetAppointmentList(ids);
```

