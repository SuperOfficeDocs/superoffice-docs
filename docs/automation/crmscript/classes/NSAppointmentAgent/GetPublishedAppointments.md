---
uid: crmscript_ref_NSAppointmentAgent_GetPublishedAppointments
title: AppointmentArray GetPublishedAppointments(IntegerArray appointmentIds)
intellisense: NSAppointmentAgent.GetPublishedAppointments
keywords: NSAppointmentAgent, GetPublishedAppointments
so.topic: reference
---

Get published appointments by appointment ids.

**Parameters:**
 - **appointmentIds** The array of appointment ids

**Returns:** Array of Appointment

```crmscript
NSAppointmentAgent agent;
IntegerArray appointmentIds;
AppointmentArray res = agent.GetPublishedAppointments(appointmentIds);
```

