---
uid: snapshot
title: snapshot table
description: Snapshots taken of the system database and attachments via soap
so.generated: true
keywords:
  - "database"
  - "snapshot"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Snapshot Table (369)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|created\_at|Snapshot file created at|DateTime|&#x25CF;|
|user\_comment|Comment from the user|String(255)|&#x25CF;|


![snapshot table relationship diagram](media\snapshot.png)

[!include[details](./includes/snapshot.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

