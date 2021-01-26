---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_mail       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Mail # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Mail

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Mail'
```

Email synchronization and mail sending and receiving. These preferences control all sorts of sending and receiving of email and faxes.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AddressSeparator | Use this character to delimit email addresses. | ';'  | Text | Admin, Crm, Admin users, Wizard |
| ArchiveAppointments | Always proposes archiving appointments you send from SuperOffice by email.<br>This means that, by default, you will be asked if you want to archive all appointments sent by email. | | Bool | Admin, Admin users, Wizard |
| ArchiveDocuments | Always proposes archiving documents you send from SuperOffice by email. This means that, by default, you will be asked if you want to archive all documents sent by email. | | Bool | Admin, Admin users, Wizard |
| ArchiveForwards | Always proposes archiving email forwarded from SuperOffice.<br>This means that, by default, you will be asked if you want to archive all email you forward. | | Bool | Admin, Admin users, Wizard |
| ArchiveReplies | Always proposes archiving replies to emails that are archived in SuperOffice. This means that, by default, you will be asked if you want to archive all email you reply to. | | Bool | Admin, Admin users, Wizard |
| ArchiveSentMsg | Always proposes archiving email created in SuperOffice. This means that, by default, you will be asked if you want to archive all email you create. | | Bool | Admin, Admin users, Wizard |
| ArchiveToAssocs | Always proposes archiving email written internally to your associates using SuperOffice. This means that, by default, you will be asked if you want to archive all email sent to associates. | | Bool | Admin, Admin users, Wizard |
| AttachiCal | Attach an iCalendar file to email invitations. iCalendar is a standard format for exchanging calendar and schedule information. | Yes | Bool | Admin, Admin users, Wizard |
| BookingAssociatesSubList | Preference used to remember the setup/status of the list | | Number | Wizard |
| CloseAfterArchive | Close the email after it has been archived from SuperOffice | YES | Bool | Admin, Admin users, Wizard |
| CreateExtUserSubject | Header used in email sent when generating external users. | | Text | Admin, Admin users, Wizard |
| DocSender | E-mail client used to send documents in SuperOffice. | | List | Admin, Admin users, Wizard |
| FaxSender | Fax plug-in used to send faxes from SuperOffice | | List | Admin, Admin users, Wizard |
| MailSender | E-mail client used to send email in SuperOffice | | List | Admin, Admin users, Wizard |
| EnableMailSync | Enables synchronisation between the SuperOffice inbox and your external email program | | Bool | Admin, Crm, Admin users, Wizard |
| FirstMailSync | Number of seconds until first synchronisation on startup | | Number | Admin, Crm, Admin users, Wizard |
| ForceConfirmationEmailInvit | Displays a confirmation dialog before invitations are sent by email. | No | Bool | Admin, Admin users, Wizard |
| ImapServerName | Name of the IMAP4 Mail server used by SuperOffice. Enter the DNS name or the IP address (e.g. mail.server.com or 10.0.0.100) | | Text | Admin, Admin users, Wizard |
| ImapServerPort | The port number your mail server uses to access email using the IMAP protocol. | 143 | Number | Admin, Admin users, Wizard |
| Inbox | Email client used for your in SuperOffice inbox.<br>Inboxes other than the default SuperOffice one require a separate plugin. | | List | Admin, Crm, Admin users, Wizard |
| IsEmailInstalled | Is there currently an email client available on this computer? This option enables certain aspects of email functionality. | YES | Bool | Admin, Crm, Admin users, Wizard |
| IsFaxInstalled | Is there a fax plugin installed in the email client that allows faxes to be sent by email? This option enables certain aspects of fax functionality. | YES | Bool | Admin, Crm, Admin users, Wizard |
| MailGatewayDisplayName | The display name of the SuperOffice Mail Gateway's email address | | Text | Admin, Admin users, Wizard |
| MailGatewayMailAddress | The SuperOffice Mail Gateway's email address | | Text | Admin, Admin users, Wizard |
| MailSmtpAuthorize | The SMTP server requires authentication before you can send email. | NO | Bool | Admin, Admin users, Wizard |
| MailSyncTimer | Number of seconds between each synchronization | | Number | Admin, Crm, Admin users, Wizard |
| MarkAsReadInPreview | Marks the email as read once it has been displayed in the preview pane. If you set this to No, you need to open the email before it is marked as read. | NO | Bool | Admin, Admin users, Wizard |
| NameDeleted | Specifies the name of the IMAP folder that contains your deleted email. | Deleted items | Text | Admin, Admin users, Wizard |
| NameDrafts | Specifies the name of the IMAP folder that is used to store email drafts. | Drafts | Text | Admin, Admin users, Wizard |
| NameInbox | Specifies the name of the IMAP folder used as your email inbox. | Inbox | Text | Admin, Admin users, Wizard |
| NameSent | Specifies the name of the IMAP folder that is used to store sent email. | Sent Items | Text | Admin, Admin users, Wizard |
| NotifyAssociateByMail | Notifies an associate by email when invited to an appointment | | Bool | Admin, Crm, Admin users, Wizard |
| NotifyExtPersonByMail | Notifies a contact by email when invited to an appointment | | Bool | Admin, Admin users, Wizard |
| NotifyOnlineUsers | Users who are logged on will be notified about changes to invitations | | Bool | Wizard |
| RemoveAfterArchive | Deletes the email from your inbox after you have archived it in SuperOffice | NO | Bool | Admin, Admin users, Wizard |
| SaveLogonInfo | Saves an encrypted version of your user name and password for the email server in the database. This saves you having to enter your user name and password each time you want to access your inbox. | NO | Bool | Admin, Admin users, Wizard |
| SendFaxPrefix | Format for fax numbers to be sent by email. &lt;faxs&gt; is the fax number and &lt;name&gt; is the company name, e.g. FAX:&lt;name&gt;@&lt;faxs&gt; produces FAX:SuperOffice ASA@22517001 | | Text | Admin, Admin users, Wizard |
| SendFaxProtocol | Protocol used by your email server to send a fax. | FAX | Text | Admin, Crm, Admin users, Wizard |
| SmtpServerName | Name of the SMTP Mail server used by SuperOffice. Enter the DNS name or the IP address (e.g. mail.server.com or 10.0.0.100) | | Text | Admin, Admin users, Wizard |
| SmtpServerPass | If you want to use a different password from the one you use to log in to your IMAP server, you can enter it here. | | Text | Admin, Admin users, Wizard |
| SmtpServerPort | The port number your mail server uses to send email using the SMTP protocol. | 25 | Number | Admin, Admin users, Wizard |
| SmtpServerUser | If you want to use a different user name from the one you use to log in to your IMAP server, you can enter it here. | |Text | Admin, Admin users, Wizard |
| Timeout | Number of seconds that SuperOffice will wait for the mail server to finish processing a request. If you experience problems with slow response times from your mail server, you should increase this value to 30 seconds or more. | 15 seconds | Number | Admin, Admin users, Wizard |
| UseMapiReaderAnyway | Use the SuperOffice inbox even if other email integration are installed | NO | Bool | Wizard |
| UseSoMailBody | Use "mail.htm" as body of new emails. The file is looked for in "so\_arc\\username\\mail.htm" and if not found in "so\_arc\\template\\mail.htm" | | | |
| MoveDeletedToDeletedItems | If enabled emails that get deleted are moved to the deleted items folder | | | |
| SaveSentInSentItems | If enabled sent emails are saved in the sent items folder | | | |
