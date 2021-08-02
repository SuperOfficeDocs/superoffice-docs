---
uid: crmscript_ref_NSAppointmentAgent_GetPublishedAppointments
title: NSAppointment[] GetPublishedAppointments(Integer[] appointmentIds)
intellisense: NSAppointmentAgent.GetPublishedAppointments
keywords: NSAppointmentAgent, GetPublishedAppointments
so.topic: reference
---

Get published appointments by appointment ids.

**Parameters:**
 - **appointmentIds** The array of appointment IDs

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer[] appointmentIds;
NSAppointment[] res = agent.GetPublishedAppointments(appointmentIds);
```

