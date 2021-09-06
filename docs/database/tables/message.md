---
uid: table-message
title: message table
description: Definition of a message, corresponding to the header of a protocol
so.generated: true
keywords:
  - "database"
  - "Message"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# message Table (242)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Message\_id|Primary key|PK| |
|sourceHandler|Originating message handler|FK [messagehandler](messagehandler.md)| |
|targetHandler|Target message handler|FK [messagehandler](messagehandler.md)| |
|motherId|ID of message that this message is correlated to; 0 if this is the first message of a conversation|FK [message](message.md)|&#x25CF;|
|messageType|Application-specific message type|UInt| |
|detailsTable|Table containing message body (BatchTask, or some thing else)|TableNumber| |
|detailsRecord|Record containing message body|RecordId| |
|description|Message description, to aid in debugging and monitoring|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Message table relationship diagram](./media/Message.png)

[!include[details](./includes/Message.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Message\_id |PK |Clustered, Unique |
|sourceHandler |FK |Index |
|targetHandler |FK |Index |
|motherId |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

