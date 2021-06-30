---
uid: crmscript_ref_NSAppointmentAgent_GetPublishedAppointments
title: Appointment[] GetPublishedAppointments(Integer[] appointmentIds)
intellisense: NSAppointmentAgent.GetPublishedAppointments
keywords: NSAppointmentAgent, GetPublishedAppointments
so.topic: reference
---

Get published appointments by appointment ids.

**Parameters:**
 - **appointmentIds** The array of appointment IDs

**Returns:** Array of Appointment

```crmscript
NSAppointmentAgent agent;
Integer[] appointmentIds;
Appointment[] res = agent.GetPublishedAppointments(appointmentIds);
```

