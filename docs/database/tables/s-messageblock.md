---
uid: table-s-messageblock
title: s\_messageblock table
description: Contains a block of a mailing message, that can be reused in a mailing
so.generated: true
keywords:
  - "database"
  - "s_messageblock"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# s\_messageblock Table (480)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|s\_messageblock\_id|Primary key|PK| |
|block|The block definition. Normally this will be a json structure|Clob|&#x25CF;|
|associateId|The associate that owns this block|FK [associate](associate.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![s_messageblock table relationship diagram](./media/s_messageblock.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|s\_messageblock\_id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

