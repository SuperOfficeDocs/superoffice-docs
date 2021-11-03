---
uid: table-reply_template_attachment
title: reply_template_attachment table
description: This table is used to connect attachments to reply templates (many-to-many).
so.generated: true
keywords:
  - "database"
  - "reply_template_attachment"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reply\_template\_attachment Table (278)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|entry\_id|The id of the reply_template this entry is connected to.|FK [reply_template](reply-template.md)| |
|attachment\_id|The id of the attachment this entry is connected to.|FK [attachment](attachment.md)| |


![reply_template_attachment table relationship diagram](./media/reply_template_attachment.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|entry\_id |FK |Index |
|attachment\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

