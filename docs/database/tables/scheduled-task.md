---
uid: table-scheduled-task
title: scheduled\_task table
description: A scheduled entry executing a script at certain times
so.generated: true
keywords:
  - "database"
  - "scheduled_task"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# scheduled\_task Table (376)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|script\_id|The id of the script to execute.|FK [ejscript](ejscript.md)|&#x25CF;|
|schedule\_id|Update schedule|FK [schedule](schedule.md)|&#x25CF;|
|description|Optional description of what this task is used for.|String(2047)|&#x25CF;|


![scheduled_task table relationship diagram](./media/scheduled_task.png)

[!include[details](./includes/scheduled-task.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|script\_id |FK |Index |
|schedule\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

