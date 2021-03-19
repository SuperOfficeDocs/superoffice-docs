---
uid: system_script
title: system_script table
description: A table containing the system script
so.generated: true
keywords:
  - "database"
  - "system_script"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SystemScript Table (378)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|script\_id|Enum containing the values defining the various scripts|Enum [](enums\Enum.md)|&#x25CF;|
|body|The script|Clob|&#x25CF;|


![system_script table relationship diagram](media\system_script.png)

[!include[details](./includes/system-script.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

