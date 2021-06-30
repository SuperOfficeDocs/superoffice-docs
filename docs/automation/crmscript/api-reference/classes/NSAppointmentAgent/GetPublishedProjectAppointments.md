---
uid: crmscript_ref_NSAppointmentAgent_GetPublishedProjectAppointments
title: Appointment[] GetPublishedProjectAppointments(Integer projectId)
intellisense: NSAppointmentAgent.GetPublishedProjectAppointments
keywords: NSAppointmentAgent, GetPublishedProjectAppointments
so.topic: reference
---

Get published appointments by project id.

**Parameters:**
 - **projectId** The project id

**Returns:** Array of Appointment

```crmscript
NSAppointmentAgent agent;
Integer projectId;
Appointment[] res = agent.GetPublishedProjectAppointments(projectId);
```

