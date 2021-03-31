---
title: crmscript_ref_NSAppointmentAgent_RejectWithEmailConfirmation
description: Void RejectWithEmailConfirmation(Integer appointmentId, String rejectReason, Integer updateMode)
intellisense: NSAppointmentAgent.RejectWithEmailConfirmation
keywords: NSAppointmentAgent,RejectWithEmailConfirmation
so.topic: reference
---

Rejecting an appointment invitation and send an email confirmation to the meeting organizer.

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **rejectReason** The reason the invitation was rejected.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 

**Returns:** Updated AppointmentEntity

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
String rejectReason;
Integer updateMode;
Void res = agent.RejectWithEmailConfirmation(appointmentId, rejectReason, updateMode);
```

