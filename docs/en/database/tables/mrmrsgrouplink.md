---
uid: table-MrMrsGroupLink
title: MrMrsGroupLink table
description: User group link table for MrMrs, for MDO item hiding
so.generated: true
keywords: database table MrMrsGroupLink
so.topic: reference
so.envir: onsite, online
---

# MrMrsGroupLink Table (95)

User group link table for MrMrs, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|mrmrsgrouplink\_id|Primary key|PK| |
|mrmrs\_id|Link to MrMrs list table|FK [MrMrs](mrmrs.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![MrMrsGroupLink table relationship diagram](./media/MrMrsGroupLink.png)

[!include[details](./includes/mrmrsgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|mrmrsgrouplink\_id |PK |Clustered, Unique |
|mrmrs\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[MrMrs](mrmrs.md)  |MrMrs list table. List of salutations. |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

