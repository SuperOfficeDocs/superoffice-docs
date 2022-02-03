---
uid: table-mail_alias
title: mail_alias table
description: This table contains the alias&amp;apos;es for each mailbox, one-to-many-relation. It is in so we can substract the alias&amp;apos;es when when listing the recipients of a message.     
so.generated: true
keywords:
  - "database"
  - "mail_alias"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# mail\_alias Table (273)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|filter\_id|The mailbox which the alias belongs to|FK [mail_in_filter](mail-in-filter.md)| |
|alias|The alias for the mailbox|String(255)|&#x25CF;|


![mail_alias table relationship diagram](./media/mail_alias.png)

[!include[details](./includes/mail-alias.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|filter\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

