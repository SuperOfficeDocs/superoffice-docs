---
uid: crmscript_ref_NSAppointmentAgent_Save
title: NSAppointmentEntity Save(NSAppointmentEntity appointmentEntity, Integer updateMode, Bool sendEmailToParticipants, NSEMailConnectionInfo smtpEMailConnectionInfo, NSEMailConnectionInfo imapEMailConnectionInfo)
intellisense: NSAppointmentAgent.Save
keywords: NSAppointmentAgent, Save
so.topic: reference
---

Saving a booking.

**Parameters:**
 - **appointmentEntity** 
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 
 - **sendEmailToParticipants** If true, emails will be sent to all participants that is marked with send email flag. If false no mails will be sent even if the send email flag is true.
 - **smtpEMailConnectionInfo** Login information for outgoing smtp email server. Will be null if no login information is relevant.
 - **imapEMailConnectionInfo** Login information for imap server. Will be null if no login information is relevant.

**Returns:** NSAppointmentEntity

```crmscript
NSAppointmentAgent agent;
NSAppointmentEntity appointmentEntity;
Integer updateMode;
Bool sendEmailToParticipants;
NSEMailConnectionInfo smtpEMailConnectionInfo;
NSEMailConnectionInfo imapEMailConnectionInfo;
NSAppointmentEntity res = agent.Save(appointmentEntity, updateMode, sendEmailToParticipants, smtpEMailConnectionInfo, imapEMailConnectionInfo);
```

