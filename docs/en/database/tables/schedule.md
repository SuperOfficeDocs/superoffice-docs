---
uid: table-schedule
title: schedule table
description: Generic scheduled tasked handling time scheduling, locking and error messages
so.generated: true
keywords: database table schedule
so.topic: reference
so.envir: onsite, online
---

# schedule Table (379)

Generic scheduled tasked handling time scheduling, locking and error messages

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|domain|Type of scheduled task|domain|&#x25CF;|
|status|Schedules current status|status|&#x25CF;|
|frequency|Type of schedule algorithm to use|frequency|&#x25CF;|
|asap|Run schedule ASAP|Bool| |
|disabled|Disable the schedule|Bool| |
|stop|Signal to stop schedule|Bool| |
|name|Name of the schedule|String(255)|&#x25CF;|
|after\_schedule\_id|Run after another schedule have completed|FK [schedule](schedule.md)|&#x25CF;|
|minute\_interval|Interval in minutes, used by Minutely|Int|&#x25CF;|
|weekdays|Bitfield: which days of the week to run|Int|&#x25CF;|
|months|Bitfield: which months of the year to run|Int|&#x25CF;|
|min\_of\_hour|Run at a given minute in an hour|Int|&#x25CF;|
|day\_of\_month|What day of month to run|Int|&#x25CF;|
|time\_of\_day|Time of day to execute if not specified.|DateTime|&#x25CF;|
|once\_at|Execute once at|DateTime|&#x25CF;|
|next\_execution|Next execution|DateTime|&#x25CF;|
|last\_execution|Last execution|DateTime|&#x25CF;|
|execution\_time|Amount of time in seconds used by last execution|Int|&#x25CF;|
|lock\_expire|Lock preventing the same schedule to run simultaniously|DateTime|&#x25CF;|
|lock\_pid|PID preventing the same schedule to run simultaniously|Int|&#x25CF;|
|lock\_ttl|Lock time to live|Int|&#x25CF;|
|error\_message|Last error message|Clob|&#x25CF;|
|last\_error|Time of last error|DateTime|&#x25CF;|
|retries|Number of retries since last successfull execution|Int| |
|retry\_interval|Number of minutes between each retry|Int|&#x25CF;|


![schedule table relationship diagram](./media/schedule.png)

[!include[details](./includes/schedule.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|after\_schedule\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[dbi\_agent\_schedule](dbi-agent-schedule.md)  |DBI agent schedule settings |
|[schedule](schedule.md)  |Generic scheduled tasked handling time scheduling, locking and error messages |
|[scheduled\_task](scheduled-task.md)  |A scheduled entry executing a script at certain times |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

