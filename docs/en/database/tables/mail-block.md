---
uid: table-mail_block
title: mail_block table
description: This table controls the spam-protection system, ensuring that a single email recipient does not recieve too many emails during a certain period of time.
so.generated: true
keywords: database table mail_block
so.topic: reference
so.envir: onsite, online
---

# mail\_block Table (316)

This table controls the spam-protection system, ensuring that a single email recipient does not recieve too many emails during a certain period of time.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|mail\_addr|The email address|String(255)|&#x25CF;|
|last\_update|Last time we adjusted the value for this email address.|Int|&#x25CF;|
|time\_pool|The current value for this email address.|Int|&#x25CF;|


![mail_block table relationship diagram](./media/mail_block.png)

[!include[details](./includes/mail-block.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

