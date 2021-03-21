---
uid: table-s-attachment
title: s\_attachment table
description: A connector between a message and attachments. One message can contain many attachments.
so.generated: true
keywords:
  - "database"
  - "s_attachment"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# s\_attachment Table (349)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|attachment\_id|The id of the attachment|FK [attachment](attachment.md)| |
|message\_id|The id of the message|FK [s-message](s-message.md)| |


![s_attachment table relationship diagram](./media/s_attachment.png)

[!include[details](./includes/s-attachment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|attachment\_id |FK |Index |
|message\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

