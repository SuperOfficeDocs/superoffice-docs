---
uid: table-ejsel_meta_result
title: ejsel_meta_result table
description: This table stores result meta data
so.generated: true
keywords:
  - "database"
  - "ejsel_meta_result"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ejsel\_meta\_result Table (397)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|ejselection|The id of the selection for which this item is part of a result|FK [ejselection](ejselection.md)| |
|owner|The user who owns this selection result|FK [ejuser](ejuser.md)| |
|created\_at|When the result set was created.|DateTime| |


![ejsel_meta_result table relationship diagram](./media/ejsel_meta_result.png)

[!include[details](./includes/ejsel-meta-result.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ejselection |FK |Index |
|owner |FK |Index |
|created\_at |DateTime |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

