---
uid: crmscript_ref_NSAppointmentAgent_RejectWithEmailConfirmation
title: Void RejectWithEmailConfirmation(Integer appointmentId, String rejectReason, Integer updateMode)
intellisense: NSAppointmentAgent.RejectWithEmailConfirmation
keywords: NSAppointmentAgent, RejectWithEmailConfirmation
so.topic: reference
---

# Void RejectWithEmailConfirmation(Integer appointmentId, String rejectReason, Integer updateMode)

Rejecting an appointment invitation and send an email confirmation to the meeting organizer.

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
agent.RejectWithEmailConfirmation(appointmentId, rejectReason, updateMode);
```

