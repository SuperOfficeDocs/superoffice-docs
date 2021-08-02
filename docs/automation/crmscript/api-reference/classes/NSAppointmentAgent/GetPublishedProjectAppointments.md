---
uid: crmscript_ref_NSAppointmentAgent_GetPublishedProjectAppointments
title: NSAppointment[] GetPublishedProjectAppointments(Integer projectId)
intellisense: NSAppointmentAgent.GetPublishedProjectAppointments
keywords: NSAppointmentAgent, GetPublishedProjectAppointments
so.topic: reference
---

Get published appointments by project id.

**Parameters:**
 - **projectId** The project id

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer projectId;
NSAppointment[] res = agent.GetPublishedProjectAppointments(projectId);
```

