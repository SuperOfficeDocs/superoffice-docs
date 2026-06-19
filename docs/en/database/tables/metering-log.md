---
uid: table-metering_log
title: metering_log table
description: Metering log table
generated: true
keywords: database table metering_log
content_type: reference
envir: onsite, online
---

# metering\_log Table (501)

Metering log table

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|metering\_log\_id|Primary key|PK| |
|table\_id|Which table the event relates to|TableNumber|&#x25CF;|
|record\_id|The record within that table|RecordId|&#x25CF;|
|event\_type|Type of the metering event|Enum [MeteringEventType](enums/meteringeventtype.md)| |
|status|Status of the metering event|Enum [MeteringStatus](enums/meteringstatus.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![metering_log table relationship diagram](./media/metering_log.png)

[!include[details](./includes/metering-log.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|table\_id, record\_id, event\_type |TableNumber, RecordId, Enum |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

