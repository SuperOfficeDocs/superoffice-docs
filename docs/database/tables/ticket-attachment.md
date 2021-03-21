---
uid: table-ticket-attachment
title: ticket\_attachment table
description: This table connects an attachment to a message. It references the entry in the attachment table, and the message.
so.generated: true
keywords:
  - "database"
  - "ticket_attachment"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ticket\_attachment Table (256)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|attachment\_id|The attachment.id this reference is connected to.|FK [attachment](attachment.md)|&#x25CF;|
|message\_id|The message.id this reference is connected to.|FK [ej-message](ej-message.md)| |
|content\_id|The content_id of this attachment, used for inline images|String(255)|&#x25CF;|
|inline\_image|True if this attachment is inlined in the html_body.|Bool| |


![ticket_attachment table relationship diagram](./media/ticket_attachment.png)

[!include[details](./includes/ticket-attachment.md)]

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

