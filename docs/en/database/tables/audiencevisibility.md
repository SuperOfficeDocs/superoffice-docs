---
uid: table-AudienceVisibility
title: AudienceVisibility table
description: How projects (or whatever) should be made visible in audience
so.generated: true
keywords: database table AudienceVisibility
so.topic: reference
so.envir: onsite, online
---

# AudienceVisibility Table (232)

How projects (or whatever) should be made visible in audience

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|AudienceVisibility\_id|Primary key|PK| |
|sourceTable|Source table, only table &apos;project&apos; valid in Audience for Six|TableNumber| |
|sourceRecord|Record ID in source table. This is the record to be made visible|RecordId| |
|controllingTable|The table that controls visibility of the source record|TableNumber| |
|controllingRecord|The record in the controlling table that defines visibility of the source record|RecordId| |
|constraintEnabled|If 1, this visibility constraint is enabled; otherwise it is there for the record, but not active|Bool| |
|comment|A possible user comment|String(254)|&#x25CF;|
|extraInfo|Extra info value|Id|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AudienceVisibility table relationship diagram](./media/AudienceVisibility.png)

[!include[details](./includes/audiencevisibility.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|AudienceVisibility\_id |PK |Clustered, Unique |
|sourceTable, sourceRecord |TableNumber, RecordId |Index |
|controllingTable, controllingRecord |TableNumber, RecordId |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

