---
title: Void Delete(Integer appointmentId, Integer updateMode, Bool sendEmailToParticipants, NSEMailConnectionInfo smtpEMailConnectionInfo, NSEMailConnectionInfo imapEMailConnectionInfo)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/Void Delete(Integer p_0, Integer p_1, Bool p_2, NSEMailConnectionInfo p_3, NSEMailConnectionInfo p_4)
intellisense: 1
classref: 1
sortOrder: 914
keywords: Delete(Integer,Integer,Bool,NSEMailConnectionInfo,NSEMailConnectionInfo)
---


Deleting a booking



* **appointmentId:** The appointmentId. Both master and child record ids are accepted.
* **updateMode:** Update mode for a recurring appointment.
* **sendEmailToParticipants:** If true, emails will be sent to all participants that is marked with send email flag. If false no mails will be sent even if the send email flag is true.
* **smtpEMailConnectionInfo:** Login information for outgoing smtp email server. Will be null if no login information is relevant.
* **imapEMailConnectionInfo:** Login information for imap server. Will be null if no login information is relevant.


