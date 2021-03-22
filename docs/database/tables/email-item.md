---
uid: table-email-item
title: email\_item table
description: Email data
so.generated: true
keywords:
  - "database"
  - "email_item"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# email\_item Table (477)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|email\_item\_id|Primary key|PK| |
|account\_id|Account id|FK [email-account](email-account.md)|&#x25CF;|
|server\_id|Email server id of this email item|Int| |
|flags|Email flags - answered, deleted, seen, flagged, draft, recent...|Enum [emailflags](enums/emailflags.md)|&#x25CF;|
|email\_folder\_id|Folder this email is in on the imap server|FK [email-folder](email-folder.md)|&#x25CF;|
|mime|Mime text|Clob|&#x25CF;|
|messageId|Email MessageId|String(512)|&#x25CF;|
|sent\_at|Sent datetime from mime|DateTime|&#x25CF;|
|received\_at|Received by email server|DateTime|&#x25CF;|
|subject|Email subject|String(255)|&#x25CF;|
|plain\_body|Plain body text|Clob|&#x25CF;|
|html\_body|Html body text|Clob|&#x25CF;|
|priority|Email priority|Enum [emailpriority](enums/emailpriority.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|has\_attachment|Has attachment(s)|Bool|&#x25CF;|
|from|From address|String(4000)|&#x25CF;|
|to|To|String(4000)|&#x25CF;|
|size|The size of the email|Int| |
|person\_id|From person|FK [person](person.md)|&#x25CF;|
|contact\_id|From company|FK [contact](contact.md)|&#x25CF;|
|document\_id|Archived document|FK [document](document.md)|&#x25CF;|
|appointment\_id|Archived on appointment|FK [appointment](appointment.md)|&#x25CF;|
|sale\_id|Archived on sale|FK [sale](sale.md)|&#x25CF;|
|replied\_at|When this email was replied to|DateTime|&#x25CF;|
|in\_reply\_to|In reply to, a message-id, used for threading|String(512)|&#x25CF;|
|cc|Cc|String(4000)|&#x25CF;|
|cal\_data|Calendar data|Clob|&#x25CF;|


![email_item table relationship diagram](./media/email_item.png)

[!include[details](./includes/email-item.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|email\_item\_id |PK |Clustered, Unique |
|server\_id |Int |Index |
|account\_id |FK |Index |
|account\_id, server\_id |FK, Int |Index |
|messageId |String(512) |Index |
|email\_folder\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

