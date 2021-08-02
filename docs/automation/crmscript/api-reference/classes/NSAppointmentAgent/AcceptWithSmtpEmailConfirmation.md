---
uid: crmscript_ref_NSAppointmentAgent_AcceptWithSmtpEmailConfirmation
title: Void AcceptWithSmtpEmailConfirmation(Integer appointmentId, Integer updateMode, NSEMailConnectionInfo smtpEMailConnectionInfo)
intellisense: NSAppointmentAgent.AcceptWithSmtpEmailConfirmation
keywords: NSAppointmentAgent, AcceptWithSmtpEmailConfirmation
so.topic: reference
---

Accepting an appointment invitation and send an email confirmation to the meeting organizer.

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 
 - **smtpEMailConnectionInfo** Login information for outgoing smtp email server. Will be null if no login information is relevant.

**Returns:** Updated NSAppointmentEntity

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
Integer updateMode;
NSEMailConnectionInfo smtpEMailConnectionInfo;
agent.AcceptWithSmtpEmailConfirmation(appointmentId, updateMode, smtpEMailConnectionInfo);
```

