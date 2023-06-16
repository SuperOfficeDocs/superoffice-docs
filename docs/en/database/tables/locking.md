---
uid: table-locking
title: locking table
description: Generic locking and error messages
so.generated: true
keywords: database table locking
so.topic: reference
so.envir: onsite, online
---

# locking Table (380)

Generic locking and error messages

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|status|Current status|status|&#x25CF;|
|stop|Signal to stop schedule|Bool| |
|last\_execution|Last execution|DateTime|&#x25CF;|
|execution\_time|Amount of time in seconds used by last execution|Int|&#x25CF;|
|lock\_expire|Lock preventing the same schedule to run simultaniously|DateTime|&#x25CF;|
|lock\_pid|PID preventing the same schedule to run simultaniously|Int|&#x25CF;|
|lock\_ttl|Lock time to live|Int|&#x25CF;|
|error\_message|Last error message|Clob|&#x25CF;|
|last\_error|Time of last error|DateTime|&#x25CF;|
|retries|Number of retries since last successfull execution|Int| |


![locking table relationship diagram](./media/locking.png)

[!include[details](./includes/locking.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[inbox](inbox.md)  |Info and status for safe email import |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

