---
title: crmscript_ref_NSAppointmentAgent_Delete_Integer_p_0_Integer_p_1_Bool_p_2_NSEMailConnectionInfo_p_3_NSEMailConnectionInfo_p_4
description: NSAppointmentAgent.Delete(Integer p_0, Integer p_1, Bool p_2, NSEMailConnectionInfo p_3, NSEMailConnectionInfo p_4)
intellisense: NSAppointmentAgent.Delete
sortOrder: 914
keywords: Delete(Integer,Integer,Bool,NSEMailConnectionInfo,NSEMailConnectionInfo)
so.topic: reference
---


Deleting a booking



* **appointmentId:** The appointmentId. Both master and child record ids are accepted.
* **updateMode:** Update mode for a recurring appointment.
* **sendEmailToParticipants:** If true, emails will be sent to all participants that is marked with send email flag. If false no mails will be sent even if the send email flag is true.
* **smtpEMailConnectionInfo:** Login information for outgoing smtp email server. Will be null if no login information is relevant.
* **imapEMailConnectionInfo:** Login information for imap server. Will be null if no login information is relevant.


