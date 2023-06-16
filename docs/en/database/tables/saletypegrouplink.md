---
uid: table-SaleTypeGroupLink
title: SaleTypeGroupLink table
description: User group link table for SaleType, for MDO item hiding
so.generated: true
keywords: database table SaleTypeGroupLink
so.topic: reference
so.envir: onsite, online
---

# SaleTypeGroupLink Table (150)

User group link table for SaleType, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|saletypegrouplink\_id|Primary key|PK| |
|saletype\_id|Link to SaleType list table|FK [SaleType](saletype.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleTypeGroupLink table relationship diagram](./media/SaleTypeGroupLink.png)

[!include[details](./includes/saletypegrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|saletypegrouplink\_id |PK |Clustered, Unique |
|saletype\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SaleType](saletype.md)  |Type of sale - large solution, incremental, whatever fits the organization |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

