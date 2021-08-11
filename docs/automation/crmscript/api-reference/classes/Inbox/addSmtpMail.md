---
uid: crmscript_ref_Inbox_addSmtpMail_String_smtpMail_String_uidl_Integer_filterId
title: Inbox.addSmtpMail(String smtpMail, String uidl, Integer filterId)
intellisense: Inbox.addSmtpMail
sortOrder: 421
keywords: addSmtpMail(String,String,Integer)
so.topic: reference
---

# Inbox.addSmtpMail(String smtpMail, String uidl, Integer filterId)

With this method you can insert an SMTP formatted email into eJournal's inbox, which then will be imported when ejournalCron runs. The mail string must conform to the SMTP standard.

* **smtpMail:** A string with a SMTP formatted mail
* **uidl:** The UIDL for this email. Can be anything, but it have to be unique for each email
* **filterId:** The id of the mailbox that this mail will be imported under

* **Returns:** An integer with the id of the inserted email.

