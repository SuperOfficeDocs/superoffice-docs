---
uid: table-mail-in-uidl
title: mail\_in\_uidl table
description: This table is used to avoid spamming the system by importing the same message several times (normally a result of a crash somewhere). When a mailbox is openede, then unique id for each message is stored in this table, and then removed only when the message has been correctly imported and deleted from mailbox.
so.generated: true
keywords:
  - "database"
  - "mail_in_uidl"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# mail\_in\_uidl Table (272)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|filter\_id|The mailbox for this UIDL entry.|FK [mail-in-filter](mail-in-filter.md)| |
|uidl|The actual UIDL (i.e. the unique string identifying a specific message).|String(2047)|&#x25CF;|
|last\_checked|The last time this message was attempted to be imported.|DateTime|&#x25CF;|
|status|The status of this UIDL entry (enum).|status|&#x25CF;|
|retries|The number of attempts for importing this message.|Int|&#x25CF;|


![mail_in_uidl table relationship diagram](./media/mail_in_uidl.png)

[!include[details](./includes/mail-in-uidl.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|filter\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

