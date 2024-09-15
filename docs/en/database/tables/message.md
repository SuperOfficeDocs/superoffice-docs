---
uid: table-Message
title: Message table
description: Definition of a message, corresponding to the header of a protocol
so.generated: true
keywords: database table Message
so.topic: reference
so.envir: onsite, online
---

# Message Table (242)

Definition of a message, corresponding to the header of a protocol

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Message\_id|Primary key|PK| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|associateId|The associate that is the target of this message|FK [associate](associate.md)| |
|onlineapp\_id|The online app that owns this message|FK [OnlineApp](onlineapp.md)| |
|systemMessageId|Message identifier, used for message update or removal|String(255)| |
|markdownMessage|Markdown message to be displayed to user|String(4000)| |
|expire|The date and time the message expires|UtcDateTime| |
|type|Type of message, example: info, warning, error|Enum [SystemMessageType](enums/systemmessagetype.md)| |


![Message table relationship diagram](./media/Message.png)

[!include[details](./includes/message.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Message\_id |PK |Clustered, Unique |
|associateId, systemMessageId, onlineapp\_id |FK, String(255), FK |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[OnlineApp](onlineapp.md)  |Echo and track information about Online Apps and their usage |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

