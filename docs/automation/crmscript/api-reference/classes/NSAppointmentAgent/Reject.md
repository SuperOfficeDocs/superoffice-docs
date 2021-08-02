---
uid: crmscript_ref_NSAppointmentAgent_Reject
title: Void Reject(Integer appointmentId, String rejectReason, Integer updateMode)
intellisense: NSAppointmentAgent.Reject
keywords: NSAppointmentAgent, Reject
so.topic: reference
---

Rejecting an appointment invitation

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **rejectReason** The reason the invitation was rejected.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 

**Returns:** NSAppointmentEntity

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
String rejectReason;
Integer updateMode;
agent.Reject(appointmentId, rejectReason, updateMode);
```

