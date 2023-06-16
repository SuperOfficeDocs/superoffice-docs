---
uid: table-s_attachment
title: s_attachment table
description: A connector between a message and attachments. One message can contain many attachments.
so.generated: true
keywords: database table s_attachment
so.topic: reference
so.envir: onsite, online
---

# s\_attachment Table (349)

A connector between a message and attachments. One message can contain many attachments.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|attachment\_id|The id of the attachment|FK [attachment](attachment.md)| |
|message\_id|The id of the message|FK [s_message](s-message.md)| |


![s_attachment table relationship diagram](./media/s_attachment.png)

[!include[details](./includes/s-attachment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|attachment\_id |FK |Index |
|message\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[attachment](attachment.md)  |This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table. |
|[s\_message](s-message.md)  |A message used in a shipment. Can be html and/or plain text |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

