---
uid: table-s_washing
title: s_washing table
description: Register of all bounced mail to enabel washing
so.generated: true
keywords: database table s_washing
so.topic: reference
so.envir: onsite, online
---

# s\_washing Table (341)

Register of all bounced mail to enabel washing

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|email\_addr|The bounced email address|String(255)| |
|bounce|How many bounces we have received on this address.|Int| |
|shipments|How many times we have sent to this address|Int| |
|type|Type of customer (internal/external)|type|&#x25CF;|


![s_washing table relationship diagram](./media/s_washing.png)

[!include[details](./includes/s-washing.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

