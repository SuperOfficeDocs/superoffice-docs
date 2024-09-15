---
uid: table-reply_template
title: reply_template table
description: Templates for automatic and manual replies to emails/sms organized hierachically
so.generated: true
keywords: database table reply_template
so.topic: reference
so.envir: onsite, online
---

# reply\_template Table (277)

Templates for automatic and manual replies to emails/sms organized hierachically

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|name|The name for this reply template.|String(255)| |
|description|The description for this reply template.|String(255)|&#x25CF;|
|folder\_id|The id of the folder in which this reply template is located. NULL or -1 if this is a toplevel reply template.|FK [reply_template_folder](reply-template-folder.md)| |
|owned\_by|The id of the user who owns this reply template.|FK [ejuser](ejuser.md)|&#x25CF;|
|last\_changed|When the reply template was last changed.|DateTime|&#x25CF;|
|access\_level|The access level (enum) for this reply template.|access_level|&#x25CF;|
|flags|Reply template type, for example &quot;new customer&quot; or &quot;new password&quot;. While called flags - this is not actually flags. Only one type can be used at a time.|Int|&#x25CF;|


![reply_template table relationship diagram](./media/reply_template.png)

[!include[details](./includes/reply-template.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|name |String(255) |Index |
|folder\_id |FK |Index |
|owned\_by |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_category](ej-category.md)  |This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner. |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |
|[mail\_in\_filter](mail-in-filter.md)  |This table contains entries for the mailboxes the eJournal system is fetching mail from (POP3 or IMAP). |
|[ms\_filter](ms-filter.md)  |This table contains email filters. These are the filters allowing you to do advanced parsing of incomming emails. |
|[reply\_template\_attachment](reply-template-attachment.md)  |This table is used to connect attachments to reply templates (many-to-many). |
|[reply\_template\_body](reply-template-body.md)  |Contains the body of the reply templates in different languages |
|[reply\_template\_folder](reply-template-folder.md)  |This table contains entries for folders for reply templates. |
|[ticket\_alert](ticket-alert.md)  |This table will contain ticket escalation levels. A ticket will be escalated along a &amp;apos;chain&amp;apos; of these levels. |
|[ticket\_type](ticket-type.md)  |A ticket (request) type |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

