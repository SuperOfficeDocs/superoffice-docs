---
title: Integer addSmtpMail(String smtpMail, String uidl, Integer filterId)
path: /EJScript/Classes/Inbox/Member functions/Integer addSmtpMail(String smtpMail, String uidl, Integer filterId)
intellisense: 1
classref: 1
sortOrder: 421
keywords: addSmtpMail(String,String,Integer)
---

With this method you can insert an SMTP formatted email into eJournal's inbox, which then will be imported when ejournalCron runs. The mail string must conform to the SMTP standard.


* **smtpMail:** A string with a SMTP formatted mail
* **uidl:** The UIDL for this email. Can be anything, but it have to be unique for each email
* **filterId:** The id of the mailbox that this mail will be imported under



* **Returns:** An integer with the id of the inserted email.


