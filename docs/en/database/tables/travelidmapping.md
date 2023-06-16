---
uid: table-travelidmapping
title: travelidmapping table
description: Mapping of primary keys between Travel databases and the mother database  All travel database transactions get a high id to be able to see that this entry came from a database outside the central database. When update files are read into the central database, they get a normal low id. This table remembers the high travel id to map it to the low central id as long as this travel user is travelling. 
so.generated: true
keywords: database table travelidmapping
so.topic: reference
so.envir: onsite, online
---

# travelidmapping Table (43)

Mapping of primary keys between Travel databases and the mother database  All travel database transactions get a high id to be able to see that this entry came from a database outside the central database. When update files are read into the central database, they get a normal low id. This table remembers the high travel id to map it to the low central id as long as this travel user is travelling. 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|travelidmapping\_id|Primary key|PK| |
|associate\_id|Associate id (traveller)|FK [associate](associate.md)| |
|table\_number|Database table number|TableNumber| |
|local\_id|ID on traveller|Id| |
|parent\_id|ID on parent database|Id| |
|counter|How many consecutive ID&apos;s|UInt|&#x25CF;|
|cdbName|Conceptual database name if != standard database|String(29)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![travelidmapping table relationship diagram](./media/travelidmapping.png)

[!include[details](./includes/travelidmapping.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|travelidmapping\_id |PK |Clustered, Unique |
|local\_id |Id |Index |
|associate\_id, table\_number, parent\_id |FK, TableNumber, Id |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

