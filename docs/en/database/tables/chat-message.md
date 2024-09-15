---
uid: table-chat_message
title: chat_message table
description: This table contains messages in a chat session.
so.generated: true
keywords: database table chat_message
so.topic: reference
so.envir: onsite, online
---

# chat\_message Table (333)

This table contains messages in a chat session.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|session\_id|The reference to the associated chat session.|FK [chat_session](chat-session.md)| |
|message|The message.|Clob|&#x25CF;|
|when\_posted|When the message was posted (UTC timestamp).|DateTime|&#x25CF;|
|special\_type|Enum indicating if it is a special message, such as an URL redirection, etc.|Enum [ChatMessageSpecialType](enums/chatmessagespecialtype.md)|&#x25CF;|
|special\_param|Special parameter for the special_type.|String(255)|&#x25CF;|
|read\_by\_customer|Whether the message has been read by the customer or not.|Bool|&#x25CF;|
|type|The type of the message.|Enum [ChatMessageType](enums/chatmessagetype.md)|&#x25CF;|
|author|The author of the message.|String(255)|&#x25CF;|
|created\_by|The user agent who wrote the message. -1 if customer|FK [ejuser](ejuser.md)|&#x25CF;|


![chat_message table relationship diagram](./media/chat_message.png)

[!include[details](./includes/chat-message.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|session\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[chat\_session](chat-session.md)  |This table contains chat sessions. |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

