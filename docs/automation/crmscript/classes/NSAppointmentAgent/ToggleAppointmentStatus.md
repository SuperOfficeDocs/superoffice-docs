---
title: crmscript_ref_NSAppointmentAgent_ToggleAppointmentStatus
description: Integer ToggleAppointmentStatus(Integer appointmentId)
intellisense: NSAppointmentAgent.ToggleAppointmentStatus
keywords: NSAppointmentAgent,ToggleAppointmentStatus
so.topic: reference
---

Sets an appointment's status to Completed if the appointment had a different status, or sets the status to started if already set to completed.

**Parameters:**
 - **appointmentId** The appointment id.

**Returns:** The new AppointmentStatus

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
Integer res = agent.ToggleAppointmentStatus(appointmentId);
```

