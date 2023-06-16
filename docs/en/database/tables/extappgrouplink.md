---
uid: table-ExtAppGroupLink
title: ExtAppGroupLink table
description: User group link table for ExtApp, for MDO item hiding
so.generated: true
keywords: database table ExtAppGroupLink
so.topic: reference
so.envir: onsite, online
---

# ExtAppGroupLink Table (134)

User group link table for ExtApp, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|extappgrouplink\_id|Primary key|PK| |
|extapp\_id|Link to ExtApp list table|FK [ExtApp](extapp.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ExtAppGroupLink table relationship diagram](./media/ExtAppGroupLink.png)

[!include[details](./includes/extappgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|extappgrouplink\_id |PK |Clustered, Unique |
|extapp\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ExtApp](extapp.md)  |ExtApp list table. Applications startable from SuperOffice |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

