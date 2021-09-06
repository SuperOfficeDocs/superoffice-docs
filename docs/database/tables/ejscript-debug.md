---
uid: table-ejscript-debug
title: ejscript\_debug table
description: This table contains information when debugging an ejscript
so.generated: true
keywords:
  - "database"
  - "ejscript_debug"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ejscript\_debug Table (387)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|debug\_id|The debugId for the session|String(255)|&#x25CF;|
|started\_at|The timestamp of when the debug session was initiated.|DateTime|&#x25CF;|
|status|The current status of this debug session. See EjscriptDebug|status|&#x25CF;|
|skip\_count|The number of wait-statements to skip.|Int|&#x25CF;|
|info|Information saved by the running script|Clob|&#x25CF;|
|code\_view|The chunk of code around the breakpoint|Clob|&#x25CF;|
|code\_line\_pos|The current line position in the code.|Int|&#x25CF;|
|code\_run\_until|The line to run to in debug mode.|Int|&#x25CF;|
|variable\_view|A dump of all variables|Clob|&#x25CF;|


![ejscript_debug table relationship diagram](./media/ejscript_debug.png)

[!include[details](./includes/ejscript-debug.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

