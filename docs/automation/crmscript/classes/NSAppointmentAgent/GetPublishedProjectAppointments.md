---
title: crmscript_ref_NSAppointmentAgent_GetPublishedProjectAppointments
description: AppointmentArray GetPublishedProjectAppointments(Integer projectId)
intellisense: NSAppointmentAgent.GetPublishedProjectAppointments
keywords: NSAppointmentAgent,GetPublishedProjectAppointments
so.topic: reference
---

Get published appointments by project id.

**Parameters:**
 - **projectId** The project id

**Returns:** Array of Appointment

```crmscript
NSAppointmentAgent agent;
Integer projectId;
AppointmentArray res = agent.GetPublishedProjectAppointments(projectId);
```

