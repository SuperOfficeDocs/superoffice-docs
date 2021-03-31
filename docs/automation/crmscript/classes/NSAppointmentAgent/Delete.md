---
title: crmscript_ref_NSAppointmentAgent_Delete
description: Void Delete(Integer appointmentId, Integer updateMode, Bool sendEmailToParticipants, EMailConnectionInfo smtpEMailConnectionInfo, EMailConnectionInfo imapEMailConnectionInfo)
intellisense: NSAppointmentAgent.Delete
keywords: NSAppointmentAgent,Delete
so.topic: reference
---

Deleting a booking

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 
 - **sendEmailToParticipants** If true, emails will be sent to all participants that is marked with send email flag. If false no mails will be sent even if the send email flag is true.
 - **smtpEMailConnectionInfo** Login information for outgoing smtp email server. Will be null if no login information is relevant.
 - **imapEMailConnectionInfo** Login information for imap server. Will be null if no login information is relevant.
