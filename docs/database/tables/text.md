---
uid: table-text
title: text table
description: Long text fields from all over the system
so.generated: true
keywords:
  - "database"
  - "text"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# text Table (18)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|text\_id|Primary key|PK| |
|type|Text type, enum that specifies owning table and role|Enum [texttype](enums/texttype.md)|&#x25CF;|
|owner\_id|Record ID of owner record|Id|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Table number of list table that this text contains an extension of; this is obsolete functionality|TableNumber| |
|text|The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases|String(2047)|&#x25CF;|
|lcid|Language/culture code of the text, if known. This is a reserved field for future use|UShort|&#x25CF;|
|seqno|Sequence number, for possible chaining of multiple records to store longer texts|UShort|&#x25CF;|


![text table relationship diagram](./media/text.png)

[!include[details](./includes/text.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|text\_id |PK |Clustered, Unique |
|owner\_id, type |Id, Enum |Index |
|text |String(2047) |Full text |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix on the table's parent.

