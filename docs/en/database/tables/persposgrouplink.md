---
uid: table-PersPosGroupLink
title: PersPosGroupLink table
description: User group link table for PersPos, for MDO item hiding
so.generated: true
keywords: database table PersPosGroupLink
so.topic: reference
so.envir: onsite, online
---

# PersPosGroupLink Table (77)

User group link table for PersPos, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|persposgrouplink\_id|Primary key|PK| |
|perspos\_id|Link to PersPos list table|FK [PersPos](perspos.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PersPosGroupLink table relationship diagram](./media/PersPosGroupLink.png)

[!include[details](./includes/persposgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|persposgrouplink\_id |PK |Clustered, Unique |
|perspos\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PersPos](perspos.md)  |PersPos list table. Contact person position list |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

