---
uid: table-attachment
title: attachment table
description: This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table.
so.generated: true
keywords: database table attachment
so.topic: reference
so.envir: onsite, online
---

# attachment Table (296)

This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|content\_type|The content type for the attachment (e.g. &amp;apos;applaction/octet-stream&amp;apos; or &amp;apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&amp;apos;).|String(255)|&#x25CF;|
|name|The filename for the attachment.|String(255)|&#x25CF;|
|att\_size|The size (in bytes) for the attachment.|Int|&#x25CF;|
|auth\_key|The key used for authenticating access to this attachment.|String(255)|&#x25CF;|
|charset|The charset if this is a text attachment|String(255)|&#x25CF;|
|dbi\_agent\_id|Integration agent (eJournal)|FK [dbi_agent](dbi-agent.md)| |
|dbi\_key|The primary key for the integrated entry in the external datasource.|String(255)| |
|dbi\_last\_syncronized|Last external syncronization.|DateTime| |
|dbi\_last\_modified|When the entry was last modified.|DateTime| |
|attachment\_location\_id|The id of the attachment_location this attachment is stored in|FK [attachment_location](attachment-location.md)|&#x25CF;|


![attachment table relationship diagram](./media/attachment.png)

[!include[details](./includes/attachment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|dbi\_agent\_id |FK |Index |
|dbi\_key |String(255) |Index |
|dbi\_last\_syncronized |DateTime |Index |
|dbi\_last\_modified |DateTime |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[attachment\_location](attachment-location.md)  |A location for storing attachments |
|[dbi\_agent](dbi-agent.md)  |DBI agent settings |
|[doc\_document](doc-document.md)  |This table contains documents. |
|[ej\_message](ej-message.md)  |This table contains the messages listed under tickets. |
|[ejpackage](ejpackage.md)  |This table stores packages on the system. |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |
|[external\_document](external-document.md)  |This table stores documents which can be viewed externaly, through the customer module |
|[kb\_attachment](kb-attachment.md)  |This table connects FAQ entries to attachments. |
|[reply\_template\_attachment](reply-template-attachment.md)  |This table is used to connect attachments to reply templates (many-to-many). |
|[s\_attachment](s-attachment.md)  |A connector between a message and attachments. One message can contain many attachments. |
|[s\_picture\_entry](s-picture-entry.md)  |This table describes each picture in the database |
|[ticket\_attachment](ticket-attachment.md)  |This table connects an attachment to a message. It references the entry in the attachment table, and the message. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

