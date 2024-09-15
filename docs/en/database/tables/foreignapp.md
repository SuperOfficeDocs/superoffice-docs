---
uid: table-foreignapp
title: foreignapp table
description: Top level of Foreign Key system
so.generated: true
keywords: database table foreignapp
so.topic: reference
so.envir: onsite, online
---

# foreignapp Table (181)

Top level of Foreign Key system

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|foreignapp\_id|Primary key|PK| |
|name|Name of foreign application|String(254)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![foreignapp table relationship diagram](./media/foreignapp.png)

[!include[details](./includes/foreignapp.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|foreignapp\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[foreigndevice](foreigndevice.md)  |Middle level of Foreign Key system |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

