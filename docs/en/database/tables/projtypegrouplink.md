---
uid: table-ProjTypeGroupLink
title: ProjTypeGroupLink table
description: User group link table for ProjType, for MDO item hiding
so.generated: true
keywords: database table ProjTypeGroupLink
so.topic: reference
so.envir: onsite, online
---

# ProjTypeGroupLink Table (86)

User group link table for ProjType, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|projtypegrouplink\_id|Primary key|PK| |
|projtype\_id|Link to ProjType list table|FK [ProjType](projtype.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjTypeGroupLink table relationship diagram](./media/ProjTypeGroupLink.png)

[!include[details](./includes/projtypegrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|projtypegrouplink\_id |PK |Clustered, Unique |
|projtype\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ProjType](projtype.md)  |ProjType list table. List of valid Project types. |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

