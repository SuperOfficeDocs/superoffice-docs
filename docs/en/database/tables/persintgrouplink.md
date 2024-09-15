---
uid: table-PersIntGroupLink
title: PersIntGroupLink table
description: User group link table for PersInt, for MDO item hiding
so.generated: true
keywords: database table PersIntGroupLink
so.topic: reference
so.envir: onsite, online
---

# PersIntGroupLink Table (74)

User group link table for PersInt, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|persintgrouplink\_id|Primary key|PK| |
|persint\_id|Link to PersInt list table|FK [PersInt](persint.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PersIntGroupLink table relationship diagram](./media/PersIntGroupLink.png)

[!include[details](./includes/persintgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|persintgrouplink\_id |PK |Clustered, Unique |
|persint\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PersInt](persint.md)  |PersInt list table. List of Person interests. |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

