---
uid: crmscript_ref_NSAppointmentAgent_RejectWithSmtpEmailConfirmation
title: Void RejectWithSmtpEmailConfirmation(Integer appointmentId, String rejectReason, Integer updateMode, NSEMailConnectionInfo smtpEMailConnectionInfo)
intellisense: NSAppointmentAgent.RejectWithSmtpEmailConfirmation
keywords: NSAppointmentAgent, RejectWithSmtpEmailConfirmation
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
 - **smtpEMailConnectionInfo** Login information for outgoing smtp email server. Will be null if no login information is relevant.

**Returns:** NSAppointmentEntity

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
String rejectReason;
Integer updateMode;
NSEMailConnectionInfo smtpEMailConnectionInfo;
agent.RejectWithSmtpEmailConfirmation(appointmentId, rejectReason, updateMode, smtpEMailConnectionInfo);
```

