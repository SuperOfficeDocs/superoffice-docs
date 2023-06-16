---
uid: table-reply_template_attachment
title: reply_template_attachment table
description: This table is used to connect attachments to reply templates (many-to-many).
so.generated: true
keywords: database table reply_template_attachment
so.topic: reference
so.envir: onsite, online
---

# reply\_template\_attachment Table (278)

This table is used to connect attachments to reply templates (many-to-many).

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|entry\_id|The id of the reply_template this entry is connected to.|FK [reply_template](reply-template.md)| |
|attachment\_id|The id of the attachment this entry is connected to.|FK [attachment](attachment.md)| |


![reply_template_attachment table relationship diagram](./media/reply_template_attachment.png)

[!include[details](./includes/reply-template-attachment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|entry\_id |FK |Index |
|attachment\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[attachment](attachment.md)  |This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table. |
|[reply\_template](reply-template.md)  |Templates for automatic and manual replies to emails/sms organized hierachically |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

