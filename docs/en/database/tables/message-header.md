---
uid: table-message_header
title: message_header table
description: This table contains small pieces of information which is listed over the body for each message.
so.generated: true
keywords: database table message_header
so.topic: reference
so.envir: onsite, online
---

# message\_header Table (259)

This table contains small pieces of information which is listed over the body for each message.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|message\_id|The id of the message this header entry is connected to.|FK [ej_message](ej-message.md)| |
|type|The type for this header entry.|type|&#x25CF;|
|name|A name for this entry.|String(64)|&#x25CF;|
|value|A value for this entry.|Clob|&#x25CF;|
|std\_item|If this has a value, it indicates that a standard header text from the language database should be used - and witch one to use.       |std_item|&#x25CF;|
|std\_item\_col|If this is 1, concatenate the standard item text with header name field, if 2 use header value field instead. If this col is 0, use the empty field - preferably the value column.       |std_item_col|&#x25CF;|


![message_header table relationship diagram](./media/message_header.png)

[!include[details](./includes/message-header.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|message\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_message](ej-message.md)  |This table contains the messages listed under tickets. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

