---
uid: crmscript_ref_NSAppointmentAgent_GetAppointmentHaveParticipantsWithEmail
title: Bool GetAppointmentHaveParticipantsWithEmail(Integer appointmentId)
intellisense: NSAppointmentAgent.GetAppointmentHaveParticipantsWithEmail
keywords: NSAppointmentAgent, GetAppointmentHaveParticipantsWithEmail
so.topic: reference
---

GetAppointmentHaveParticipantsWithEmail will check if any of the participants is marked to receive emails on this appointment. If no participants are defined, false will be returned.

**Parameters:**
 - **appointmentId** The appointmentId.

**Returns:** Return true or false.

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
Bool res = agent.GetAppointmentHaveParticipantsWithEmail(appointmentId);
```

