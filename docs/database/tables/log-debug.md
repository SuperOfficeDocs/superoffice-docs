---
uid: table-log-debug
title: log\_debug table
description: A log used for debugging, especially useful for bLogic/ejscript
so.generated: true
keywords:
  - "database"
  - "log_debug"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# log\_debug Table (365)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|info|Debug info|Clob|&#x25CF;|
|time\_of\_entry|When the event happened|DateTime|&#x25CF;|


![log_debug table relationship diagram](./media/log_debug.png)

[!include[details](./includes/log-debug.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

