---
uid: table-script-trace
title: script\_trace table
description: Scripts which should be traced
so.generated: true
keywords:
  - "database"
  - "script_trace"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# script\_trace Table (468)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|script\_trace\_id|Primary key|PK| |
|name|The friendly name of the script which should be traced|String(255)|&#x25CF;|
|location|The location of the script which should be traced|String(255)|&#x25CF;|
|skip\_frames|Skip n frames between each save to optimize|Int|&#x25CF;|
|enabled|Whether this trace is enabled or not|Bool|&#x25CF;|
|ttl|How long traces should be kept before being deleted (in seconds)|Int|&#x25CF;|
|associate\_id|Optionally limit traces to a specific associate|FK [associate](associate.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![script_trace table relationship diagram](./media/script_trace.png)

[!include[details](./includes/script-trace.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|script\_trace\_id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

