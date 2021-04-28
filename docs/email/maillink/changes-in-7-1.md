---
title: Changes in 7.1
uid: changes_in_7_1
description: SuperOffice Mail Link 7.1
author: Hans Oluf Waaler
keywords:
so.topic: reference
so.date: 24 Jun 2012
---

# SuperOffice Mail Link 7.1

This is a blog post about some of the changes in Mail Link 7.1.

Feel free to comment about what you want more information about.

## FAQ

### Q: As a consultant, I wrote a script which executed when you archived a document. How can I do this with Mail Link?

A: Mail Link now ships with the possibility to run commands when an appoinment or a document has been archived. If you enable "Automatically update SuperOffice", the default behaviour is to find the entity in your SuperOffice through soprotocol. If you wish to customize this behaviour, you have the possibiltity to edit two user preferences, SoDocumentArchivedExecuteCommand and SoAppointmentArchivedExecuteCommand. These two preferences point to the command you wish to execute after a document or an appointment is archived through Mail Link. The file you are executing must be available on the client computer. Mail Link supports argument substitution. For instance {documentId} will return the document id.

The supported arguments you can use in the command line are:

* contactId
* documentId
* appointmentId
* ticket

Example:

"c:\\soscripts\\archived\_document.vbs" {documentId} {contactId}

The command must be enclosed in quotes if it contains spaces.

### Q: When I navigate to a company in the SuperOffice client, this company is not in my history list in Mail Link

A: The SuperOffice client caches its history lists and persist it when closing the application. Since MailLink talks directly to NetServer, MailLink is unaware of the locally cached history list in the SuperOffice client.

Update 19.09.2013: In 7.1 SR2 the windows and web client update the history list in the database more frequently.
### Q: I have configured SuperOffice to run with the /iniPath argument. How do I make Mail Link use this?

A: There is no longer an implicit connection between the SuperOffice client and Mail Link. MailLink is unaware of which IniPath you have used to start the client. You have however, the possibility to configure MailLink to start with a given IniPath. This is a registry setting stored in the MailLink registry. The key is called UseIniPathForWindowsClient and should be your iniPath argument excluding "/iniPath=".  Be aware of the following: When using lookup sender, we use soprotocol in the interaction. SoProtocol might point to the wrong database when using iniPath. Note that Outlook must be restarted after you have done this change in the registry.
