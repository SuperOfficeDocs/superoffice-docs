---
title: crmscript_ref_NSAppointmentAgent_AcceptRejected
description: AppointmentEntity AcceptRejected(Integer appointmentId, Integer updateMode)
intellisense: NSAppointmentAgent.AcceptRejected
keywords: NSAppointmentAgent,AcceptRejected
so.topic: reference
---

Accept that an invited participant has rejected your invitation or assignment.

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 

**Returns:** Updated AppointmentEntity

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
Integer updateMode;
AppointmentEntity res = agent.AcceptRejected(appointmentId, updateMode);
```

